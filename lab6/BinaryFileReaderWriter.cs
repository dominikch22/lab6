using System;
using System.Collections.Generic;
using System.IO;

namespace lab6
{
    class BinaryFileReaderWriter
    {

        public void saveIntegers(string path, List<int> numbers)
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (int i in numbers)
                {
                    writer.Write(i);
                }
            }
        }
        public List<int> readIntegers(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {              
                List<int> numbers = new List<int>();

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    numbers.Add(reader.ReadInt32());
                }             
                return numbers;
            }
        }

        public void saveDoubles(string path, List<double> numbers)
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {

                foreach (double n in numbers)
                {
                    writer.Write(n);
                }
            }
        }

        public List<double> readDoubles(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                List<double> numbers = new List<double>();

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    numbers.Add(reader.ReadDouble());
                }
                   
                return numbers;
            }
        }

        public void saveStructure(string path, Structure structure)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(structure.IntN);
                writer.Write(structure.DoubleN);
                writer.Write(structure.Text);
            }
        }

        public Structure readStructure(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                Structure structure = new Structure();
                structure.IntN = reader.ReadInt32();
                structure.DoubleN = reader.ReadDouble();
                structure.Text = reader.ReadString();

                return structure;
            }
        }

        public void savePerson(string path, Person person)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                Person.savePerson(writer, person);
            }
        }

        public Person readPerson(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                return Person.readPerson(reader);
            }
        }

        public void saveIntegersAndDoubles(string path, Tuple<List<int>, List<double>> numbers)
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(numbers.Item1.Count);
                writer.Write(numbers.Item2.Count);
                foreach (int e in numbers.Item1) {
                    writer.Write(e);
                }
                foreach (double e in numbers.Item2)
                {
                    writer.Write(e);
                }             
            }
        }

        public Tuple<List<int>, List<double>> readIntegersAndDoubles(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                List<int> ints = new List<int>();
                List<double> doubles = new List<double>();

                int numberOfInts = reader.ReadInt32();
                int numberOfDuobles = reader.ReadInt32();

                for (int i = 0; i < numberOfInts; i++) {
                    ints.Add(reader.ReadInt32());
                }

                for (int i = 0; i < numberOfDuobles; i++)
                {
                    doubles.Add(reader.ReadDouble());
                }           
              
                return Tuple.Create(ints, doubles);
            }
        }

        public void savePersons(string path, List<Person> persons)
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (Person person in persons)
                {
                    Person.savePerson(writer, person);
                }
            }
        }

        public List<Person> readPersons(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                List<Person> persons = new List<Person>();

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    persons.Add(Person.readPerson(reader));
                }
                 
                return persons;
            }
        }
    }
}
