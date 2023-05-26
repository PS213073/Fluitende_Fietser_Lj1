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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace project2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        double betaald;
        double prijs;
        double change;
        double aantal;
        bool _reset = false;

        public Window2(double _totaal, double _prijs, bool reset)
        {
            InitializeComponent();
            _reset = reset;
            if (_reset == true)
            {
                //resetten
                spChange.Children.Clear();
                DispatcherTimer closeWindow = new DispatcherTimer();
                closeWindow.Interval = TimeSpan.FromMilliseconds(1);
                closeWindow.Tick += close_Tick;
                closeWindow.Start();
            }
            else
            {
                //aantal van alles berekenen
                betaald = _totaal;
                prijs = _prijs;
                change = betaald - prijs;
                if (change / 200 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 200);
                    change -= 200;
                    tbChange.Text = aantal + " keer €200";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 100 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 100);
                    change -= 100;
                    tbChange.Text = aantal + " keer €100";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 50 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 50);
                    change -= 50;
                    tbChange.Text = aantal + " keer €50";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 20 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 20);
                    change -= 20;
                    tbChange.Text = aantal + " keer €20";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 10 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 10);
                    change -= 10;
                    tbChange.Text = aantal + " keer €10";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 5 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 5);
                    change -= 5;
                    tbChange.Text = aantal + " keer €5";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 2 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 2);
                    change -= 2;
                    tbChange.Text = aantal + " keer €2";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 1 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 1);
                    change -= 1;
                    tbChange.Text = aantal + " keer €1";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 0.5 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 0.5);
                    change -= 0.5;
                    tbChange.Text = aantal + " keer €0.5";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 0.2 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 0.2);
                    change -= 0.2;
                    tbChange.Text = aantal + " keer €0.2";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 0.1 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 0.1);
                    change -= 0.1;
                    tbChange.Text = aantal + " keer €0.1";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
                if (change / 0.05 >= 1)
                {
                    TextBlock tbChange = new TextBlock();
                    aantal = Math.Floor(change / 0.05);
                    change -= 0.05;
                    tbChange.Text = aantal + " keer €0.05";
                    tbChange.FontSize = 28;
                    spChange.Children.Add(tbChange);
                }
            }
            this.Height = spChange.Height + 115;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_reset == false)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
