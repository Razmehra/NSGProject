using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NSGProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationTabbedPage : TabbedPage
    {
        public NotificationTabbedPage ()
        {
            InitializeComponent();
        }
    }
}