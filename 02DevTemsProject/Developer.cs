using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperProject
{

    public enum CourseType
    {
        Language = 1,
        SofwareDevlopment,
        DatabseDeveleopment,
        DataAnalytics,
        Metwprking,
        ServerAdmin
    }
    // 
    public class Developer
    {
        public int EmplayeeID { get; set; }
        public string EmployeeName { get; set; }
        public bool HaveAccessForOnlineLearning { get; set; }
        public CourseType TypeOfCourse { get; set; }
        public Developer() { }
        public Developer(int employeeID, string employeeName, bool haveAccess, CourseType typeOfCourse)
        {
            EmplayeeID = employeeID;
            EmployeeName = employeeName;
            HaveAccessForOnlineLearning = haveAccess;
            TypeOfCourse = typeOfCourse;
        }


    }
}
