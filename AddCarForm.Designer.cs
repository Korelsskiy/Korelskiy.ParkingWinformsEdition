namespace Korelskiy.ParkingWinformsEdition
{
    partial class AddCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            this.selectCarComboBox = new System.Windows.Forms.ComboBox();
            this.carNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carAddingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectCarComboBox
            // 
            this.selectCarComboBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.selectCarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCarComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectCarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectCarComboBox.FormattingEnabled = true;
            this.selectCarComboBox.Location = new System.Drawing.Point(49, 68);
            this.selectCarComboBox.Name = "selectCarComboBox";
            this.selectCarComboBox.Size = new System.Drawing.Size(188, 37);
            this.selectCarComboBox.TabIndex = 0;
            // 
            // carNumberTextBox
            // 
            this.carNumberTextBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.carNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carNumberTextBox.Location = new System.Drawing.Point(49, 159);
            this.carNumberTextBox.Name = "carNumberTextBox";
            this.carNumberTextBox.Size = new System.Drawing.Size(188, 34);
            this.carNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Машина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(49, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Гос.номер";
            // 
            // carAddingButton
            // 
            this.carAddingButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.carAddingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carAddingButton.Location = new System.Drawing.Point(49, 214);
            this.carAddingButton.Name = "carAddingButton";
            this.carAddingButton.Size = new System.Drawing.Size(188, 41);
            this.carAddingButton.TabIndex = 4;
            this.carAddingButton.Text = "Готово";
            this.carAddingButton.UseVisualStyleBackColor = false;
            this.carAddingButton.Click += new System.EventHandler(this.carAddingButton_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(310, 298);
            this.Controls.Add(this.carAddingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carNumberTextBox);
            this.Controls.Add(this.selectCarComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCarForm";
            this.Text = "Новая машина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCarComboBox;
        private System.Windows.Forms.TextBox carNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button carAddingButton;
    }
}