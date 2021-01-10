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
    public partial class NewGameForm : Form
    {
        public List<Operator> allowedOperators = new List<Operator>();
        public NewGameForm()
        {
            InitializeComponent();


            allowedOperators.AddRange(Operator.AllOperators);
            selectOperatorComboBox.DataSource = allowedOperators;
            selectOperatorComboBox.DisplayMember = "Name";
            selectOperatorComboBox.SelectedIndex = 1;

            operatorPictureBox.Image = allowedOperators[1].Image;

            difficultLabel.Text = "средний";


        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm();
            this.Hide();
            form.Show();
        }

        private void selectOperatorComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            if (senderComboBox.SelectedIndex == 0)
            {
                operatorPictureBox.Image = Properties.Resources.tolstyi;

                difficultLabel.Text = "тяжелая";
            }
            if (senderComboBox.SelectedIndex == 1)
            {
                operatorPictureBox.Image = Properties.Resources.slepoy;

                difficultLabel.Text = "средняя";
            }
            if (senderComboBox.SelectedIndex == 2)
            {
                operatorPictureBox.Image = Properties.Resources.student;

                difficultLabel.Text = "легкая";
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            int numOfPlaces = Int32.Parse(activePlacesTextBlock.Text);
            Operator selectedOperator = (Operator)selectOperatorComboBox.SelectedItem;

            GameForm form = new GameForm(numOfPlaces, selectedOperator);
            this.Hide();
            form.Show();
        }
    }
}
