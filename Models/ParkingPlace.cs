using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korelskiy.ParkingWinformsEdition.Models
{
    public class ParkingPlace
    {
        public int Id { get; set; }
        public Car CarInPlace { get; set; } = null;

        public Panel PlacePanel { get; set; }
        public ParkingPlace() { }
        public ParkingPlace(int id)
        {
            Id = id;
        }
    }
}
