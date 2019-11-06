using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NSGProject.Models
{
   public class AssignedWorks: INotifyPropertyChanged
    {
        public int WorkID { get; set; }
        public int WorkOrder { get; set; }
        public string WorkName { get; set; }
        public string M_S { get; set; }
        public float Fin { get; set; }
        public float BoQ { get; set; }
        public float Phy { get; set; }
        public int WorkIndicator { get; set; }
        private string _FBPInfo { get; set; }
        public string FBPInfo
        {
            get { return _FBPInfo ?? $"Fin. P: {Fin}% | BoQ P: {BoQ}% | Phy. P: {Phy}%"; }
            set
            {
                value = $"Fin. P: {Fin}% | BoQ P: {BoQ}% | Phy. P: {Phy}%";
                OnPropertyChanged("FBPInfo");
            }
        }
        public string AssetName { get; set; }
        public float Weightage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
