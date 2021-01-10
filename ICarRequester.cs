using Korelskiy.ParkingWinformsEdition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.ParkingWinformsEdition
{
    public interface ICarRequester
    {
        event EventHandler CarBinding;
        void CarSelected(Car car);
    }
}
