using DeveloperProject;
using System;
using System.Collections.Generic;

namespace Devloper_Console
{
    class ProgrmaUI

    {
        private DeveloperRepo _devRepo = new DeveloperRepo();
        //public object Daveloper { get; private set; }

        public void Run()
        {
            Members();
        }
        private void Members()

        {
            bool keepRuning = true;
            while (keepRuning)
            {
                //Display the Option
                Console.WriteLine("Choos Option:\n" +
                    "1. Create new Develpoer\n" +
                    "2. View all Developers\n" +
                    "3. View Developers By ID\n" +
                    "4. Update Existing Option\n" +
                    "5.Delete Existing Developers\n" +
                    "6. Exit");
                
                //Get the user's Input
                string input = Console.ReadLine();

                //Evalute the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        AddDevelopers();
                        //Create new Developer
                        break;
                    case "2":
                        ShowAllDevelopers();
                        //View All Content
                        
                        break;
                    case "3":
                        //View Members By ID
                        ShowAllDeveloperByID();
                        break;
                    case "4":
                        //Update Existing Members
                        UpdateExistingDevelopers();
                        break;
                    case "5":
                        //Remove Mebers
                        RemoveExistingDeveloper();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRuning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Number.");
                        break;
                }
                Console.WriteLine("Press any key to contunue...");
                
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Create new Developer Method
        private void AddDevelopers()
        {
            Console.Clear();
            Developer newMenber = new Developer();
            //Title 
            Console.WriteLine("Enter Developer ID:");
            string idNumber = Console.ReadLine();
            newMenber.EmplayeeID = int.Parse(idNumber);
            //Description
            Console.WriteLine("Enter Employee name:");
            newMenber.EmployeeName = Console.ReadLine();
            //Maturity Rating
            Console.WriteLine("Does the Employee have access?(y/n)");
            string respons = Console.ReadLine().ToLower();
            if (respons=="y")
            {
                newMenber.HaveAccessForOnlineLearning=true;
            }
            else
            {
                newMenber.HaveAccessForOnlineLearning =false;
            }
            // Developer Type
            /*
             * Language=1,
        SofwareDevlopment,
        DatabseDeveleopment,
        DataAnalytics,
        Metwprking,
        ServerAdmin
             */
            Console.WriteLine("Enter Plural sight Course Number:\n" +
                "1.Language\n" +
                "2. Soft Ware Developmnet\n" +
                "3. Database Development\n" +
                "4. Data Analytics\n" +
                "5. Networking\n" +
                "6. Server Admin");
            string course = Console.ReadLine();
            int courseNumber = int.Parse(course);
            newMenber.TypeOfCourse = (CourseType)courseNumber;

            _devRepo.AddDeveloperToDirectory(newMenber);
        }
        //View All Sved  Developers
        private  void ShowAllDevelopers()
        {
            Console.Clear();

            List<Developer> listOfDevelopers = _devRepo.GetDevelopersList();

            foreach (var deves in listOfDevelopers)
            {
                Console.WriteLine($"DeveloperID:{deves.EmplayeeID}\n" +
                    $"Developer Name: {deves.EmployeeName}");

            }


        }
        //View All Save developers by Id
        private void ShowAllDeveloperByID()
        {
            Console.Clear();
            Console.WriteLine("Enter Employee ID:");
            string idNumber = Console.ReadLine();
            int numberID = int.Parse(idNumber);

            //Find Id 
            Developer dev = _devRepo.GetDeveloperBYID(numberID);
            if (dev != null)
            {
                Console.WriteLine($"ID:{dev.EmplayeeID}\n" +
                    $"Employee Name:{dev.EmployeeName}\n" +
                    $"The Type of Course:{dev.TypeOfCourse}\n" +
                    $"Does the Developer have access?{dev.HaveAccessForOnlineLearning}");
            }
            else Console.WriteLine("Employee Id Can  not be found.");
        }
        //Update Existing Contetn
        private void UpdateExistingDevelopers()
        {
            ShowAllDevelopers();
            //Ask for ID
            Console.WriteLine("Which Emplayee data do wnat to update? Eneter Employee ID:");
            //Get the ID
            string oldID = Console.ReadLine();
            int number = Int32.Parse(oldID);
            //Build new Data
            Console.Clear();
            Developer newMenber = new Developer();

            //Title 
            Console.WriteLine("Enter Developer ID:");
            string idNumber = Console.ReadLine();
            newMenber.EmplayeeID = int.Parse(idNumber);
            //Description
            Console.WriteLine("Enter Employee name:");
            newMenber.EmployeeName = Console.ReadLine();
            //Maturity Rating
            Console.WriteLine("Does the Employee have access?(y/n)");
            string respons = Console.ReadLine().ToLower();
            if (respons == "y")
            {
                newMenber.HaveAccessForOnlineLearning = true;
            }
            else
            {
                newMenber.HaveAccessForOnlineLearning = false;
            }
            // Developer Type
            /*
             * Language=1,
        SofwareDevlopment,
        DatabseDeveleopment,
        DataAnalytics,
        Metwprking,
        ServerAdmin
             */
            Console.WriteLine("Enter Plural sight Course Number:\n" +
                "1.Language\n" +
                "2. Soft Ware Developmnet\n" +
                "3. Database Development\n" +
                "4. Data Analytics\n" +
                "5. Networking\n" +
                "6. Server Admin");
            string course = Console.ReadLine();
            int courseNumber = int.Parse(course);
            newMenber.TypeOfCourse = (CourseType)courseNumber;

                     

        }
        //Delete Existing 
        private  void RemoveExistingDeveloper()
        {
            Console.Clear();
            ShowAllDeveloperByID();
            //Get the Employee Id You want to Delete
            Console.WriteLine("Enter Employee ID:");
            string idNumber = Console.ReadLine();
            int input = int.Parse(idNumber);
            // Call the Delete Method
            bool wasDeleted = _devRepo.RemoveDevs(input);

            //If the Contetn is Deleted , say no
            if (wasDeleted)
            {
                Console.WriteLine("The Content is Sicessfully Removed.");
            }
            else
            {
                Console.WriteLine("I can't Find the Id, Could not delete");
            }
            
        }
        private void SeedDeveleoperes()
        {
            Developer FirstDeveloper = new Developer(1, "David Savary",true,CourseType.DatabseDeveleopment);
            Developer SecondDeveloper = new Developer(2, "Jeff Stone", false, CourseType.DatabseDeveleopment);

            _devRepo.AddDeveloperToDirectory(FirstDeveloper);
            _devRepo.AddDeveloperToDirectory(SecondDeveloper);

        }
    }
}
