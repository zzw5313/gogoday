using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace gogoday.Models
{
    public class OrgTree : TreeView
    {
        
        private static OrgTree otree;
        public static OrgTree GetInstance()
        {
            if (otree == null)
            {
                otree = new OrgTree();
            }
            return otree;
        }
    }
}