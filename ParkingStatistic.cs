using Korelskiy.ParkingWinformsEdition.Models;
using System.Collections.Generic;

namespace Korelskiy.ParkingWinformsEdition
{
    public static class ParkingStatistic
    {
        private const decimal goal = 100_000m;
        public static decimal CompanyMoney { get; set; } = 0m;
        public static int CarOnParking { get; set; } = 0;
        public static decimal OperatorMoney { get; set; } = 0m;
        public static List<Car> CarArrived { get; set; } = new List<Car>();
        public static int DaysGone { get; set; } = 0;
        public static int RandomEvents { get; set; } = 0;
        public static int WorkingShifts { get; set; } = 0;
        public static List<Car> CarsInQueue { get; set; } = new List<Car>();
        public static void CheckForWin(decimal companyMoney)
        {
            if (companyMoney >= goal)
            {
                // Победа!
            }
        }

    }
}
