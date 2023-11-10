using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class BinaryFileReaderWriter
    {
        public void saveIntegers(string path, int[] numbers) {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create))) {
                foreach (int i in numbers) {
                    writer.Write(i);
                }
            }
        }

        public int[] readIntegers(string path) {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open))) {
                long length = reader.BaseStream.Length;
                int[] numbers = new int[length];

                for (int i = 0; i < length; i++) {
                    numbers[i] = reader.ReadInt32();
                }
                return numbers;
            }
        }

        public void saveDoubles(string path, double[] numbers)
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (double i in numbers)
                {
                    writer.Write(i);
                }
            }
        }

        public double[] readDoubles(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                long length = reader.BaseStream.Length;
                double[] numbers = new double[length];

                for (int i = 0; i < length; i++)
                {
                    numbers[i] = reader.ReadDouble();
                }
                return numbers;
            }
        }

        public void saveStructure(string path, Structure structure)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(structure.intN);
                writer.Write(structure.doubleN);
                writer.Write(structure.text);
            }
        }

        public Structure readStructure(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                Structure structure = new Structure();
                structure.intN = reader.ReadInt32();
                structure.doubleN = reader.ReadDouble();
                structure.text = reader.ReadString();
            
                return structure;
            }
        }


    }
}
