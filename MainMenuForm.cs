﻿using System;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGameForm form = new NewGameForm();
            this.Hide();
            form.Show();
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            LoadGameForm form = new LoadGameForm();
            this.Hide();
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
