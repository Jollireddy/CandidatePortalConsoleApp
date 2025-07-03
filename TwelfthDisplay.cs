using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class TwelfthDisplay
    {
        public static int InsertTwelfthDetails(int CandidateId)
        {
            TwelfthDetailsService twelfth = new TwelfthDetailsService();
            return twelfth.ReadTwelfth(CandidateId);
        }
        public static void DisplayTwelfthDetails()
        {
            TwelfthDetailsService twelfthDetailsBusinessLogic = new TwelfthDetailsService();
            List<Twelfth> twelfthList = twelfthDetailsBusinessLogic.PrintTwelfth();
            //Display Data in a Table Format
            Console.WriteLine("Enter Twelfth Details : ");
            Console.Write("Id CandidateId   Education   Board PassingOutYear SchoolMedium Marks  IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (Tenth item in twelfthList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Name + "        " + item.Board + "           " + item.PassingOutYear + "        " + item.SchoolMedium + "  " + item.Marks + " " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
