using System;
using System.Collections.Generic;
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
        
    }
}
