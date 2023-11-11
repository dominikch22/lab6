using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class BinaryFileReaderWriter
    {

        public static void SaveToFile<T>(string fileName, T data)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, data);
                }
                Console.WriteLine($"Dane zapisano do pliku: {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas zapisywania do pliku {fileName}: {ex.Message}");
            }
        }

        public static T ReadFromFile<T>(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas odczytywania z pliku {fileName}: {ex.Message}");
                return default(T);
            }
        }

        /*public void saveIntegers(string path, int[] numbers) {

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

        public void saveIntegersAndDoubles(string path, Tuple<int, double>[] numbers)
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (Tuple<int, double> e in numbers)
                {
                    writer.Write(e.Item1);
                    writer.Write(e.Item2);
                }
            }
        }

        public Tuple<int, double>[] readIntegersAndDoubles(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                long length = reader.BaseStream.Length;
                Tuple<int, double>[] numbers = new Tuple<int, double>[length];

                for (int i = 0; i < length; i++)
                {
                    Tuple<int, double> element = Tuple.Create(reader.ReadInt32(), reader.ReadDouble());
                    numbers[i] = element;
                }
                return numbers;
            }
        }

        public void savePersons(string path, Person[] persons)
        {

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (Person person in persons)
                {
                    Person.savePerson(writer, person);                 
                }
            }
        }

        public Person[] readPersons(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                long length = reader.BaseStream.Length;
                Person[] persons = new Person[length];

                for (int i = 0; i < length; i++)
                {
                    persons[i] = Person.readPerson(reader);
                }
                return persons;
            }
        }*/
    }
}
