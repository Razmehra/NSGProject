using System;
using System.Collections.Generic;
using System.Text;

namespace NSGProject.Models
{
    public class ProfileDetailModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string District { get; set; }
        public string Address { get; set; }

        public string Designation { get; set; }
        public string Designation_Additional { get; set; }
        public string JENChowki { get; set; }
        public string JENChowki_Additional { get; set; }
        public string SubDivision { get; set; }
        public string SubDivision_Additional { get; set; }
        public string Division { get; set; }
        public string Division_Additional { get; set; }
        public string Circle { get; set; }
        public string Circle_Additional { get; set; }
        public string PhotoPath { get; set; }


    }
}
