using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class TenthDisplay
    {
        public static int InsertTenthDetails(int CandidateId)
        {
            TenthDetailsService tenth = new TenthDetailsService();
            return tenth.ReadTenth(CandidateId);
        }
        public static void DisplayTenthDetails()
        {
            TenthDetailsService tenthDetailsBusinessLogic = new TenthDetailsService();
            List<Tenth> tenthList = tenthDetailsBusinessLogic.PrintTenth();
            //Display Data in a Table Format
            Console.WriteLine("Enter Tenth Details : ");
            Console.Write("Id CandidateId   Education   Board PassingOutYear SchoolMedium Marks IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (Tenth item in tenthList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Name + "        " + item.Board + "           " + item.PassingOutYear + "        " + item.SchoolMedium + "  " + item.Marks + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
