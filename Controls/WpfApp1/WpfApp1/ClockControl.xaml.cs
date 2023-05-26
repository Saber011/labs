using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for ClockControl.xaml
	/// </summary>
	public partial class ClockControl : UserControl
	{
		private readonly Line _hourHand;
		private readonly Line _minuteHand;
		private readonly Line _secondHand;
		private readonly DispatcherTimer _timer;

		public ClockControl()
		{
			InitializeComponent();
			_hourHand = new Line { Stroke = Brushes.Black, StrokeThickness = 6, X1 = 100, Y1 = 100 };
			_minuteHand = new Line { Stroke = Brushes.Black, StrokeThickness = 4, X1 = 100, Y1 = 100 };
			_secondHand = new Line { Stroke = Brushes.Red, StrokeThickness = 2, X1 = 100, Y1 = 100 };

			ClockCanvas.Children.Add(_hourHand);
			ClockCanvas.Children.Add(_minuteHand);
			ClockCanvas.Children.Add(_secondHand);

			for (var i = 0; i < 60; i++)
			{
				var angle = (i * 6) * Math.PI / 180;
				var markLength = i % 5 == 0 ? 20 : 10;
				var markThickness = i % 5 == 0 ? 2 : 1;
				var minuteMark = new Line
				{
					Stroke = Brushes.Black,
					StrokeThickness = markThickness,
					X1 = 100 + 80 * Math.Sin(angle),
					Y1 = 100 - 80 * Math.Cos(angle),
					X2 = 100 + (80 - markLength) * Math.Sin(angle),
					Y2 = 100 - (80 - markLength) * Math.Cos(angle),
				};
				ClockCanvas.Children.Add(minuteMark);
			}

			_timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
			_timer.Tick += (sender, args) => UpdateClockHands();
			_timer.Start();
		}

		private void UpdateClockHands()
		{
			var now = DateTime.Now;
			var totalSeconds = now.TimeOfDay.TotalSeconds;

			_hourHand.X2 = 100 + 40 * Math.Sin(totalSeconds * Math.PI / 43200);
			_hourHand.Y2 = 100 - 40 * Math.Cos(totalSeconds * Math.PI / 43200);

			_minuteHand.X2 = 100 + 60 * Math.Sin(totalSeconds * Math.PI / 3600);
			_minuteHand.Y2 = 100 - 60 * Math.Cos(totalSeconds * Math.PI / 3600);

			_secondHand.X2 = 100 + 80 * Math.Sin(totalSeconds * Math.PI / 60);
			_secondHand.Y2 = 100 - 80 * Math.Cos(totalSeconds * Math.PI / 60);
		}
	}
}
