using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korelskiy.ParkingWinformsEdition
{
    public partial class JournalForm : Form
    {
        IJournalRequester CallingForm;
        public JournalForm(IJournalRequester callingForm)
        {
            InitializeComponent();

            CallingForm = callingForm;

            companyMoneyLabel.Text += $"     {ParkingStatistic.CompanyMoney}";
            carsOnParkingLabel.Text += $"     {ParkingStatistic.CarOnParking}";
            operatorMoneyLabel.Text += $"     {ParkingStatistic.OperatorMoney}";
            carsArrivedLabel.Text += $"     {ParkingStatistic.CarArrived.Count}";
            daysGoneLabel.Text += $"     {ParkingStatistic.DaysGone}";
            randomEventsLabel.Text += $"     {ParkingStatistic.RandomEvents}";
            workShiftsGoneLabel.Text += $"     {ParkingStatistic.WorkingShifts}";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CallingForm.JournalWatched();
            Hide();
        }
    }
}
