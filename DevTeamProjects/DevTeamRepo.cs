using DeveloperProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamProjects
{

    public class DevTeamRepo
    {
        private readonly DeveloperRepo _developerRepo = new DeveloperRepo(); // this gives you access to the _developerDirectory so you can access existing Developers and add them to a team
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        //DevTeam Create
        public void AddDevTeamList(DevTeam team)
        {
            _devTeams.Add(team);

        }
        //DevTeam Read
        public List<DevTeam> GetDevTeamList()
        {
            return _devTeams;
        }
        //DevTeam Update
        public bool UpdateDevTeam(int givenID,DevTeam newTeam)
        {
            DevTeam old = GetListBYID(givenID);
            if(old!=null)
            {
                old.DevName = newTeam.DevName;
                old.IsTeamLeader = newTeam.IsTeamLeader;
                old.MembersNumber = newTeam.MembersNumber;
                old.TeamName = old.TeamName;
                return true;
            }
            else
            {
                return false;
            }
        }
        //DevTeam Delete
        public bool RemoveTeam(int id)
        {
            DevTeam devTeam = GetListBYID(id);
            if (devTeam==null)
            {
                return false;
            }
            int initialCount = _devTeams.Count;
            _devTeams.Remove(devTeam);

            if (initialCount>_devTeams.Count)
            {
                return true;
            }
            return false;

            
        }
        //DevTeam Helper (Get Team by ID)
        public DevTeam GetListBYID(int id)
        {
            foreach (DevTeam emid in _devTeams)
            {
                if (emid.DevID== id)
                {
                    return emid;
                } 

            } return null;
        }

    }
}
