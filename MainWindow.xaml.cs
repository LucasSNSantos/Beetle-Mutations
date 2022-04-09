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
        private List<Rectangle> MyBeetles;
        public bool IsEvolving;
        public MainWindow()
        {
            InitializeComponent();
            Darwin = new NaturalSelection();
            MyBeetles = new List<Rectangle>();
            IsEvolving = false;
        }

        private void Generate_Population(object sender, RoutedEventArgs e)
        {
            if (IsEvolving) return;
            int individuals = 20;
/*            var value = IndividualsNumber.SelectedValue;
            if (value != null)
            {
                var individualNumber = value.ToString();
                individuals = int.Parse(individualNumber.Split()[1]);
            }*/
            Setup(individuals);
        }

        private void Clear_Population(object sender, RoutedEventArgs e)
        {

        }


        private void Setup(int population)
        {
            Random R = new Random();
            int height = 50;//R.Next(0, 800);
            int width = 100;// R.Next(0,10);
            Darwin.StartPopulation(population);
            foreach (var item in Darwin.population.myPopulation)
            {
                var r = (byte) item.Red;
                var g = (byte) item.Green;
                var b = (byte) item.Blue;
                var rect = new Rectangle()
                {
                    Fill = new SolidColorBrush(Color.FromArgb(255, r, g, b)),
                    Height = 20,
                    Width = 20,
                    StrokeThickness = 2,
                };
                MyBeetles.Add(rect);
                Canvas.SetLeft(rect, width);
                Canvas.SetTop(rect, height);
                myCanvas.Children.Add(rect);
                width += 30;
            }
            IsEvolving = true;
        }


    }
}
