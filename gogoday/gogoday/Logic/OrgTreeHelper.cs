using gogoday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gogoday.Logic
{
    public class OrgTreeHelper:IDisposable
    {
        private static gogodayEntities db = new gogodayEntities();
        public List<OrgNode> OrgNodeList = new List<OrgNode>();
        public OrgTree GetOrgTree()
        {
            OrgTree otree = OrgTree.GetInstance();
            otree.Nodes.Clear();
            Company cp = db.Company.ToList()[0];
            OrgNode onode = new OrgNode();
            onode.Code = cp.Code;
            onode.PCode = "";
            onode.Name = cp.Name;
            onode.Text = cp.Code;
            otree.Nodes.Add(onode);
            OrgNodeList.Add(onode);
            AddOrgNode(onode);

            return otree;
        }

        public void AddOrgNode(OrgNode node)
        {
            foreach (Agent agt in db.Agent.Where(A => A.PCode == node.Code))
            {
                OrgNode tnode = new OrgNode();
                tnode.Code = agt.Code;
                tnode.PCode = agt.PCode;
                tnode.Name = agt.Name;
                tnode.Text = agt.Code;
                node.ChildNodes.Add(tnode);
                OrgNodeList.Add(tnode);
                AddOrgNode(tnode);
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}