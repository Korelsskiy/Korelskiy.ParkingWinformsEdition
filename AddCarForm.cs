using Korelskiy.ParkingWinformsEdition.Models;
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
    public partial class AddCarForm : Form
    {
        ICarRequester callingForm;

        public AddCarForm(ICarRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            callingForm.CarBinding += CallingForm_CarBinding;

        }

        private void CallingForm_CarBinding(object sender, EventArgs e)
        {
            UpdateBindings();
        }

        private void UpdateBindings()
        {
            selectCarComboBox.Items.Clear();

            for (int i = 0; i < ParkingStatistic.CarsInQueue.Count; i++)
            {
                selectCarComboBox.Items.Add(ParkingStatistic.CarsInQueue[i]);
            }

            if (selectCarComboBox.Items.Count > 0)
            {
                selectCarComboBox.SelectedItem = selectCarComboBox.Items[0];
            }
            
            selectCarComboBox.DisplayMember = "Name";
        }
        private void GetCar()
        {
            Car car = selectCarComboBox.SelectedItem as Car;
            car.Number = carNumberTextBox.Text;
            callingForm.CarSelected(car);
            
            
        }
        private void carAddingButton_Click(object sender, EventArgs e)
        {
            GetCar();
            Hide();
        }
    }
}
