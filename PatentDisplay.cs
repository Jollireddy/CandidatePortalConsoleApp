using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class PatentDisplay
    {

        public static int InsertPatentDetails(int CandidateId)
        {
           PatentDetailsServices patentDetails = new PatentDetailsServices();
            return patentDetails.ReadPatentDetails(CandidateId);
        }
        public static void DisplayPatentDetails()
        {
            PatentDetailsServices patentDetailsBusinessLogic = new PatentDetailsServices();
            List<PatentDetails> patentDetailsList = patentDetailsBusinessLogic.PrintPatentDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Patent Details : ");
            Console.Write("Id CandidateId   Title   URL  ValidityFromYear ValidityFromMonth ValidityEndYear ValidityEndMonth CurrentlyWorking Description Office Status IssuedMonth IssuedYear ApplicationNumber  CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (PatentDetails item in patentDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Title + "        " + item.URL + "           " + item.ValidityFromYear + "           " + item.ValidityFromMonth + "           " + item.ValidityEndYear + "           " + item.ValidityEndMonth + "           " + item.IsCurrentlyWorking + "           " + item.Description + "             " + item.Office + "             " + item.Status + "             " + item.IssuedMonth + "             "+ item.IssuedYear + "             "+ item.ApplicationNumber + "   " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}


