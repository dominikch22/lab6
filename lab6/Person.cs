using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    [Serializable]
    class Person
    {
        public string Name;
        public string Surname;
        public double Height;
        public double Weight;
        private string _birthdate;
        public string BirthDate
        {
            get {
                return _birthdate;
            }
            set {
                DateTime.ParseExact(value, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                _birthdate = value;
            }
        }

        public override string ToString()
        {
            return $"Osoba: {Name} {Surname}, data urodzenia: {BirthDate}, wzrost: {Height} cm, waga: {Weight} kg";
        }

        public static Person readPerson(BinaryReader reader) {
            Person person = new Person();
            person.Name = reader.ReadString();
            person.Surname = reader.ReadString();
            person.BirthDate = reader.ReadString();
            person.Height = reader.ReadDouble();
            person.Weight = reader.ReadDouble();

            return person;
        }

        public static void savePerson(BinaryWriter writer, Person person)
        {          
            writer.Write(person.Name);
            writer.Write(person.Surname);
            writer.Write(person.BirthDate);
            writer.Write(person.Height);
            writer.Write(person.Weight);
        }

    }
}
