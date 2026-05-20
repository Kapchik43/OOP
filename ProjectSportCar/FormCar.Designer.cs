namespace ProjectCar
{
    partial class FormCar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxSportCar = new PictureBox();
            buttonCreateCar = new Button();
            buttonLeft = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            buttonRight = new Button();
            buttonCheckBorders = new Button();
            buttonCreateDumpTruck = new Button();
            comboBoxPointOfDestination = new ComboBox();
            buttonMovementStep = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSportCar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxSportCar
            // 
            pictureBoxSportCar.Dock = DockStyle.Fill;
            pictureBoxSportCar.Location = new Point(0, 0);
            pictureBoxSportCar.Name = "pictureBoxSportCar";
            pictureBoxSportCar.Size = new Size(923, 597);
            pictureBoxSportCar.TabIndex = 0;
            pictureBoxSportCar.TabStop = false;
            // 
            // buttonCreateCar
            // 
            buttonCreateCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateCar.Location = new Point(12, 562);
            buttonCreateCar.Name = "buttonCreateCar";
            buttonCreateCar.Size = new Size(110, 23);
            buttonCreateCar.TabIndex = 1;
            buttonCreateCar.Text = "Создать грузовик";
            buttonCreateCar.UseVisualStyleBackColor = true;
            buttonCreateCar.Click += ButtonCreateCar_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = Properties.Resources.arrowLeft;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Location = new Point(787, 550);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(35, 35);
            buttonLeft.TabIndex = 2;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMove_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.BackgroundImage = Properties.Resources.arrowUp;
            buttonUp.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUp.Location = new Point(828, 509);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 3;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = Properties.Resources.arrowDown;
            buttonDown.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDown.Location = new Point(828, 550);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 35);
            buttonDown.TabIndex = 4;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.BackgroundImage = Properties.Resources.arrowRight;
            buttonRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRight.Location = new Point(869, 550);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 35);
            buttonRight.TabIndex = 5;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMove_Click;
            // 
            // buttonCheckBorders
            // 
            buttonCheckBorders.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCheckBorders.Location = new Point(12, 12);
            buttonCheckBorders.Name = "buttonCheckBorders";
            buttonCheckBorders.Size = new Size(129, 23);
            buttonCheckBorders.TabIndex = 6;
            buttonCheckBorders.Text = "Проверка границ";
            buttonCheckBorders.UseVisualStyleBackColor = true;
            buttonCheckBorders.Click += ButtonCheckBorders_Click;
            // 
            // buttonCreateDumpTruck
            // 
            buttonCreateDumpTruck.Location = new Point(128, 562);
            buttonCreateDumpTruck.Name = "buttonCreateDumpTruck";
            buttonCreateDumpTruck.Size = new Size(115, 23);
            buttonCreateDumpTruck.TabIndex = 7;
            buttonCreateDumpTruck.Text = "Создать самосвал";
            buttonCreateDumpTruck.UseVisualStyleBackColor = true;
            buttonCreateDumpTruck.Click += ButtonCreateDumpTruck_Click;
            // 
            // comboBoxPointOfDestination
            // 
            comboBoxPointOfDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPointOfDestination.Enabled = false;
            comboBoxPointOfDestination.FormattingEnabled = true;
            comboBoxPointOfDestination.Items.AddRange(new object[] { "К центру", "К правом нижнему краю" });
            comboBoxPointOfDestination.Location = new Point(779, 13);
            comboBoxPointOfDestination.Name = "comboBoxPointOfDestination";
            comboBoxPointOfDestination.Size = new Size(125, 23);
            comboBoxPointOfDestination.TabIndex = 8;
            comboBoxPointOfDestination.SelectedIndexChanged += comboBoxPointOfDestination_SelectedIndexChanged;
            // 
            // buttonMovementStep
            // 
            buttonMovementStep.Location = new Point(829, 42);
            buttonMovementStep.Name = "buttonMovementStep";
            buttonMovementStep.Size = new Size(75, 23);
            buttonMovementStep.TabIndex = 9;
            buttonMovementStep.Text = "Шаг";
            buttonMovementStep.UseVisualStyleBackColor = true;
            buttonMovementStep.Click += buttonMovementStep_Click;
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 597);
            Controls.Add(buttonMovementStep);
            Controls.Add(comboBoxPointOfDestination);
            Controls.Add(buttonCreateDumpTruck);
            Controls.Add(buttonCheckBorders);
            Controls.Add(buttonRight);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonLeft);
            Controls.Add(buttonCreateCar);
            Controls.Add(pictureBoxSportCar);
            Name = "FormCar";
            Text = "Грузовик";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSportCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxSportCar;
		private Button buttonCreateCar;
		private Button buttonLeft;
		private Button buttonUp;
		private Button buttonDown;
		private Button buttonRight;
		private Button buttonCheckBorders;
        private Button buttonCreateDumpTruck;
        private ComboBox comboBoxPointOfDestination;
        private Button buttonMovementStep;
    }
}
