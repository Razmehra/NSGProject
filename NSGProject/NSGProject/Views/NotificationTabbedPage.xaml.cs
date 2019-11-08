using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NSGProject.Models;
namespace NSGProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationTabbedPage : TabbedPage
    {
        private AssignedWorks assignedWorks { get; set; }
        private List<Notification_eMB_Model> _eMBNotificationList = new List<Notification_eMB_Model>()
        {
            new Notification_eMB_Model{ id=1, Notification="Review eMB and Work Inspection for\nAtivity Name: as submitted by contractor on dated 03-10-2019 "},
            new Notification_eMB_Model{ id=1, Notification="Review eMB and Work Inspection for\nAtivity Name: as submitted by contractor on dated 04-10-2019 "},
            new Notification_eMB_Model{ id=1, Notification="Review eMB and Work Inspection for\nAtivity Name: as submitted by contractor on dated 05-10-2019 "},
            new Notification_eMB_Model{ id=1, Notification="Review eMB and Work Inspection for\nAtivity Name: as submitted by contractor on dated 06-10-2019 "}

        };

        private int _eMBNotificationCount { get; set; }
        public NotificationTabbedPage(AssignedWorks work = null)
        {
            InitializeComponent();
            assignedWorks = work;

            this.BindingContext = assignedWorks;
            _eMBNotificationCount = _eMBNotificationList.Count();
            EMBNotificationView.Title = $"eMB({_eMBNotificationCount})";
        }

        public void InitializePage(AssignedWorks work=null)
        {
            assignedWorks = work;
            this.BindingContext = assignedWorks;
        }
    }
}