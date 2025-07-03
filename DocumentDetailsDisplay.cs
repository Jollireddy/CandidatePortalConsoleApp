using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class DocumentDetailsDisplay
    {
        public static int InsertDocumentDetails(int CandidateId)
        {
            DocumentDetailsService documentDetails = new DocumentDetailsService();
            return documentDetails.ReadDocumentDetails(CandidateId);
        }
        public static void DisplayDocumentDetails()
        {
            DocumentDetailsService documentDetailsBusinessLogic = new DocumentDetailsService();
            List<DocumentDetails> documentDetailsList = documentDetailsBusinessLogic.PrintDocumentDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Document Details : ");
            Console.Write("Id CandidateId   AadharCardNumber   PanNumber DrivingLicense VoterCard PassportNumber IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (DocumentDetails item in documentDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.AadharCardNumber + "        " + item.PanNumber + "           " + item.DrivingLicense + "        " + item.VoterCard + "  " +item.PassportNumber + "   "+ item.IsActive + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}

