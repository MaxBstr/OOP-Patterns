using System;

namespace Patterns._1._Creational._5._Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person) MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person) MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(Name);
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }
    }
}
