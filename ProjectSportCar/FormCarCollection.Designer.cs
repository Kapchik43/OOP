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
            panelStorage = new Panel();
            labelCompanyName = new Label();
            textBoxCompanyName = new TextBox();
            radioButtonMassive = new RadioButton();
            radioButtonList = new RadioButton();
            radioButtonLinkedList = new RadioButton();
            buttonCompanyAdd = new Button();
            buttonCompanyDel = new Button();
            listBoxCompanies = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxTools.SuspendLayout();
            panelStorage.SuspendLayout();
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
            buttonAddCar.Location = new Point(6, 335);
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
            buttonAddDumpTruck.Location = new Point(6, 379);
            buttonAddDumpTruck.Name = "buttonAddDumpTruck";
            buttonAddDumpTruck.Size = new Size(168, 38);
            buttonAddDumpTruck.TabIndex = 2;
            buttonAddDumpTruck.Text = "Добавить самосвал";
            buttonAddDumpTruck.UseVisualStyleBackColor = true;
            buttonAddDumpTruck.Click += ButtonAddDumpTruck_Click;
            // 
            // buttonRemoveCar
            // 
            buttonRemoveCar.Location = new Point(6, 463);
            buttonRemoveCar.Name = "buttonRemoveCar";
            buttonRemoveCar.Size = new Size(162, 38);
            buttonRemoveCar.TabIndex = 4;
            buttonRemoveCar.Text = "Удалить по позиции";
            buttonRemoveCar.UseVisualStyleBackColor = true;
            buttonRemoveCar.Click += ButtonRemoveCar_Click;
            // 
            // maskedTextBoxPosition
            // 
            maskedTextBoxPosition.Location = new Point(6, 434);
            maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            maskedTextBoxPosition.Size = new Size(162, 23);
            maskedTextBoxPosition.TabIndex = 3;
            // 
            // panelStorage
            // 
            panelStorage.Controls.Add(buttonCompanyDel);
            panelStorage.Controls.Add(listBoxCompanies);
            panelStorage.Controls.Add(labelCompanyName);
            panelStorage.Controls.Add(textBoxCompanyName);
            panelStorage.Controls.Add(buttonCompanyAdd);
            panelStorage.Controls.Add(radioButtonMassive);
            panelStorage.Controls.Add(radioButtonLinkedList);
            panelStorage.Controls.Add(radioButtonList);
            panelStorage.Location = new Point(1004, 22);
            panelStorage.Name = "panelStorage";
            panelStorage.Size = new Size(180, 259);
            panelStorage.TabIndex = 2;
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(25, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(121, 15);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "Название компании:";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(3, 18);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(174, 23);
            textBoxCompanyName.TabIndex = 3;
            // 
            // radioButtonMassive
            // 
            radioButtonMassive.AutoSize = true;
            radioButtonMassive.Location = new Point(12, 47);
            radioButtonMassive.Name = "radioButtonMassive";
            radioButtonMassive.Size = new Size(67, 19);
            radioButtonMassive.TabIndex = 4;
            radioButtonMassive.TabStop = true;
            radioButtonMassive.Text = "Массив";
            radioButtonMassive.UseVisualStyleBackColor = true;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(102, 47);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(66, 19);
            radioButtonList.TabIndex = 5;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "Список";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinkedList
            // 
            radioButtonLinkedList.AutoSize = true;
            radioButtonLinkedList.Location = new Point(12, 72);
            radioButtonLinkedList.Name = "radioButtonLinkedList";
            radioButtonLinkedList.Size = new Size(128, 19);
            radioButtonLinkedList.TabIndex = 6;
            radioButtonLinkedList.TabStop = true;
            radioButtonLinkedList.Text = "Связанный список";
            radioButtonLinkedList.UseVisualStyleBackColor = true;
            // 
            // buttonCompanyAdd
            // 
            buttonCompanyAdd.Location = new Point(3, 97);
            buttonCompanyAdd.Name = "buttonCompanyAdd";
            buttonCompanyAdd.Size = new Size(174, 23);
            buttonCompanyAdd.TabIndex = 7;
            buttonCompanyAdd.Text = "Добавить компанию";
            buttonCompanyAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCompanyDel
            // 
            buttonCompanyDel.Location = new Point(3, 226);
            buttonCompanyDel.Name = "buttonCompanyDel";
            buttonCompanyDel.Size = new Size(174, 23);
            buttonCompanyDel.TabIndex = 8;
            buttonCompanyDel.Text = "Удалить компанию";
            buttonCompanyDel.UseVisualStyleBackColor = true;
            // 
            // listBoxCompanies
            // 
            listBoxCompanies.FormattingEnabled = true;
            listBoxCompanies.Location = new Point(3, 126);
            listBoxCompanies.Name = "listBoxCompanies";
            listBoxCompanies.Size = new Size(174, 94);
            listBoxCompanies.TabIndex = 9;

            buttonCompanyAdd.Click += ButtonCompanyAdd_Click;
            buttonCompanyDel.Click += ButtonCompanyDel_Click;
            listBoxCompanies.SelectedIndexChanged += ListBoxCompanies_SelectedIndexChanged;
            // 
            // FormCarCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(panelStorage);
            Controls.Add(groupBoxTools);
            Controls.Add(pictureBox);
            Name = "FormCarCollection";
            Text = "FormCarCollection";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxTools.ResumeLayout(false);
            groupBoxTools.PerformLayout();
            panelStorage.ResumeLayout(false);
            panelStorage.PerformLayout();
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
        private Panel panelStorage;
        private Label labelCompanyName;
        private TextBox textBoxCompanyName;
        private RadioButton radioButtonMassive;
        private RadioButton radioButtonList;
        private RadioButton radioButtonLinkedList;
        private Button buttonCompanyAdd;
        private Button buttonCompanyDel;
        private ListBox listBoxCompanies;
    }
}