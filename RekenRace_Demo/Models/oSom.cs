using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenRace_Demo.Models
{
    internal class oSom
    {
        public int Part1 { get; set; }
        public int Part2 { get; set; }  
        public string Operator { get; set; }

        public string Solution { 
            get {
                float result = 0;
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
                return result.ToString();

            }

        }


    }
}
