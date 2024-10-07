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
using RekenRace_Demo.Models;

namespace RekenRace_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<oSom> sommen = new List<oSom>();

        public MainWindow()
        {
            InitializeComponent();

            // Create a new instance of the oSom class
            
            Random rnd = new Random();

            // create 10 sums
            for (int i = 0; i < 10; i++)
            {
                oSom som = new oSom();
                // Generate a random number between 1 and 10

                som.Part1 = rnd.Next(1, 10);
                som.Part2 = rnd.Next(1, 10);

                // Generate a random operator
                string[] operators = { "+", "-", "*", "/" };
                som.Operator = operators[rnd.Next(0, 4)];

                // add the sum to the collection
                sommen.Add(som);
            }
            

        }
    }
}
