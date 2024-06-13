using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prøve_2024
{
    public class Member
    {
        private int id;
        private string name;
        private string adress;
        private int yearofbirth;
        private int phone;
        private string email;


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

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public int Yearofbirth
        {
            get { return yearofbirth; }
            set { yearofbirth = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }  

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return $"ID: {id}, Navn: {name}, Adresse: {adress}, Fødselsår: {yearofbirth}, Telefon: {phone}, Email: {email}";
        }

    }
}
