using DeveloperProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamProjects
{
    public class DevTeam
    {
        public string TeamName { get; set; }
        public bool IsTeamLeader { get; set; }
        public int MembersNumber { get; set; }
        public string DevName { get; set; }
        public int DevID { get; set; }

        public DevTeam() { }
        public DevTeam(string teamName,bool teamLeader,int numberofMembers,string devName,int id)
        {
            TeamName = teamName;
            IsTeamLeader = teamLeader;
            MembersNumber = numberofMembers;
            DevName = devName;
            DevID = id;


        }

    }
}
