using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.ParkingWinformsEdition
{
    public class Operator
    {
        public string Name { get; set; }
        public bool IsAllowed { get; set; } = false;

        public Bitmap Image { get; set; }
        public static List<Operator> AllOperators { get; set; } = new List<Operator>()
        {
            new Operator("Толстяк", true, Properties.Resources.tolstyi),
            new Operator("Слепой", true, Properties.Resources.slepoy),
            new Operator("Студент", true, Properties.Resources.student),
        };
        public Operator() { }
        public Operator(string name, Bitmap img)
        {
            Name = name;
            Image = img;
        }
        public Operator(string name, bool isAllowed, Bitmap img)
        {
            Name = name;
            IsAllowed = isAllowed;
            Image = img;
        }
    }
}
