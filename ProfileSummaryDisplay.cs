using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class ProfileSummaryDisplay
    {
        public static int InsertProfileSummary(int candidateId)
        {
            ProfileSummaryServices profileSummary = new ProfileSummaryServices();
            return profileSummary.ReadProfileSummary(candidateId);
        }
        public static void DisplayProfileSummary()
        {
            ProfileSummaryServices profileSummaryBusinessLogic = new ProfileSummaryServices();
            List<ProfileSummary> profileSummaryList = profileSummaryBusinessLogic.PrintProfileSummary();
            //Display Data in a Table Format
            Console.WriteLine("Enter Profile Summary  : ");
            Console.Write("Id CandidateId Summary  IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (ProfileSummary item in profileSummaryList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Summary + "   "   + item.IsActive + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}

