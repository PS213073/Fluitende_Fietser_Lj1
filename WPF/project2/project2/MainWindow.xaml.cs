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
using System.Xml;

namespace project2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedBike;
        string selectedInsurance;
        string selectedService;
        double priceBike;
        double priceInsurance;
        double priceService;
        double prijs;
        bool reset = false;
        DispatcherTimer timerClose = new DispatcherTimer();
        List<double> prijzen = new List<double>();

        public MainWindow()
        {
            InitializeComponent();
            timerClose.Interval = TimeSpan.FromSeconds(60);
            timerClose.Tick += TimerClose_Tick;
            timerClose.Start();
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFietsen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //prijs naast fietscombobox aanpassen
            if (reset == false)
            {
                selectedBike = ((ComboBoxItem)cbFietsen.SelectedItem).Content.ToString();
                if (selectedBike == "Aanhangfiets")
                {
                    priceBike = 20;
                    tbPrijsFiets.Text = "€ 20,00";
                }
                else if (selectedBike == "Bakfiets")
                {
                    priceBike = 35;
                    tbPrijsFiets.Text = "€ 35,00";
                }
                else if (selectedBike == "Driewielfiets" || selectedBike == "Elektrische fiets")
                {
                    priceBike = 30;
                    tbPrijsFiets.Text = "€ 30,00";
                }
                else if (selectedBike == "Kinderfiets" || selectedBike == "Racefiets" || selectedBike == "Speed pedelec" || selectedBike == "Zitfiets")
                {
                    priceBike = 15;
                    tbPrijsFiets.Text = "€ 15,00";
                }
                else if (selectedBike == "Ligfiets")
                {
                    priceBike = 45;
                    tbPrijsFiets.Text = "€ 45,00";
                }
                else if (selectedBike == "Oma fiets" || selectedBike == "Stadsfiets")
                {
                    priceBike = 12.50;
                    tbPrijsFiets.Text = "€ 12,50";
                }
                else if (selectedBike == "Vouwfiets")
                {
                    priceBike = 10;
                    tbPrijsFiets.Text = "€ 10,00";
                }
            }
        }

        private void btFietsen_Click(object sender, RoutedEventArgs e)
        {
            //listbox + stackpanel + textblock aanmaken en toevoegen voor fietsen combobox
            ListBoxItem item = new ListBoxItem();
            StackPanel stack = new StackPanel();
            TextBlock text = new TextBlock();
            text.Text = selectedBike + " voor €" + priceBike;
            stack.Children.Add(text);
            item.Content = stack;
            lbBestelling.Items.Add(item);
            prijs = prijs + priceBike;
            tbkPrijs.Text = "€ " + prijs;
            prijzen.Add(priceBike);
        }

        private void cbVerzekering_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //prijs naast verzekeringen combobox aanpassen
            if (reset == false)
            {
                selectedInsurance = ((ComboBoxItem)cbVerzekering.SelectedItem).Content.ToString();
                if (selectedInsurance == "Beschadigingen" || selectedInsurance == "Rechtsbijstand")
                {
                    priceInsurance = 5;
                    tbPrijsVerzekering.Text = "€ 5,00";
                }
                else if (selectedInsurance == "Diefstal")
                {
                    priceInsurance = 10;
                    tbPrijsVerzekering.Text = "€ 10,00";
                }
                else if (selectedInsurance == "Ongevallen")
                {
                    priceInsurance = 2.50;
                    tbPrijsVerzekering.Text = "€ 2,50";
                }
            }
        }

        private void btVerzekering_Click(object sender, RoutedEventArgs e)
        {
            //listbox + stackpanel + textblock aanmaken en toevoegen voor verzekering combobox
            ListBoxItem item = new ListBoxItem();
            StackPanel stack = new StackPanel();
            TextBlock text = new TextBlock();
            text.Text = selectedInsurance + " voor €" + priceInsurance;
            stack.Children.Add(text);
            item.Content = stack;
            lbBestelling.Items.Add(item);
            prijs = prijs + priceInsurance;
            tbkPrijs.Text = "€ " + prijs;
            prijzen.Add(priceInsurance);
        }

        private void cbService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //prijs naast service combobox aanpassen
            if (reset == false)
            {
                selectedService = ((ComboBoxItem)cbService.SelectedItem).Content.ToString();
                if (selectedService == "Ophaalservice")
                {
                    priceService = 15;
                    tbPrijsService.Text = "€ 15,00";
                }
                else if (selectedService == "Regenpak")
                {
                    priceService = 10;
                    tbPrijsService.Text = "€ 10,00";
                }
                else if (selectedService == "Lunchpakket basis")
                {
                    priceService = 12.50;
                    tbPrijsService.Text = "€ 12,50";
                }
                else if (selectedService == "Lunchpakket uitgebreid")
                {
                    priceService = 20;
                    tbPrijsService.Text = "€ 20,00";
                }
            }
        }

        private void btService_Click(object sender, RoutedEventArgs e)
        {
            //listbox + stackpanel + textblock aanmaken en toevoegen voor service combobox
            ListBoxItem item = new ListBoxItem();
            StackPanel stack = new StackPanel();
            TextBlock text1 = new TextBlock();
            stack.Orientation = Orientation.Horizontal;
            text1.Text = selectedService + " voor €" + priceService;
            stack.Children.Add(text1);
            item.Content = stack;
            lbBestelling.Items.Add(item);
            prijs = prijs + priceService;
            tbkPrijs.Text = "€ " + prijs;
            prijzen.Add(priceService);
        }

        private void lbBestelling_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //bestelregel verwijderen
            if (lbBestelling.SelectedIndex != 0)
            {
                int index = lbBestelling.SelectedIndex - 1;
                prijs = prijs - prijzen[index];
                MessageBox.Show("positie:" + index.ToString() + "prijs:" + prijzen[index].ToString());
                prijzen.RemoveAt(index);
                tbkPrijs.Text = "€ " + prijs;
                lbBestelling.Items.Remove(lbBestelling.SelectedItem);
            }
        }

        private void tbPrijs_TextChanged(object sender, TextChangedEventArgs e)
        {
            //handmatig ingevoerde prijs in de textblock zetten
            prijs = 0;
            string _prijs = tbPrijs.Text.ToString();
            double.TryParse(_prijs, out prijs);
            tbkPrijs.Text = "€ " + _prijs;
        }

        private void btBetalen_Click(object sender, RoutedEventArgs e)
        {
            //alles resetten
            selectedBike = null;
            selectedInsurance = null;
            selectedService = null;
            priceBike = 0;
            priceInsurance = 0;
            priceService = 0;
            prijs = 0;
            reset = true;
            double _totaal = 0;
            Window1 secondWindow = new Window1(prijs, reset);
            secondWindow.Show();
            Window2 thirdWindow = new Window2(_totaal, prijs, reset);
            thirdWindow.Show();
            TextBlock printTextBlock = new TextBlock();
            printTextBlock.Text = "Bestelling";
            printTextBlock.FontWeight = FontWeights.Bold;
            lbBestelling.Items.Clear();
            lbBestelling.Items.Add(printTextBlock);
            tbPrijsFiets.Text = "";
            tbPrijsService.Text = "";
            tbPrijsVerzekering.Text = "";
            cbFietsen.SelectedIndex = -1;
            cbService.SelectedIndex = -1;
            cbVerzekering.SelectedIndex = -1;
            tbkPrijs.Text = "€ 0,00";
            reset = false;
        }

        private void btSelecteerGeld_Click(object sender, RoutedEventArgs e)
        {
            //window voor geld selecteren openen
            Window1 secondWindow = new Window1(prijs, reset);
            this.Hide();
            secondWindow.Show();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            timerClose.Stop();
            timerClose.Interval = TimeSpan.FromSeconds(60);
            timerClose.Start();
        }
    }
}