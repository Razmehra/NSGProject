using System;
using System.Collections.Generic;
using System.Text;

namespace NSGProject.Models
{
    public class Notification_ATR_Model
    {
        public int Id { get; set; }
        public string NCRID { get; set; }
        public DateTime ATRDate { get; set; }
        public string NCROn { get; set; }
        public int Remark { get; set; }
        public string NCRStatus { get; set; }

    }
}
