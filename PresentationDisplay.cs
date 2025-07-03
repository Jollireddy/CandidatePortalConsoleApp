using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class PresentationDisplay
    {
        public static int InsertPresentationDetails(int CandidateId)
        {
            PresentationDetailsServices presentationDetails = new PresentationDetailsServices();
            return presentationDetails.ReadPresentationDetails(CandidateId);
        }
        public static void DisplayPresentationDetails()
        {
            PresentationDetailsServices presentationDetailsBusinessLogic = new PresentationDetailsServices();
            List<PresentationDetails> presentationDetailsList = presentationDetailsBusinessLogic.PrintPresentationDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Presentation  Details : ");
            Console.Write("Id CandidateId   Title   URL Description  SocialProfile IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (PresentationDetails item in presentationDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Title + "        " + item.URL + "           " + item.Description + "    " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
