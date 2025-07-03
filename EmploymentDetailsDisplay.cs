using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public class EmploymentDetailsDisplay
    {
        public static int InsertEmploymentDetails(int candidateId)
        {
            EmploymentDetailsService employmentDetailsService = new EmploymentDetailsService();
            return employmentDetailsService.ReadEmploymentDetails(candidateId);
        }
        public static void DisplayEmploymentDetails()
        {
            EmploymentDetailsService employmentDetailsService = new EmploymentDetailsService();
            List<EmploymentDetails> EmploymentDetailsList = employmentDetailsService.PrintEmploymentDetails();

            Console.WriteLine("Employment Details:");
            Console.WriteLine();
            //Display Data in a Table Format
            Console.WriteLine("Id      CandidateId       IsCurrentEmployment            EmploymentType          TotalExperienceInYears       TotalExperienceInMonths          CurrentCompanyName             CurrentDesignation           JoiningDate          CurrentSalary           SkillsUsed        JobProfile ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (EmploymentDetails item in EmploymentDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "       " + (item.IsCurrentEmployment == 1 ? "Yes" : "No") + "            " + item.EmploymentType + "               " + item.TotalExperienceInYears + "                   " + item.TotalExperienceInMonths + "            " + item.CurrentCompanyName + "          " + item.CurrentDesignation + "          " + item.JoiningDate + "          " + item.CurrentSalary + "           " + item.SkillsUsed + "       " + item.JobProfile);
            }
            Console.WriteLine();
        }
    }
}