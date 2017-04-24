using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstManSysMVVM.Model
{
    class Resident
    {
        public int ResidentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsBoardMember { get; set; }
        public int ApartmentID { get; set; }

        public Resident()
        {
            
        }

        public override string ToString()
        {
            return $"The Resident {FirstName} {LastName}({ResidentID}) has a phone number {PhoneNumber} and email address {EmailAddress}";
        }
    }
}
