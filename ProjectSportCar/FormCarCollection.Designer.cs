namespace ProjectCar
{
    partial class FormCarCollection
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
            pictureBox = new PictureBox();
            groupBoxTools = new GroupBox();
            buttonRefresh = new Button();
            buttonAddCar = new Button();
            buttonGoToCheck = new Button();
            buttonAddDumpTruck = new Button();
            buttonRemoveCar = new Button();
            maskedTextBoxPosition = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxTools.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1184, 611);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(buttonRefresh);
            groupBoxTools.Controls.Add(buttonAddCar);
            groupBoxTools.Controls.Add(buttonGoToCheck);
            groupBoxTools.Controls.Add(buttonAddDumpTruck);
            groupBoxTools.Controls.Add(buttonRemoveCar);
            groupBoxTools.Controls.Add(maskedTextBoxPosition);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(1004, 0);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(180, 611);
            groupBoxTools.TabIndex = 1;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(6, 561);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(162, 38);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(6, 22);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(168, 38);
            buttonAddCar.TabIndex = 0;
            buttonAddCar.Text = "Добавить грузовик";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += ButtonAddCar_Click;
            // 
            // buttonGoToCheck
            // 
            buttonGoToCheck.Location = new Point(6, 517);
            buttonGoToCheck.Name = "buttonGoToCheck";
            buttonGoToCheck.Size = new Size(162, 38);
            buttonGoToCheck.TabIndex = 5;
            buttonGoToCheck.Text = "Передать на тесты";
            buttonGoToCheck.UseVisualStyleBackColor = true;
            buttonGoToCheck.Click += ButtonGoToCheck_Click;
            // 
            // buttonAddDumpTruck
            // 
            buttonAddDumpTruck.Location = new Point(6, 66);
            buttonAddDumpTruck.Name = "buttonAddDumpTruck";
            buttonAddDumpTruck.Size = new Size(168, 38);
            buttonAddDumpTruck.TabIndex = 2;
            buttonAddDumpTruck.Text = "Добавить самосвал";
            buttonAddDumpTruck.UseVisualStyleBackColor = true;
            buttonAddDumpTruck.Click += ButtonAddDumpTruck_Click;
            // 
            // buttonRemoveCar
            // 
            buttonRemoveCar.Location = new Point(6, 173);
            buttonRemoveCar.Name = "buttonRemoveCar";
            buttonRemoveCar.Size = new Size(162, 38);
            buttonRemoveCar.TabIndex = 4;
            buttonRemoveCar.Text = "Удалить по позиции";
            buttonRemoveCar.UseVisualStyleBackColor = true;
            buttonRemoveCar.Click += ButtonRemoveCar_Click;
            // 
            // maskedTextBoxPosition
            // 
            maskedTextBoxPosition.Location = new Point(6, 144);
            maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            maskedTextBoxPosition.Size = new Size(162, 23);
            maskedTextBoxPosition.TabIndex = 3;
            // 
            // FormCarCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(groupBoxTools);
            Controls.Add(pictureBox);
            Name = "FormCarCollection";
            Text = "FormCarCollection";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxTools.ResumeLayout(false);
            groupBoxTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private GroupBox groupBoxTools;
        private Button buttonAddCar;
        private Button buttonAddDumpTruck;
        private MaskedTextBox maskedTextBoxPosition;
        private Button buttonRemoveCar;
        private Button buttonGoToCheck;
        private Button buttonRefresh;
    }
}