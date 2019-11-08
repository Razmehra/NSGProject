using System;
using System.Collections.Generic;
using System.Text;

namespace NSGProject.Models
{
    public class PendingSyncWorkModel
    {
        public int SrNo { get; set; }
        public string WorkModule { get; set; }
        public string WorkID { get; set; }
        public DateTime PendingSince { get; set; }
        public bool IsSynced { get; set; }
    }
}
