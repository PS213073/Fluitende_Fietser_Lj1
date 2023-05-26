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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        double _5cent = 0;
        double _10cent = 0;
        double _20cent = 0;
        double _50cent = 0;
        double _1euro = 0;
        double _2euro = 0;
        double _5euro = 0;
        double _10euro = 0;
        double _20euro = 0;
        double _50euro = 0;
        double _100euro = 0;
        double _200euro = 0;
        double _totaal = 0;
        double _prijs;
        bool reset = false;

        public Window1(double prijs, bool reset)
        {
            InitializeComponent();
            if (reset == false)
            {
                _prijs = prijs;
            }
            else
            {
                //window resetten
                _5cent = 0;
                _10cent = 0;
                _20cent = 0;
                _50cent = 0;
                _1euro = 0;
                _2euro = 0;
                _5euro = 0;
                _10euro = 0;
                _20euro = 0;
                _50euro = 0;
                _100euro = 0;
                _200euro = 0;
                _totaal = 0;
                _prijs = 0;
                DispatcherTimer closeWindow = new DispatcherTimer();
                closeWindow.Interval = TimeSpan.FromMilliseconds(1);
                closeWindow.Tick += close_Tick;
                closeWindow.Start();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt5centP_Click(object sender, RoutedEventArgs e)
        {
            _5cent++;
            updatePrice();
        }

        private void bt5centM_Click(object sender, RoutedEventArgs e)
        {
            if (_5cent > 0)
            {
                _5cent--;
                updatePrice();
            }
        }

        private void bt10centP_Click(object sender, RoutedEventArgs e)
        {
            _10cent++;
            updatePrice();
        }

        private void bt10centM_Click(object sender, RoutedEventArgs e)
        {
            if (_10cent > 0)
            {
                _10cent--;
                updatePrice();
            }
        }

        private void bt20centP_Click(object sender, RoutedEventArgs e)
        {
            _20cent++;
            updatePrice();
        }

        private void bt20centM_Click(object sender, RoutedEventArgs e)
        {
            if (_20cent > 0)
            {
                _20cent--;
                updatePrice();
            }
        }

        private void bt50centP_Click(object sender, RoutedEventArgs e)
        {
            _50cent++;
            updatePrice();
        }

        private void bt50centM_Click(object sender, RoutedEventArgs e)
        {
            if (_50cent > 0)
            {
                _50cent--;
                updatePrice();
            }
        }

        private void bt1euroP_Click(object sender, RoutedEventArgs e)
        {
            _1euro++;
            updatePrice();
        }

        private void bt1euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_1euro > 0)
            {
                _1euro--;
                updatePrice();
            }
        }

        private void bt2euroP_Click(object sender, RoutedEventArgs e)
        {
            _2euro++;
            updatePrice();
        }

        private void bt2euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_2euro > 0)
            {
                _2euro--;
                updatePrice();
            }
        }

        private void bt5euroP_Click(object sender, RoutedEventArgs e)
        {
            _5euro++;
            updatePrice();
        }

        private void bt5euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_5euro > 0)
            {
                _5euro--;
                updatePrice();
            }
        }

        private void bt10euroP_Click(object sender, RoutedEventArgs e)
        {
            _10euro++;
            updatePrice();
        }

        private void bt10euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_10euro > 0)
            {
                _10euro--;
                updatePrice();
            }
        }

        private void bt20euroP_Click(object sender, RoutedEventArgs e)
        {
            _20euro++;
            updatePrice();
        }

        private void bt20euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_20euro > 0)
            {
                _20euro--;
                updatePrice();
            }
        }

        private void bt50euroP_Click(object sender, RoutedEventArgs e)
        {
            _50euro++;
            updatePrice();
        }

        private void bt50euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_50euro > 0)
            {
                _50euro--;
                updatePrice();
            }
        }

        private void bt100euroP_Click(object sender, RoutedEventArgs e)
        {
            _100euro++;
            updatePrice();
        }

        private void bt100euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_100euro > 0)
            {
                _100euro--;
                updatePrice();
            }
        }

        private void bt200euroP_Click(object sender, RoutedEventArgs e)
        {
            _200euro++;
            updatePrice();
        }

        private void bt200euroM_Click(object sender, RoutedEventArgs e)
        {
            if (_200euro > 0)
            {
                _200euro--;
                updatePrice();
            }
        }

        private void updatePrice()
        {
            //textblock van totaal geselecteerd updaten
            _totaal = (_5cent / 20) + (_10cent / 10) + (_20cent / 5) + (_50cent / 2) + _1euro + (_2euro * 2) + (_5euro * 5) + (_10euro * 10) + (_20euro * 20) + (_50euro * 50) + (_100euro * 100) + (_200euro * 200);
            btTotaal.Text = "€ " + _totaal.ToString();
        }

        private void btDoorgaan_Click(object sender, RoutedEventArgs e)
        {
            if (_totaal > _prijs)
            {
                //wisselgeld window openen als er meer betaald is dan wat de prijs is
                Window2 thirdWindow = new Window2(_totaal, _prijs, reset);
                this.Close();
                thirdWindow.Show();
            }
            else if(_totaal < _prijs)
            {
                //popup als er te weinig betaald is
                MessageBox.Show("Er is nog niet genoeg betaald");
            }
            else
            {
                //mainwindow openen als er precies de prijs betaald is
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }
    }
}