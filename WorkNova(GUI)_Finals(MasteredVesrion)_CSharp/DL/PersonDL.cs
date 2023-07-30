using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL
{
    class PersonDL
    {
        private static List<Person> Persons = new List<Person>();

        public static List<Person> Persons1 { get => Persons; set => Persons = value; }
        public static void AddPerson(Person person)
        {
            Persons.Add(person);
        }
        public static void RemovePerson(Person person)
        {
            Persons.Remove(person);
        }
        public static Person SearchPersonByName(string name)
        {
            foreach(Person tempPerson in Persons)
            {
                if(tempPerson.Name==name)
                {
                    return tempPerson;
                }
            }
            return null;
        }
        public static bool IsPersonAvailable(string name,string password)
        {
            foreach(Person tempPerson in Persons)
            {
                if(tempPerson.Name==name&&tempPerson.Password==password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
