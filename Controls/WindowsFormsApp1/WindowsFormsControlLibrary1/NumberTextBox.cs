using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class NumberTextBox : TextBox
    {
        private NumberSystems numberSystem;

        public NumberTextBox()
        {
            InitializeComponent();
        }

        public NumberTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public NumberSystems NumberSystem
        {
            get => numberSystem;
            set
            {
                numberSystem = value;
                Value = Value;
            }
        }

        public byte Value
        {
            get
            {
                if (string.IsNullOrEmpty(Text))
                    return 0;
                if (NumberSystem == NumberSystems.Dec)
                {
                    try
                    {
                        int.Parse(Text);
                        return byte.Parse(Text);
                    }
                    catch
                    {
                        return (byte)Convert.ToInt32(Text, 16);
                    }
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(Text);
                        if (Convert.ToInt32(Text) > 100)
                        {
                            int A = Convert.ToInt32(Text);
                            Text = A.ToString("X");
                            return byte.Parse(Text, NumberStyles.HexNumber);
                        }
                        return byte.Parse(Text, NumberStyles.HexNumber);
                    }
                    catch
                    {
                        return byte.Parse(Text, NumberStyles.HexNumber);
                    }

                }
            }
            set
            {
                if (NumberSystem == NumberSystems.Dec)
                    Text = value.ToString();
                else
                    Text = value.ToString("X");
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            var pattern = @"^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9]{1,2})$";
            if (NumberSystem == NumberSystems.Hex)
                pattern = @"^(?:0x)?(?:0?[0-9a-fA-F]{1,2}|1[0-9a-fA-F]{2}|2[0-4][0-9a-fA-F]|25[0-5])$";

            if (NumberSystem == NumberSystems.Dec)
                pattern = @"^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9]{1,2})$";

            if ((!Regex.IsMatch(Text, pattern)) & NumberSystem == NumberSystems.Dec)
            {
                try
                {
                    Convert.ToInt32(Text);
                    if (Convert.ToInt32(Text) > 128)
                    {
                        Text = "255";
                    }
                    else 
                    {
                        Text = "0";
                    }
                }
                catch
                {
                    Text = "0";
                }
            }

            if ((!Regex.IsMatch(Text, pattern)) & NumberSystem == NumberSystems.Hex)
                try
                {
                    Convert.ToInt32(Text, 16);
                    Text = "FF";
                }
                catch
                {
                    Text = "0";
                }
            base.OnTextChanged(e);
        }
    }
}
