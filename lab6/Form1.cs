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
        //private BinaryFileReaderWriter BinaryFileReaderWritero;
        private List<int> Integers;
        private List<double> Doubles;
        private List<Person> Persons;
        private List<Tuple<int, double>> IntsDoubles;
        public Form1()
        {
           
            InitializeComponent();
            Integers = new List<int>();
            Doubles = new List<double>();
            Persons = new List<Person>();
            IntsDoubles = new List<Tuple<int, double>>();

            saveIntegersSelected();
            //BinaryFileReaderWritero = new BinaryFileReaderWriter();


            //Integers.Add(12);
            //Integers.Add(24);
            //BinaryFileReaderWriter.SaveToFile("C:\\Users\\DCH\\Desktop\\test.bin", Integers);
            //Integers.Clear();
            //Integers = BinaryFileReaderWriter.ReadFromFile<List<int>>("C:\\Users\\DCH\\Desktop\\test.bin");
            Console.WriteLine("");
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
            BinaryFileReaderWriter.SaveToFile(pathInput.Text, Integers);
        }

        private void ReadIntegers(object sender, EventArgs e)
        {
            Integers = BinaryFileReaderWriter.ReadFromFile<List<int>>(pathInput.Text);
            editField.Text = "";
            foreach (int el in Integers) {
                editField.Text += el + "\r\n";
            }
        }

        private void AddIntegers(object sender, EventArgs e)
        {
            Integers.Add(int.Parse(integerInput.Text));
            editField.Text = "";
            foreach (int i in Integers) {
                editField.Text += i + "\r\n";
            }
        }

        private void SaveDoubles(object sender, EventArgs e)
        {
            BinaryFileReaderWriter.SaveToFile(pathInput.Text, Doubles);
        }

        private void readDoubles(object sender, EventArgs e)
        {
            Doubles = BinaryFileReaderWriter.ReadFromFile<List<double>>(pathInput.Text);
            editField.Text = "";
            foreach (double el in Doubles)
            {
                editField.Text += el + "\r\n";
            }
        }

        private void AddDoubles(object sender, EventArgs e)
        {
            Doubles.Add(double.Parse(doubleInput.Text));
            editField.Text = "";
            foreach (double n in Doubles)
            {
                editField.Text += n + "\r\n";
            }
        }

        private void SaveStructure(object sender, EventArgs e)
        {
            Structure structure = new Structure();
            structure.IntN = int.Parse(integerInput.Text);
            structure.DoubleN = double.Parse(doubleInput.Text);
            structure.Text = textInput.Text;
            BinaryFileReaderWriter.SaveToFile(pathInput.Text, structure);

            editField.Text = $"{structure.IntN}, {structure.DoubleN}, {structure.Text}";
        }

        private void ReadStructure(object sender, EventArgs e)
        {         
            Structure structure = BinaryFileReaderWriter.ReadFromFile<Structure>(pathInput.Text);

            editField.Text = $"{structure.IntN}, {structure.DoubleN}, {structure.Text}";
        }

        private void SavePerson(object sender, EventArgs e)
        {
            Person person = GetPerson();
            editField.Text = person.ToString();
            BinaryFileReaderWriter.SaveToFile(pathInput.Text, person);
        }
        private void ReadPerson(object sender, EventArgs e)
        {            
            Person person = BinaryFileReaderWriter.ReadFromFile<Person>(pathInput.Text);
            editField.Text = person.ToString();
        }

        private Person GetPerson() {
            Person person = new Person();
            person.Name = nameInput.Text;
            person.Surname = surnameInput.Text;
            //person.BirthDate = long.Parse(birthDateInput.Text);
            person.Height = double.Parse(heightInput.Text);
            person.Weight = double.Parse(weightInput.Text);
            return person;
        }
        private void AddPerson(object sender, EventArgs e)
        {
            Persons.Add(GetPerson());
            editField.Text = "";
            foreach (Person el in Persons)
            {
                editField.Text += el.ToString() + "\r\n";
            }
        }

        private void SavePersons(object sender, EventArgs e)
        {        
            BinaryFileReaderWriter.SaveToFile(pathInput.Text, Persons);
        }

        private void readPersons(object sender, EventArgs e)
        {
            Persons = BinaryFileReaderWriter.ReadFromFile<List<Person>>(pathInput.Text);
            editField.Text = "";
            foreach (Person el in Persons)
            {
                editField.Text += el + "\r\n";
            }
        }


        private void SaveIntegersAndDoubles(object sender, EventArgs e)
        {

            BinaryFileReaderWriter.SaveToFile(pathInput.Text, IntsDoubles);
        }

        private void AddIntegersAndDoubles(object sender, EventArgs e)
        {

            Tuple<int, double> pair = Tuple.Create(int.Parse(integerInput.Text), double.Parse(doubleInput.Text));
            IntsDoubles.Add(pair);
            editField.Text = "";
            foreach (Tuple<int, double> el in IntsDoubles)
            {
                editField.Text += el.Item1 + ", "+ el.Item2 + "\r\n";
            }
        }


        private void ReadIntegersAndDoubles(object sender, EventArgs e)
        {

            IntsDoubles = BinaryFileReaderWriter.ReadFromFile<List<Tuple<int, double>>>(pathInput.Text);
                             
            editField.Text = "";
            foreach (Tuple<int, double> el in IntsDoubles)
            {
                editField.Text += el.Item1 + ", " + el.Item2 + "\r\n";
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
        }

        private void read_Click(object sender, EventArgs e)
        {

        }
    }
}
