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

namespace WpfApp1
{
	public partial class SevenSegment : UserControl
	{
		public SevenSegment()
		{
			InitializeComponent();
		}

		private static readonly bool[,] SegmentStatus = {
		{ true, true, true, false, true, true, true }, // 0
        { false, true, true, false, false, false, false }, // 1
        { true, true, true, true, true, false, true }, // 2
        { true, true, true, true, false, false, true }, // 3
        { false, true, true, false, false, true, true }, // 4
        { true, true, false, true, false, true, true }, // 5
        { true, true, false, true, true, true, true }, // 6
        { true, false, true, false, false, true, false }, // 7
        { true, true, true, true, true, true, true }, // 8
        { true, true, true, true, false, true, true } // 9
    };

		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
			"Value",
			typeof(int),
			typeof(SevenSegment),
			new PropertyMetadata(default(int), ValueChangedCallback));

		private static void ValueChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
		{
			if (!(dependencyObject is SevenSegment sevenSegment) || !(dependencyPropertyChangedEventArgs.NewValue is int value))
				return;

			Brush activeColor = sevenSegment.ActiveColor;

			sevenSegment.Top.Fill = SegmentStatus[value, 0] ? activeColor : Brushes.LightGray;
			sevenSegment.TopRight.Fill = SegmentStatus[value, 1] ? activeColor : Brushes.LightGray;
			sevenSegment.BottomRight.Fill = SegmentStatus[value, 2] ? activeColor : Brushes.LightGray;
			sevenSegment.Bottom.Fill = SegmentStatus[value, 3] ? activeColor : Brushes.LightGray;
			sevenSegment.BottomLeft.Fill = SegmentStatus[value, 4] ? activeColor : Brushes.LightGray;
			sevenSegment.TopLeft.Fill = SegmentStatus[value, 5] ? activeColor : Brushes.LightGray;
			sevenSegment.Middle.Fill = SegmentStatus[value, 6] ? activeColor : Brushes.LightGray;
		}

		public int Value
		{
			get { return (int)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		public static readonly DependencyProperty ActiveColorProperty = DependencyProperty.Register(
			"ActiveColor",
			typeof(Brush),
			typeof(SevenSegment),
			new PropertyMetadata(Brushes.Red));

		public Brush ActiveColor
		{
			get { return (Brush)GetValue(ActiveColorProperty); }
			set { SetValue(ActiveColorProperty, value); }
		}
	}
}

