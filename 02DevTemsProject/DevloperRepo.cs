using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void AddDeveloperToDirectory(Developer dev)
        {
            _developerDirectory.Add(dev);
        }
        //Developer Read
        public List<Developer> GetDevelopersList()
        {
            return _developerDirectory;
        }
        //Developer Update
        public bool UpdateExistingDeveleoper(int orginalID, Developer newDev)
        {
            //Find the Develeopers
            Developer OldID = GetDeveloperBYID(orginalID);

            //Update the content
            if (OldID != null)
            {
                OldID.EmplayeeID = newDev.EmplayeeID;
                OldID.EmployeeName = newDev.EmployeeName;
                OldID.HaveAccessForOnlineLearning = newDev.HaveAccessForOnlineLearning;
                OldID.TypeOfCourse = newDev.TypeOfCourse;
                return true;
            }
            else
            {
                return false;
            }


        }
        //Developer Delete
        public bool RemoveDevs(int id)
        {
            Developer developer = GetDeveloperBYID(id);
            if (developer == null)
            {
                return false;
            }
            int intialCount = _developerDirectory.Count;
            _developerDirectory.Remove(developer);

            if (intialCount > _developerDirectory.Count)
            {
                return true;
            }
            else return false;
        }

        //Developer Helper (Get Developer by ID)
        public Developer GetDeveloperBYID(int employeeID)
        {
            foreach (Developer developer in _developerDirectory)
            {
                if (developer.EmplayeeID == employeeID)
                {
                    return developer;
                }
            }
            return null;
        }
    }
}
