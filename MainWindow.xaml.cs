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

namespace BeetleGenetics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NaturalSelection Darwin;
        public MainWindow()
        {
            InitializeComponent();
            Darwin = new NaturalSelection();
        }

        private void Generate_Population(object sender, RoutedEventArgs e)
        {
            int individuals = 10;
            var value = IndividualsNumber.SelectedValue;
            if(value != null)
            {
                var individualNumber = value.ToString();
                individuals = int.Parse(individualNumber.Split()[1]);
            }
            Darwin.StartPopulation(individuals);
        }
    }
}
