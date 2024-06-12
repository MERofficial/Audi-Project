using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiProject
{
    internal class Records
    {
        public String VIN { get; set; }
        public String Model { get; set; }
        public String Colour { get; set; }
        public String Engine { get; set; }
        public String Year { get; set; }
        public String Available { get; set; }
        public String Rent { get; set; }
        public Records(String vn, String ml, String cl, String en, String yr, String av, String rt)
        {
            VIN = vn;
            Model = ml;
            Colour = cl;
            Engine = en;
            Year = yr;
            Available = av;
            Rent = rt;
        }
    }
}
