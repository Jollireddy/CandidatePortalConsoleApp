using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class ResearchPublicationDisplay
    {

        public static int InsertResearchPublication(int CandidateId)
        {
            ResearchPublicationDetailsService researchPublicationDetails = new ResearchPublicationDetailsService();
            return researchPublicationDetails.ReadResearchPublicationDetails(CandidateId);
        }
        public static void DisplayResearchPublicationDetails()
        {
            ResearchPublicationDetailsService researchPublicationDetailsBusinessLogic = new ResearchPublicationDetailsService();
            List<ResearchPublicationDetails> researchPublicationDetailsList = researchPublicationDetailsBusinessLogic.PrintResearchPublicationDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Research Publication  Details : ");
            Console.Write("Id CandidateId   Title   URL  Year Month   Description CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (ResearchPublicationDetails item in researchPublicationDetailsList)
            {
               Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Title + "        " + item.URL + "           " + item.Year + "           " + item.Month + "      " + item.Year + "  " + item.Month + "   " + item.Description + "   " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}


