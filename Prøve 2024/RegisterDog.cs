using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prøve_2024
{
    public class RegisterDog
    {
        private List<Dog> dogs = new List<Dog>();

        public void AddDog(Dog dog)
        {
            dogs.Add(dog);
        }

        public void RemoveDog(Dog dog)
        {
            dogs.Remove(dog);
        }

        public void UpdateDog(Dog dog)
        {
            Dog dogToUpdate = dogs.Find(d => d.ID == dog.ID);
            if (dogToUpdate != null)
            {
                dogToUpdate.ID = dog.ID;
                dogToUpdate.Name = dog.Name;
                dogToUpdate.Race = dog.Race;
                dogToUpdate.Yearofbirth = dog.Yearofbirth;
            }
        }

        public List<Dog> GetAllDogs()
        {
            return dogs;
        }


        public override string ToString()
        {
            string result = "";
            foreach (Dog dog in dogs)
            {
                result += dog + "\n";
            }
            return result;
        }
    }
}