using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class PostGraduationDisplay
    {
        public static int InsertPostGraduationDetails(int CandidateId)
        {
            PostGraduationDetailsServices postGraduation = new PostGraduationDetailsServices();
            return postGraduation.ReadPostGraduation(CandidateId);
        }
        public static void DisplayPostGraduationDetails()
        {
            PostGraduationDetailsServices postGraduationDetailsBusinessLogic = new PostGraduationDetailsServices();
            List<PostGraduation> postGraduationList = postGraduationDetailsBusinessLogic.PrintPostGraduation();
            //Display Data in a Table Format
            Console.WriteLine("Enter Post Graduation  Details : ");
            Console.Write("Id CandidateId   Education   Institute Course Specialization CourseType  CourseStartingYear  CourseEndingYear  GradingSystem  IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (Graduation item in postGraduationList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Name + "        " + item.Institute + "           " + item.Institute + "           " + item.Course + "        " + item.Specialization + "  " + item.CourseType + "  " + item.CourseStartingYear + "           " + item.CourseEndingYear + "        " + item.GradingSystem + "  " + item.Marks + "   " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
