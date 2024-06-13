using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prøve_2024
{
    public class Dog
    {
        private int id;
        private string name;
        private string race;
        private int yearofbirth;

        // Egenskaber til at få og sætte id
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public int Yearofbirth
        {
            get { return yearofbirth; }
            set { yearofbirth = value; }
        }

        public Dog(int id, string name, string race, int yearofbirth)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.yearofbirth = yearofbirth;
        }
        
        

        public class RegisterDog
        {
            private List<Dog> dogs;

            public RegisterDog()
            {
                dogs = new List<Dog>();
            }

            public void AddDog(Dog dog)
            {
                dogs.Add(dog);
            }

            public List<Dog> GetAllDogs()
            {
                return dogs;
            }

        }
        DateTime now = DateTime.Now;
        public override string ToString()
        {
            return $"ID: {id}, Navn: {name}, Race: {race}, Fødselsår: {yearofbirth}";
        }

    }

    
}
