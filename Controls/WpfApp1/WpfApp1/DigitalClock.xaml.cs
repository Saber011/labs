using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfApp1
{
	public partial class DigitalClock : UserControl
	{
		public DigitalClock()
		{
			InitializeComponent();

			var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
			timer.Tick += TimerOnTick;
			timer.Start();
		}

		private void TimerOnTick(object sender, EventArgs e)
		{
			Time = DateTime.Now;
		}

		public static readonly DependencyProperty TimeProperty = DependencyProperty.Register(
			"Time",
			typeof(DateTime),
			typeof(DigitalClock),
			new PropertyMetadata(default(DateTime), TimeChangedCallback));

		public DateTime Time
		{
			get { return (DateTime)GetValue(TimeProperty); }
			set { SetValue(TimeProperty, value); }
		}

		private static void TimeChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
		{
			if (!(dependencyObject is DigitalClock digitalClock) || !(dependencyPropertyChangedEventArgs.NewValue is DateTime time))
				return;

			digitalClock.HoursTens.Value = time.Hour / 10 % 10;
			digitalClock.HoursUnits.Value = time.Hour % 10;
			digitalClock.MinutesTens.Value = time.Minute / 10;
			digitalClock.MinutesUnits.Value = time.Minute % 10;
			digitalClock.SecondsTens.Value = time.Second / 10;
			digitalClock.SecondsUnits.Value = time.Second % 10;
		}
	}
}
