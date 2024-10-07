using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenRace_Demo.Models
{
    public class oGame
    {

        private List<oSom> _sums = new List<oSom>();

        public void fillSums()
        {
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
                _sums.Add(som);
            }

        }

        public List<Models.oSom> Sums { 
            get { return _sums; } 
        }



    }
}
