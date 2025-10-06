using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Members
    {
        private int memberID;
        private string name;
        private string address;
        private int phone;

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Members(int memberID, string name, string address, int phone)
        {
            this.memberID = memberID;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {memberID}");
            Console.WriteLine($"Member Name: {name}");
            Console.WriteLine($"member Address: {address}");
            Console.WriteLine($"Member Phone Number: {phone}");
            Console.WriteLine();
        }
    }


}
