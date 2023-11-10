using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        private BinaryFileReaderWriter BinaryFileReaderWriter;
        public Form1()
        {
            InitializeComponent();
            DateTime dateIn1940 = new DateTime(1940, 1, 1);
            long a = dateIn1940.Ticks;
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

            this.addButton.Click += new System.EventHandler(this.saveIntegers);           
        }

        private void saveIntegers(object sender, EventArgs e)
        {
            int[] ints = new int[1];
            ints[0] = int.Parse(integerInput.Text);
            BinaryFileReaderWriter.saveIntegers("C:\\Users\\DCH\\Desktop\\chuj.bin", ints);
        }


        private void integerInput_TextChanged_1(object sender, EventArgs e)
        {
           

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
