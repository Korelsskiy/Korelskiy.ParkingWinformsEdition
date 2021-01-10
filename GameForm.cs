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
    public partial class GameForm : Form, ICarRequester, IJournalRequester
    {
        public AddCarForm form;
        public event EventHandler CarBinding;
        public List<Panel> activePanels = new List<Panel>();
        public Panel bluePanel = new Panel();
        public List<ParkingPlace> places;

        public GameForm() { }
        public GameForm(int numOfPlaces, Operator selectedOperator)
        {
            InitializeComponent();

            form = new AddCarForm(this);

            AddActivePanels(numOfPlaces);

            places = GetParkingPlaces(numOfPlaces, activePanels);

            selectedOperatorPictureBox.Image = selectedOperator.Image;
            operatorNamelabel.Text = selectedOperator.Name;

            UpdateBindings();

        }

        private List<ParkingPlace> GetParkingPlaces(int numOfPlaces, List<Panel> panels)
        {
            List<ParkingPlace> parkingPlaces = new List<ParkingPlace>(numOfPlaces);

            for (int i = 0; i < numOfPlaces; i++)
            {
                parkingPlaces.Add(new ParkingPlace(i+1));
            }

            foreach (ParkingPlace place in parkingPlaces)
            {
                place.PlacePanel = panels[place.Id-1];
                place.PlacePanel.BackColor = Color.MediumSeaGreen;
            }

            return parkingPlaces;
        }
        private void AddActivePanels(int numOfPlaces)
        {
            List<Panel> panels = new List<Panel>();
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);
            panels.Add(panel5);
            panels.Add(panel6);
            panels.Add(panel7);
            panels.Add(panel8);
            panels.Add(panel9);
            panels.Add(panel10);
            panels.Add(panel11);

            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }

            for (int i = 0; i < numOfPlaces; i++)
            {
               activePanels.Add(panels[i]);
                panels[i].Visible = true;
                panels[i].Tag = i;
            }
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm();
            this.Hide();
            form.Show();
        }

        private void ChangePanelColor(Panel panel)
        {
            if (panel.BackColor == Color.LightSkyBlue)
            {
                panel.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                if (bluePanel != null)
                {
                    bluePanel.BackColor = Color.MediumSeaGreen;
                }
                panel.BackColor = Color.LightSkyBlue;
                bluePanel = panel;
            }
        }
        private void selectButtonForPanel1_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel2);
        }

        private void selectButtonForPanel2_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel3);
        }

        private void selectButtonForPanel3_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel4);
        }

        private void selectButtonForPanel4_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel5);
        }

        private void selectButtonForPanel5_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel6);
        }

        private void selectButtonForPanel6_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel11);
        }

        private void selectButtonForPanel7_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel10);
        }

        private void selectButtonForPanel8_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel9);
        }

        private void selectButtonForPanel9_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel8);
        }

        private void selectButtonForPanel10_Click(object sender, EventArgs e)
        {
            ChangePanelColor(panel7);
        }

        private void addNewCarButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            form.Show();

        }

        public void AddNewCar(Car car)
        {
            ParkingPlace place = places.Where(x => x.PlacePanel.Tag == bluePanel.Tag).FirstOrDefault();
            place.CarInPlace = car;
            UpdateBindings();
            UpdatePanelInformation(place);
        }

        public void CarSelected(Car car)
        {
            ParkingStatistic.CarsInQueue.Remove(car);
            CarBinding.Invoke(this, new EventArgs());
            AddNewCar(car);
            this.Enabled = true;
            
        }

        public void JournalWatched()
        {
            this.Enabled = true;
        }
        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            ParkingPlace place = places.Where(x => x.PlacePanel.Tag == bluePanel.Tag).FirstOrDefault();
            place.CarInPlace = null;
            UpdatePanelInformation(place);
            
        }

        private void UpdatePanelInformation(ParkingPlace place)
        {
            List<Label> labels = new List<Label>();
            if (place.CarInPlace != null)
            {
                foreach (object obj in place.PlacePanel.Controls)
                {
                    if (obj is PictureBox box)
                    {
                        
                        box.Image = place.CarInPlace.Image;
                    }
                    if (obj is Label label)
                    {
                        labels.Add(label);

                    }
                }

                labels[1].Text = place.CarInPlace.Name;
                labels[0].Text = "№ " + place.CarInPlace.Number;
            }
            else
            {
                foreach (object obj in place.PlacePanel.Controls)
                {
                    if (obj is PictureBox box)
                    {
                        box.Image = null;
                    }
                    if (obj is Label label)
                    {
                        label.Text = "нет данных";
                    }
                }
            }

            foreach (Label label in labels)
            {
                label.Visible = true;
            }

            bluePanel.BackColor = Color.MediumSeaGreen;
            bluePanel = null;
        }

        private void watchJournakButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            JournalForm form = new JournalForm(this);
            form.Show();
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ParkingStatistic.DaysGone++;
            ParkingStatistic.CarsInQueue.Add(Car.AllCars[rnd.Next(0, Car.AllCars.Count)]);
            CarBinding.Invoke(this, e);
            UpdateBindings();
        }

        private void UpdateBindings()
        {
            daysGoneLabel.Text = $"{ParkingStatistic.DaysGone}";
            carsInQueueLabel.Text = $"{ParkingStatistic.CarsInQueue.Count}";
            carsInQueueLabel.Visible = true;
            daysGoneLabel.Visible = true;
        }
    }
}
