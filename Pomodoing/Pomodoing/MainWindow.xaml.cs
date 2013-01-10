using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Pomodoing
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private DispatcherTimer Timer;
		private bool PomodoroStarted; //
		private int timeMinutes;
        private TimeSpan timeRemaining;
		public MainWindow()
		{
			this.InitializeComponent();
			
			Timer = new DispatcherTimer();
			Timer.Tick += new EventHandler(Timer_Tick);
			Timer.Interval = new TimeSpan(0, 0, 1);
			timeMinutes = 25;
            timeRemaining = new TimeSpan(0, 25, 0);
		}

		void Timer_Tick(object sender, EventArgs e)
		{
			//logic to handle the display of numbers here. Maybe binding the variables is a good idea but then again is over optimization for now. 
            timeRemaining = timeRemaining.Subtract(TimeSpan.FromSeconds(1.00));
            lblMinutes.Content = timeRemaining.Minutes;
            lblSeconds.Content = timeRemaining.Seconds.ToString(;
		}

		private void btnStartStop_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			if (PomodoroStarted)
			{

			}
			else
			{
				Timer.Start();    
			}
			
				
		}
	}
}