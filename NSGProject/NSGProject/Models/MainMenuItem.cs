using System;
using System.Collections.Generic;
using System.Text;

namespace NSGProject.Models
{
    public class MainMenuItem
    {
        public int id { get; set; }
        public string MenuTitle { get; set; }
        public string PageRef { get; set; }


        public MainMenuItem()
        {

        }

        public List<MainMenuItem> GetMainMenuItems()
        {
            List<MainMenuItem> menuItems = new List<MainMenuItem>()
            {
                 new MainMenuItem{id=1,MenuTitle="Work List Form (Page3)"},
                 new MainMenuItem{id=2,MenuTitle="e-MB & Inspection details form(Page6)"},
                 new MainMenuItem{id=3,MenuTitle="e-MB & Inspection details form(Page7)"},
                 new MainMenuItem{id=4,MenuTitle="e-Mb & inspection form for Buildings(Page8)"},
                 new MainMenuItem{id=5,MenuTitle="e-Mb & inspection form for Road(Page 13)"},
                 new MainMenuItem{id=6,MenuTitle="Review e-Mb & inspection form for Buildings(Page 21)"},
                 new MainMenuItem{id=7,MenuTitle="Review e-Mb & inspection form for Roads(Page 32)"},
                 new MainMenuItem{id=8,MenuTitle="Select AOI form - (Page 17)"},
                 new MainMenuItem{id=9,MenuTitle="Pending Sync Work List form - (Page 18)"},
                 new MainMenuItem{id=10,MenuTitle="Profile details form - (Page 19"},
                 new MainMenuItem{id=11,MenuTitle="Notification List form - (Page 29"},
                 new MainMenuItem{id=12,MenuTitle="Notification List form - (Page 41)"},
                 new MainMenuItem{id=13,MenuTitle="NCR form - (Page 35)"},
                 new MainMenuItem{id=14,MenuTitle="NCR form - (Page 36)"},
                 new MainMenuItem{id=15,MenuTitle="Raise ATR against NCR - (Page 39 )"},
                 new MainMenuItem{id=16,MenuTitle="ATR / NCR / Hindrance Remarks List - (Page 42)"},
                 new MainMenuItem{id=17,MenuTitle="Validate ATR form -  (Page 49)"},
                 new MainMenuItem{id=18,MenuTitle="Raise Hindrance Rigester Form - (Page 54)"},
                 new MainMenuItem{id=19,MenuTitle="Raise Hindrance Rigester Form - (Page 55)"},
                 new MainMenuItem{id=20,MenuTitle="Taking action for  Hindrance raised form -  (page 59)"},
                 new MainMenuItem{id=21,MenuTitle="Display Images navigation page – To check history images taken earlier while inspection"}
            };

            return menuItems;
        }
    }
}
