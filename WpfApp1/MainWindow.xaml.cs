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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer Timer { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromMilliseconds(1000);
            Timer.Tick += Timer_Tick;
            //myTabControl.AlternationCount = 2;
            //Timer.Start();
            List<DateTime> dates = new List<DateTime>
            {
                DateTime.Now,
                DateTime.Now.AddYears(-2),
                DateTime.Now.AddYears(-5),
            };
            //myListBox.ItemsSource = dates;

            //myListBox.ItemsSource = GetCars();
            // myListBox.SelectedIndex = 0;
            // myCombobox.ItemsSource = GetCars();
            //carsDataGrid.ItemsSource = GetCars();
        }

        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                     Model="La ferrari",
                     Vendor="Ferrari",
                     Year=2020,
                     ImageUrl="images/ferrari.jpg"
                },
                new Car
                {
                     Model="Cayenne",
                     Vendor="Porsche",
                     Year=2022,
                     ImageUrl="images/p1.jpg"
                },
                new Car
                {
                     Model="Taycan",
                     Vendor="Porsche",
                     Year=2018,
                     ImageUrl="images/p2.jpg"
                },
            };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //if(myTabControl.SelectedIndex<myTabControl.AlternationCount)
            //myTabControl.SelectedIndex += 1;
            //else
            //{
            //    myTabControl.SelectedIndex =0;
            //}
            //if (myPrgBar.Value < myPrgBar.Maximum)
            //{
            //    myPrgBar.Value += 1;
            //}
            //else
            //{
            //    Timer.Stop();
            //    MessageBox.Show("Finish");
            //}
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            //if(myPrgBar.Value > 0)
            //myPrgBar.Value -= 5;
        }

        private void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        {
            //if (myPrgBar.Value < myPrgBar.Maximum)
            //{
            //    myPrgBar.Value += 5;
            //}
            //else
            //{
            //    MessageBox.Show("Finish");
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();  
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           // myLabel.FontSize = (sender as Slider).Value;
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car = myListBox.SelectedItem as Car;
           // carInfoLbl.Content = $"{car.Model} {car.Vendor} {car.Year}";
        }
    }
}
