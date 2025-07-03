using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class GraduationDisplay
    {
        public static int InsertGraduationDetails(int CandidateId)
        {
            GraduationDetailsService graduation = new GraduationDetailsService();
            return graduation.ReadGraduation(CandidateId);
        }
        public static void DisplayGraduationDetails()
        {
            GraduationDetailsService graduationDetailsBusinessLogic = new GraduationDetailsService();
            List<Graduation> graduationList = graduationDetailsBusinessLogic.PrintGraduation();
            //Display Data in a Table Format
            Console.WriteLine("Enter Graduation Details : ");
            Console.Write("Id CandidateId   Education   Institute Course Specialization CourseType  CourseStartingYear  CourseEndingYear  GradingSystem  IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (Graduation item in graduationList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Name + "        " + item.Institute + "           " + item.Institute + "           " + item.Course + "        " + item.Specialization + "  " + item.CourseType + "  " + item.CourseStartingYear + "           " + item.CourseEndingYear + "        " + item.GradingSystem + "  " + item.Marks + "   " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
