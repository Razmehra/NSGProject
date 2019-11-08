using System;
using System.Collections.Generic;
using System.Text;

namespace NSGProject.Models
{
    public class EMBInspactionDetailsModel
    {
        public AssignedWorks assignedWorks { get; set; }
        public int ActivityID { get; set; }
        public string InspectionType { get; set; }
        public string BuildingID { get; set; }
        public float IndivisualWeightage { get; set; }
        public string ActivityName { get; set; }
        public int FloorNo { get; set; }
        public DateTime MeasurmentDate { get; set; }
        public string EMBImages { get; set; }
        public string EMBRemark { get; set; }
        public DateTime InspectionDate { get; set; }
        public float PlannedArea { get; set; }
        public float CompletedArea { get; set; }
        public string InspectionStatus { get; set; }
        public string InspectionRemarks { get; set; }
        public string WorkImages { get; set; }
        //Road's Property
        public string RoadID { get; set; }
        public string Lat_long { get; set; }
        public float PlannedLength { get; set; }
        public float CompletedLength { get; set; }
    }
}
