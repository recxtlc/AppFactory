using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppFactoryRedone.Classes
{
    public class InternData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsBusiness { get; set; }

        public int Role { get; set; }

        public string FullName { get; set; }

        public int personID { get; set; }

       
        public void GetAllData()
        {
            
        }
    }
}