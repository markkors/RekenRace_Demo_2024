using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenRace_Demo.Models
{
    public class oSom
    {
        public float Part1 { get; set; }
        public float Part2 { get; set; }  
        public string Operator { get; set; }


        public string Sum
        {
            get
            {
                return $"{Part1.ToString()}  {Operator}  {Part2.ToString()}";
            }
        }   

        public string Solution { 
            get {
                double result = 0;
                switch (Operator)
                {
                    case "*":
                        result = Part1 * Part2;
                        break;
                    case "-":
                        result = Part1 - Part2;
                        break;
                    case "+":
                        result = Part1 + Part2;
                        break;
                    case "/":
                        result = Part1 / Part2;
                        break;

                }
                // return result, round to 2 decimals
                return Math.Round(result, 2).ToString();

            }

        }


    }
}
