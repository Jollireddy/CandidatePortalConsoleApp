using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;
namespace CandidatePortal
{
    public static class ProjectDetailsDisplay
    {
        public static int InsertProjectDetails(int CandidateId)
        {
            ProjectDetailsService projectDetails = new ProjectDetailsService();
            return projectDetails.ReadProjectDetails(CandidateId);
        }
        public static void DisplayProjectDetails()
        {
            ProjectDetailsService projectDetailsBusinessLogic = new ProjectDetailsService();
            List<ProjectDetails> projectDetailsList = projectDetailsBusinessLogic.PrintProjectDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Project Details : ");
            Console.Write("CandidateId Title TagProject Client Status WorkedFromYear WorkedFromMonth WorkedTillYear  WorkedTillMonth Details Location Site NatureOfEmployment TeamSize JobRole RoleDescription SkillsUsed IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (ProjectDetails item in projectDetailsList)
            {
                Console.WriteLine(item.Id + "   " + item.Title + " " + item.TagProject + " " + item.Client + item.Status + "   " + item.WorkedFromYear + "   " + item.WorkedFromMonth + "   " + item.WorkedTillYear + "   " + item.WorkedTillMonth
                    + "   " + item.Details + "  " + item.Location + "  " + item.Site + "   " + item.NatureOfEmployment + "  " + item.TeamSize + "  " + item.JobRole + "  " + item.RoleDescription + "  " + item.SkillsUsed +
                    "  " );
            }
        }
    }
}

