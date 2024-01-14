using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        private BinaryFileReaderWriter BinaryFileReaderWriter;
        private List<int> Integers;
        private List<double> Doubles;
        private List<Person> Persons;
        private List<Tuple<int, double>> IntsDoubles;
        private List<int> IntsWith;
        private List<double> DoublesWith;
        public Form1()
        {
           
            InitializeComponent();
            Integers = new List<int>();
            Doubles = new List<double>();
            Persons = new List<Person>();
            IntsDoubles = new List<Tuple<int, double>>();
            IntsWith = new List<int>();
            DoublesWith = new List<double>();

            saveIntegersSelected();
            BinaryFileReaderWriter = new BinaryFileReaderWriter();

       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveIntegersSelected() {
            InputsContainer.Controls.Clear();
            InputsContainer.Controls.Add(integerInput);

            InputsContainer.Controls.Add(addButton);
            InputsContainer.Controls.Add(saveButton);

            labelsContainer.Controls.Clear();
            labelsContainer.Controls.Add(integerLabel);


           
            this.addButton.Click += new System.EventHandler(this.AddIntegers);
            this.saveButton.Click += new System.EventHandler(this.SaveIntegers);
            this.readButton.Click += new System.EventHandler(this.ReadIntegers);

        }

        private void saveDoublesSelected()
        {
            InputsContainer.Controls.Clear();
            InputsContainer.Controls.Add(doubleInput);

            InputsContainer.Controls.Add(addButton);
            InputsContainer.Controls.Add(saveButton);

            labelsContainer.Controls.Clear();
            labelsContainer.Controls.Add(doubleLabel);

            this.addButton.Click += new System.EventHandler(this.AddDoubles);
            this.saveButton.Click += new System.EventHandler(this.SaveDoubles);
            this.readButton.Click += new System.EventHandler(this.readDoubles);


        }

        private void saveStructureSelected()
        {
            InputsContainer.Controls.Clear();
            InputsContainer.Controls.Add(integerInput);
            InputsContainer.Controls.Add(doubleInput);
            InputsContainer.Controls.Add(textInput);

            InputsContainer.Controls.Add(saveButton);

            labelsContainer.Controls.Clear();
            labelsContainer.Controls.Add(integerLabel);
            labelsContainer.Controls.Add(doubleLabel);
            labelsContainer.Controls.Add(textLabel);


            this.saveButton.Click += new System.EventHandler(this.SaveStructure);
            this.readButton.Click += new System.EventHandler(this.ReadStructure);
        }

        private void savePersonSelected()
        {
            InputsContainer.Controls.Clear();
            InputsContainer.Controls.Add(nameInput);
            InputsContainer.Controls.Add(surnameInput);
            InputsContainer.Controls.Add(birthDateInput);
            InputsContainer.Controls.Add(heightInput);
            InputsContainer.Controls.Add(weightInput);


            InputsContainer.Controls.Add(saveButton);

            labelsContainer.Controls.Clear();
            labelsContainer.Controls.Add(nameLabel);
            labelsContainer.Controls.Add(surnameLabel);
            labelsContainer.Controls.Add(birthDateLabel);
            labelsContainer.Controls.Add(heightLabel);
            labelsContainer.Controls.Add(weightLabel);


            this.saveButton.Click += new System.EventHandler(this.SavePerson);
            this.readButton.Click += new System.EventHandler(this.ReadPerson);

        }

        private void saveIntegersAndDoublesSelected()
        {
            InputsContainer.Controls.Clear();
            InputsContainer.Controls.Add(integerInput);
            InputsContainer.Controls.Add(doubleInput);

            InputsContainer.Controls.Add(addButton);
            InputsContainer.Controls.Add(saveButton);

            labelsContainer.Controls.Clear();
            labelsContainer.Controls.Add(integerLabel);
            labelsContainer.Controls.Add(doubleLabel);


            this.addButton.Click += new System.EventHandler(this.AddIntegersAndDoubles);
            this.saveButton.Click += new System.EventHandler(this.SaveIntegersAndDoubles);
            this.readButton.Click += new System.EventHandler(this.ReadIntegersAndDoubles);

        }

        private void savePersonsSelected()
        {
            InputsContainer.Controls.Clear();
            InputsContainer.Controls.Add(nameInput);
            InputsContainer.Controls.Add(surnameInput);
            InputsContainer.Controls.Add(birthDateInput);
            InputsContainer.Controls.Add(heightInput);
            InputsContainer.Controls.Add(weightInput);

            InputsContainer.Controls.Add(addButton);
            InputsContainer.Controls.Add(saveButton);

            labelsContainer.Controls.Clear();
            labelsContainer.Controls.Add(nameLabel);
            labelsContainer.Controls.Add(surnameLabel);
            labelsContainer.Controls.Add(birthDateLabel);
            labelsContainer.Controls.Add(heightLabel);
            labelsContainer.Controls.Add(weightLabel);

            this.addButton.Click += new System.EventHandler(this.AddPerson);
            this.saveButton.Click += new System.EventHandler(this.SavePersons);
            this.readButton.Click += new System.EventHandler(this.readPersons);
        }



        private void SaveIntegers(object sender, EventArgs e)
        {
            try
            {
                BinaryFileReaderWriter.saveIntegers(pathInput.Text, Integers);
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
        }

        private void ReadIntegers(object sender, EventArgs e)
        {
            try
            {
                Integers = BinaryFileReaderWriter.readIntegers(pathInput.Text);
                editField.Text = "";
                foreach (int el in Integers)
                {
                    editField.Text += el + "\r\n";
                }
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
           
        }

        private void AddIntegers(object sender, EventArgs e)
        {
            try
            {
                Integers.Add(int.Parse(integerInput.Text));
                editField.Text = "";
                foreach (int i in Integers)
                {
                    editField.Text += i + "\r\n";
                }
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
            
        }

        private void SaveDoubles(object sender, EventArgs e)
        {
            try
            {
                BinaryFileReaderWriter.saveDoubles(pathInput.Text, Doubles);

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
        }

        private void readDoubles(object sender, EventArgs e)
        {
            try
            {
                Doubles = BinaryFileReaderWriter.readDoubles(pathInput.Text).ToList();
                editField.Text = "";
                foreach (double el in Doubles)
                {
                    editField.Text += el + "\r\n";
                }
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
           
        }

        private void AddDoubles(object sender, EventArgs e)
        {
            try
            {
                Doubles.Add(double.Parse(doubleInput.Text));
                editField.Text = "";
                foreach (double n in Doubles)
                {
                    editField.Text += n + "\r\n";
                }
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
           
        }

        private void SaveStructure(object sender, EventArgs e)
        {
            try
            {
                Structure structure = new Structure();
                structure.IntN = int.Parse(integerInput.Text);
                structure.DoubleN = double.Parse(doubleInput.Text);
                structure.Text = textInput.Text;
                BinaryFileReaderWriter.saveStructure(pathInput.Text, structure);

                editField.Text = $"{structure.IntN}, {structure.DoubleN}, {structure.Text}";
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
            
        }

        private void ReadStructure(object sender, EventArgs e)
        {
            try
            {
                Structure structure = BinaryFileReaderWriter.readStructure(pathInput.Text);

                editField.Text = $"{structure.IntN}, {structure.DoubleN}, {structure.Text}";
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
          
        }

        private void SavePerson(object sender, EventArgs e)
        {
            try
            {
                Person person = GetPerson();
                editField.Text = person.ToString();
                BinaryFileReaderWriter.savePerson(pathInput.Text, person);
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
           
        }
        private void ReadPerson(object sender, EventArgs e)
        {
            try
            {
                Person person = BinaryFileReaderWriter.readPerson(pathInput.Text);
                editField.Text = person.ToString();
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
           
        }

        private Person GetPerson() {

            Person person = new Person();
            person.Name = nameInput.Text;
            person.Surname = surnameInput.Text;
            person.BirthDate = birthDateInput.Text;
            person.Height = double.Parse(heightInput.Text);
            person.Weight = double.Parse(weightInput.Text);
            return person;
        }
        private void AddPerson(object sender, EventArgs e)
        {
            try
            {
                Persons.Add(GetPerson());
                editField.Text = "";
                foreach (Person el in Persons)
                {
                    editField.Text += el.ToString() + "\r\n";
                }
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
           
        }

        private void SavePersons(object sender, EventArgs e)
        {
            try
            {
                BinaryFileReaderWriter.savePersons(pathInput.Text, Persons);
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
        }

        private void readPersons(object sender, EventArgs e)
        {
            try
            {
                Persons = BinaryFileReaderWriter.readPersons(pathInput.Text);
                editField.Text = "";
                foreach (Person el in Persons)
                {
                    editField.Text += el + "\r\n";
                }
                erroLabel.Text = "";

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;

            }
           
        }


        private void SaveIntegersAndDoubles(object sender, EventArgs e)
        {
            try
            {
                BinaryFileReaderWriter.saveIntegersAndDoubles(pathInput.Text, Tuple.Create(IntsWith, DoublesWith));
                erroLabel.Text = "";
            }
            catch (Exception ex) {
                erroLabel.Text = ex.Message;

            }
        }

        private void AddIntegersAndDoubles(object sender, EventArgs e)
        {
            try
            {
                if (!integerInput.Text.Equals("")) {
                    IntsWith.Add(int.Parse(integerInput.Text));
                }
                if (!doubleInput.Text.Equals("")) {
                    DoublesWith.Add(double.Parse(doubleInput.Text));
                }
                //Tuple<int, double> pair = Tuple.Create(int.Parse(integerInput.Text), double.Parse(doubleInput.Text));
                //IntsDoubles.Add(pair);
                editField.Text = "";
                foreach (int el in IntsWith) {
                    editField.Text += el + "\r\n";
                }
                foreach (double el in DoublesWith)
                {
                    editField.Text += el + "\r\n";
                }            
            }
            catch (Exception ex) {
                erroLabel.Text = ex.Message;
            }
          
        }


        private void ReadIntegersAndDoubles(object sender, EventArgs e)
        {
            try
            {
                Tuple<List<int>, List<double>> elements = BinaryFileReaderWriter.readIntegersAndDoubles(pathInput.Text);
                IntsWith = elements.Item1;
                DoublesWith = elements.Item2;

                editField.Text = "";
                foreach (int el in IntsWith)
                {
                    editField.Text += el + "\r\n";
                }
                foreach (double el in DoublesWith)
                {
                    editField.Text += el + "\r\n";
                }
            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.Message;
            }
            
           
        }


        private void RemoveClickEvent(Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);

            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);

            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void dataFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveClickEvent(addButton);
            RemoveClickEvent(saveButton);
            RemoveClickEvent(readButton);
            editField.Text = "";
            switch (dataFormat.SelectedIndex) {
                case 0:
                    saveIntegersSelected();
                    break;
                case 1:
                    saveDoublesSelected();
                    break;
                case 2:
                    saveStructureSelected();
                    break;
                case 3:
                    savePersonSelected();
                    break;
                case 4:
                    saveIntegersAndDoublesSelected();
                    break;
                case 5:
                    savePersonsSelected();
                    break;
            }
            labelsContainer.Controls.Add(erroLabel);
        }

        private void read_Click(object sender, EventArgs e)
        {

        }

        private void clearMemoryButton_Click(object sender, EventArgs e)
        {
            Integers = new List<int>();
            Doubles = new List<double>();
            Persons = new List<Person>();
            IntsDoubles = new List<Tuple<int, double>>();
            editField.Text = "";
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Wybierzz plik";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathInput.Text = openFileDialog.FileName;
            }
        }
    }
}
