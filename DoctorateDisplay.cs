using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class DoctorateDisplay
    {
        public static int InsertDoctorateDetails(int CandidateId)
        {
            DoctorateDetailsService doctorate = new DoctorateDetailsService();
            return doctorate.ReadDoctorate(CandidateId);
        }
        public static void DisplayDoctorateDetails()
        {
            DoctorateDetailsService doctorateDetailsBusinessLogic = new DoctorateDetailsService();
            List<Doctorate> doctorateList = doctorateDetailsBusinessLogic.PrintDoctorate();
            //Display Data in a Table Format
            Console.WriteLine("Enter Doctorate Details : ");
            Console.Write("Id CandidateId   Education   Institute Course  Specialization  CourseType  CourseStartingYear  CourseEndingYear  GradingSystem  IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (Doctorate item in doctorateList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Name + "        " + item.Institute + "           " + item.Institute + "           " + item.Course + "        " + item.Specialization + "  " + item.CourseType + "  " + item.CourseStartingYear + "           " + item.CourseEndingYear + "        " + item.GradingSystem + "  " + item.Marks + "   " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
