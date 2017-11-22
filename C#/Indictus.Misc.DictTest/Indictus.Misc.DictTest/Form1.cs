using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indictus.Misc.DictTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            this._initDict(ref dict);

            System.Diagnostics.Debug.WriteLine(this._getVal(ref dict, 2));            
        }

        private string _getVal(ref Dictionary<int, string> dict, int number)
        {
            string s = "";

            if (dict.TryGetValue(number, out s))
                return s;
            else
            {
                s = _buildVal(ref dict, number);
                return s;
            }
        }

        private string _buildVal(ref Dictionary<int, string> dict, int number)
        {
            int val = 0;
            string s = "";
            int len = s.ToString().Length;

            if (len == 2)
            {
                string s1 = s.Substring(0, 1);
                string s2= s.Substring(1, 1);

                switch (s1)
                {
                    case "2": { val = 20; break; }
                    case "3": { val = 30; break; }
                    case "4": { val = 40; break; }
                    case "5": { val = 50; break; }
                    case "6": { val = 60; break; }
                    case "7": { val = 70; break; }
                    case "8": { val = 80; break; }
                    case "9": { val = 90; break; }
                    default: { break; }
                }

                val += _getVal()
            }
            return s;
        }


        private void _initDict(ref Dictionary<int, string> dict)
        {
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            dict.Add(5, "five");
            dict.Add(6, "six");
            dict.Add(7, "seven");
            dict.Add(8, "eight");
            dict.Add(9, "nine");
            dict.Add(10, "ten");
            dict.Add(11, "eleven");
            dict.Add(12, "twelve");
            dict.Add(13, "thirteen");
            dict.Add(14, "fourteen");
            dict.Add(15, "fifteen");
            dict.Add(16, "sixteen");
            dict.Add(17, "seventeen");
            dict.Add(18, "eighteen");
            dict.Add(19, "nineteen");
            dict.Add(20, "twenty");
            dict.Add(30, "thirty");
            dict.Add(40, "fourty");
            dict.Add(50, "fifty");
            dict.Add(60, "sixty");
            dict.Add(70, "seventy");
            dict.Add(80, "eight");
            dict.Add(90, "ninty");
            dict.Add(100, "hundred");
            dict.Add(1000, "thousand");            
        }

    }
}
