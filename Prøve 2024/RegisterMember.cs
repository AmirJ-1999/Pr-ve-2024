using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prøve_2024
{
    public class RegisterMember
    {
        private List<Member> members = new List<Member>();

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            members.Remove(member);
        }

        public void UpdateMember(Member member)
        {
            Member memberToUpdate = members.Find(m => m.ID == member.ID);
            if (memberToUpdate != null)
            {
                memberToUpdate.Name = member.Name;
                memberToUpdate.Adress = member.Adress;
                memberToUpdate.Yearofbirth = member.Yearofbirth;
                memberToUpdate.Phone = member.Phone;
                memberToUpdate.Email = member.Email;
            }


        }
        public List<Member> GetAllMembers()
        {
            return members;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Member member in members)
            {
                result += members + "\n";
            }
            return result;
        }
    }
}
