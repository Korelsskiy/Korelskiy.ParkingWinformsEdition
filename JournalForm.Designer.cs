namespace Korelskiy.ParkingWinformsEdition
{
    partial class JournalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.companyMoneyLabel = new System.Windows.Forms.Label();
            this.carsOnParkingLabel = new System.Windows.Forms.Label();
            this.operatorMoneyLabel = new System.Windows.Forms.Label();
            this.carsArrivedLabel = new System.Windows.Forms.Label();
            this.daysGoneLabel = new System.Windows.Forms.Label();
            this.randomEventsLabel = new System.Windows.Forms.Label();
            this.workShiftsGoneLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.workShiftsGoneLabel);
            this.panel1.Controls.Add(this.randomEventsLabel);
            this.panel1.Controls.Add(this.daysGoneLabel);
            this.panel1.Controls.Add(this.carsArrivedLabel);
            this.panel1.Controls.Add(this.operatorMoneyLabel);
            this.panel1.Controls.Add(this.carsOnParkingLabel);
            this.panel1.Location = new System.Drawing.Point(43, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 356);
            this.panel1.TabIndex = 0;
            // 
            // companyMoneyLabel
            // 
            this.companyMoneyLabel.AutoSize = true;
            this.companyMoneyLabel.ForeColor = System.Drawing.Color.Red;
            this.companyMoneyLabel.Location = new System.Drawing.Point(38, 18);
            this.companyMoneyLabel.Name = "companyMoneyLabel";
            this.companyMoneyLabel.Size = new System.Drawing.Size(394, 29);
            this.companyMoneyLabel.TabIndex = 1;
            this.companyMoneyLabel.Text = "Компании осталось заработать: ";
            // 
            // carsOnParkingLabel
            // 
            this.carsOnParkingLabel.AutoSize = true;
            this.carsOnParkingLabel.Location = new System.Drawing.Point(17, 18);
            this.carsOnParkingLabel.Name = "carsOnParkingLabel";
            this.carsOnParkingLabel.Size = new System.Drawing.Size(235, 29);
            this.carsOnParkingLabel.TabIndex = 0;
            this.carsOnParkingLabel.Text = "Машин на стоянке:";
            // 
            // operatorMoneyLabel
            // 
            this.operatorMoneyLabel.AutoSize = true;
            this.operatorMoneyLabel.Location = new System.Drawing.Point(16, 75);
            this.operatorMoneyLabel.Name = "operatorMoneyLabel";
            this.operatorMoneyLabel.Size = new System.Drawing.Size(267, 29);
            this.operatorMoneyLabel.TabIndex = 1;
            this.operatorMoneyLabel.Text = "Оператор заработал: ";
            // 
            // carsArrivedLabel
            // 
            this.carsArrivedLabel.AutoSize = true;
            this.carsArrivedLabel.Location = new System.Drawing.Point(17, 132);
            this.carsArrivedLabel.Name = "carsArrivedLabel";
            this.carsArrivedLabel.Size = new System.Drawing.Size(207, 29);
            this.carsArrivedLabel.TabIndex = 2;
            this.carsArrivedLabel.Text = "Машин принято:";
            // 
            // daysGoneLabel
            // 
            this.daysGoneLabel.AutoSize = true;
            this.daysGoneLabel.Location = new System.Drawing.Point(17, 188);
            this.daysGoneLabel.Name = "daysGoneLabel";
            this.daysGoneLabel.Size = new System.Drawing.Size(177, 29);
            this.daysGoneLabel.TabIndex = 3;
            this.daysGoneLabel.Text = "Дней прошло:";
            // 
            // randomEventsLabel
            // 
            this.randomEventsLabel.AutoSize = true;
            this.randomEventsLabel.Location = new System.Drawing.Point(16, 246);
            this.randomEventsLabel.Name = "randomEventsLabel";
            this.randomEventsLabel.Size = new System.Drawing.Size(373, 29);
            this.randomEventsLabel.TabIndex = 4;
            this.randomEventsLabel.Text = "Случайных событий пройдено:";
            // 
            // workShiftsGoneLabel
            // 
            this.workShiftsGoneLabel.AutoSize = true;
            this.workShiftsGoneLabel.Location = new System.Drawing.Point(17, 305);
            this.workShiftsGoneLabel.Name = "workShiftsGoneLabel";
            this.workShiftsGoneLabel.Size = new System.Drawing.Size(216, 29);
            this.workShiftsGoneLabel.TabIndex = 5;
            this.workShiftsGoneLabel.Text = "Смен проведено:";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.okButton.Location = new System.Drawing.Point(187, 429);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(164, 43);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ясно";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(570, 494);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.companyMoneyLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "JournalForm";
            this.Text = "Журнал";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label workShiftsGoneLabel;
        private System.Windows.Forms.Label randomEventsLabel;
        private System.Windows.Forms.Label daysGoneLabel;
        private System.Windows.Forms.Label carsArrivedLabel;
        private System.Windows.Forms.Label operatorMoneyLabel;
        private System.Windows.Forms.Label carsOnParkingLabel;
        private System.Windows.Forms.Label companyMoneyLabel;
        private System.Windows.Forms.Button okButton;
    }
}