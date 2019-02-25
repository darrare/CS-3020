using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces
{
    class Person : IComparable<Person>
    {
        public string name;
        public float weight;
        public float height;
        int age = 5;
        public int Age { get; set; }

        public Person(string name, float weight, float height)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Person other = obj as Person;
            if (this.height > other.height)
            {
                return 1;
            }
            else if (this.height < other.height)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public int CompareTo(Person other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return name + " is " + height + " inches tall and weighs " + weight + "lbs";
        }
    }
}
