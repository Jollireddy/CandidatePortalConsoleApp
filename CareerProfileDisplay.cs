using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;
namespace CandidatePortal
{
    public static class CareerProfileDisplay 
    {
        public static int InsertCareerProfile(int CandidateId)
        {
            CareerProfileService careerProfile = new CareerProfileService();
            return careerProfile.ReadCareerProfile(CandidateId);
        }
        public static void DisplayCareerProfile()
        {
            CareerProfileService careerProfileBusinessLogic = new CareerProfileService();
            List<CareerProfile> careerProfileList = careerProfileBusinessLogic.PrintCareerProfile();
            //Display Data in a Table Format
            Console.WriteLine("Enter Career Profile Details : ");
            Console.Write("CandidateId CurrentIndustry Department RoleCategory JobRole DesiredJobType DesiredEmploymentType PrefferedShift PrefferedWorkLocation ExpectedSalary   CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (CareerProfile item in careerProfileList)
            {
                Console.WriteLine(item.Id + "   " + item.CurrentIndustry + " " + item.Department + " " + item.RoleCategory + item.JobRole + "   " + item.DesiredJobType + "   " + item.DesiredEmploymentType + "   " + item.PrefferedShift + "   " + item.PrefferedWorkLocation
                    + "   " + item.ExpectedSalary + " " + item.CreatedDate + " " + item.UpdatedDate + " " + item.CreatedBy + " " + item.UpdatedBy + " ");
            }
        }
    }
}
