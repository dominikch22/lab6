
namespace lab6
{
    partial class Form1
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
            this.pathInput = new System.Windows.Forms.TextBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.dataFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editField = new System.Windows.Forms.TextBox();
            this.labelsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.integerLabel = new System.Windows.Forms.Label();
            this.doubleLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.erroLabel = new System.Windows.Forms.Label();
            this.InputsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.doubleInput = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.birthDateInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.clearMemoryButton = new System.Windows.Forms.Button();
            this.labelsContainer.SuspendLayout();
            this.InputsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathInput
            // 
            this.pathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathInput.Location = new System.Drawing.Point(13, 13);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(1128, 20);
            this.pathInput.TabIndex = 0;
            // 
            // selectFile
            // 
            this.selectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFile.Location = new System.Drawing.Point(1149, 10);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 23);
            this.selectFile.TabIndex = 1;
            this.selectFile.Text = "Przeglądaj";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // dataFormat
            // 
            this.dataFormat.FormattingEnabled = true;
            this.dataFormat.Items.AddRange(new object[] {
            "Całkowite",
            "Rzeczywiste",
            "Calkowita, rzeczywista i tekst",
            "Osoba",
            "Całkowite i rzczywiste",
            "Osoby"});
            this.dataFormat.Location = new System.Drawing.Point(16, 78);
            this.dataFormat.Name = "dataFormat";
            this.dataFormat.Size = new System.Drawing.Size(121, 21);
            this.dataFormat.TabIndex = 2;
            this.dataFormat.SelectedIndexChanged += new System.EventHandler(this.dataFormat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format zapisywania";
            // 
            // editField
            // 
            this.editField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editField.Location = new System.Drawing.Point(16, 112);
            this.editField.Multiline = true;
            this.editField.Name = "editField";
            this.editField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.editField.Size = new System.Drawing.Size(1289, 375);
            this.editField.TabIndex = 4;
            // 
            // labelsContainer
            // 
            this.labelsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsContainer.Controls.Add(this.integerLabel);
            this.labelsContainer.Controls.Add(this.doubleLabel);
            this.labelsContainer.Controls.Add(this.textLabel);
            this.labelsContainer.Controls.Add(this.nameLabel);
            this.labelsContainer.Controls.Add(this.surnameLabel);
            this.labelsContainer.Controls.Add(this.birthDateLabel);
            this.labelsContainer.Controls.Add(this.heightLabel);
            this.labelsContainer.Controls.Add(this.weightLabel);
            this.labelsContainer.Controls.Add(this.erroLabel);
            this.labelsContainer.Location = new System.Drawing.Point(152, 50);
            this.labelsContainer.Name = "labelsContainer";
            this.labelsContainer.Size = new System.Drawing.Size(1153, 31);
            this.labelsContainer.TabIndex = 13;
            // 
            // integerLabel
            // 
            this.integerLabel.AutoSize = true;
            this.integerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.integerLabel.Location = new System.Drawing.Point(3, 0);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.integerLabel.Size = new System.Drawing.Size(100, 13);
            this.integerLabel.TabIndex = 20;
            this.integerLabel.Text = "Całkowita";
            // 
            // doubleLabel
            // 
            this.doubleLabel.AutoSize = true;
            this.doubleLabel.Location = new System.Drawing.Point(109, 0);
            this.doubleLabel.Name = "doubleLabel";
            this.doubleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.doubleLabel.Size = new System.Drawing.Size(100, 13);
            this.doubleLabel.TabIndex = 22;
            this.doubleLabel.Text = "Rzyczywista";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(215, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Padding = new System.Windows.Forms.Padding(0, 0, 66, 0);
            this.textLabel.Size = new System.Drawing.Size(100, 13);
            this.textLabel.TabIndex = 23;
            this.textLabel.Text = "Tekst";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(321, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 74, 0);
            this.nameLabel.Size = new System.Drawing.Size(100, 13);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Imie";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(427, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 47, 0);
            this.surnameLabel.Size = new System.Drawing.Size(100, 13);
            this.surnameLabel.TabIndex = 25;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(533, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.birthDateLabel.Size = new System.Drawing.Size(100, 13);
            this.birthDateLabel.TabIndex = 26;
            this.birthDateLabel.Text = "Data urodzenia";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(639, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.heightLabel.Size = new System.Drawing.Size(100, 13);
            this.heightLabel.TabIndex = 27;
            this.heightLabel.Text = "Wzrost";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(745, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Padding = new System.Windows.Forms.Padding(0, 0, 64, 0);
            this.weightLabel.Size = new System.Drawing.Size(100, 13);
            this.weightLabel.TabIndex = 28;
            this.weightLabel.Text = "Waga";
            // 
            // erroLabel
            // 
            this.erroLabel.AutoSize = true;
            this.erroLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.erroLabel.Location = new System.Drawing.Point(851, 0);
            this.erroLabel.Name = "erroLabel";
            this.erroLabel.Size = new System.Drawing.Size(0, 13);
            this.erroLabel.TabIndex = 29;
            // 
            // InputsContainer
            // 
            this.InputsContainer.Controls.Add(this.integerInput);
            this.InputsContainer.Controls.Add(this.doubleInput);
            this.InputsContainer.Controls.Add(this.textInput);
            this.InputsContainer.Controls.Add(this.nameInput);
            this.InputsContainer.Controls.Add(this.surnameInput);
            this.InputsContainer.Controls.Add(this.birthDateInput);
            this.InputsContainer.Controls.Add(this.heightInput);
            this.InputsContainer.Controls.Add(this.weightInput);
            this.InputsContainer.Controls.Add(this.addButton);
            this.InputsContainer.Controls.Add(this.saveButton);
            this.InputsContainer.Location = new System.Drawing.Point(152, 76);
            this.InputsContainer.Name = "InputsContainer";
            this.InputsContainer.Size = new System.Drawing.Size(1026, 29);
            this.InputsContainer.TabIndex = 14;
            // 
            // integerInput
            // 
            this.integerInput.Location = new System.Drawing.Point(3, 3);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(100, 20);
            this.integerInput.TabIndex = 19;
            // 
            // doubleInput
            // 
            this.doubleInput.Location = new System.Drawing.Point(109, 3);
            this.doubleInput.Name = "doubleInput";
            this.doubleInput.Size = new System.Drawing.Size(100, 20);
            this.doubleInput.TabIndex = 21;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(215, 3);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(100, 20);
            this.textInput.TabIndex = 22;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(321, 3);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 23;
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(427, 3);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(100, 20);
            this.surnameInput.TabIndex = 24;
            // 
            // birthDateInput
            // 
            this.birthDateInput.Location = new System.Drawing.Point(533, 3);
            this.birthDateInput.Name = "birthDateInput";
            this.birthDateInput.Size = new System.Drawing.Size(100, 20);
            this.birthDateInput.TabIndex = 25;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(639, 3);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 26;
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(745, 3);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(100, 20);
            this.weightInput.TabIndex = 27;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(851, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(932, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 23);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Zapisze";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // readButton
            // 
            this.readButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.readButton.Location = new System.Drawing.Point(1230, 10);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 29;
            this.readButton.Text = "Odczytaj";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.read_Click);
            // 
            // clearMemoryButton
            // 
            this.clearMemoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearMemoryButton.Location = new System.Drawing.Point(1229, 78);
            this.clearMemoryButton.Name = "clearMemoryButton";
            this.clearMemoryButton.Size = new System.Drawing.Size(75, 23);
            this.clearMemoryButton.TabIndex = 30;
            this.clearMemoryButton.Text = "Wyczyść ";
            this.clearMemoryButton.UseVisualStyleBackColor = true;
            this.clearMemoryButton.Click += new System.EventHandler(this.clearMemoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 499);
            this.Controls.Add(this.clearMemoryButton);
            this.Controls.Add(this.InputsContainer);
            this.Controls.Add(this.labelsContainer);
            this.Controls.Add(this.editField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataFormat);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.readButton);
            this.Name = "Form1";
            this.Text = "Niezawodny program do swobodnego zapisywania i odczytywania różnorodnych danych w" +
    " formie binarnej";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.labelsContainer.ResumeLayout(false);
            this.labelsContainer.PerformLayout();
            this.InputsContainer.ResumeLayout(false);
            this.InputsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.ComboBox dataFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editField;
        private System.Windows.Forms.FlowLayoutPanel labelsContainer;
        private System.Windows.Forms.FlowLayoutPanel InputsContainer;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.TextBox doubleInput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.TextBox birthDateInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.Label doubleLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label erroLabel;
        private System.Windows.Forms.Button clearMemoryButton;
    }
}

