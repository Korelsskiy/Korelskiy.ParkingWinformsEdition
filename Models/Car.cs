using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.ParkingWinformsEdition.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Bitmap Image { get; set; }
        public static List<Car> AllCars { get; set; } = new List<Car>()
        {
            new Car("ВАЗ 2107", Properties.Resources.lada2107),
            new Car("ВАЗ 2106", Properties.Resources.lada2106),
            new Car("НИВА 4х4", Properties.Resources.niva4_4),
            new Car("Kia Rio", Properties.Resources.kiaRio),
            new Car("ВАЗ 2110", Properties.Resources.lada2110)
        };

        public Car() { }
        public Car(string name, Bitmap img)
        {
            Name = name;
            Image = img;
        }
    }
}
