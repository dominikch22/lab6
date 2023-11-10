using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Person
    {
        public string Name;
        public string Surname;

        private long _birthDate;
        public long BirthDate
        {
            get {
                return _birthDate;
            }
            set {
                birthDatetime = new DateTime(value);
                _birthDate = value;
            }
        }
        public double height;
        public double weight;
        public DateTime birthDatetime;

        public static Person readPerson(BinaryReader reader) {
            Person person = new Person();
            person.Name = reader.ReadString();
            person.Surname = reader.ReadString();
            person.BirthDate = reader.ReadInt64();
            person.height = reader.ReadDouble();
            person.weight = reader.ReadDouble();

            return person;
        }

        public static void savePerson(BinaryWriter writer, Person person)
        {          
            writer.Write(person.Name);
            writer.Write(person.Surname);
            writer.Write(person.BirthDate);
            writer.Write(person.height);
            writer.Write(person.weight);
        }

    }
}
