using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class OnlineProfileDisplay
    {
        public static int InsertOnlineProfileDetails(int candidateId)
        {
            OnlineProfileDetailsService onlineProfileDetails = new OnlineProfileDetailsService();
            return onlineProfileDetails.ReadOnlineProfileDetails(candidateId);
        }
        public static void DisplayOnlineProfileDetails()
        {
            OnlineProfileDetailsService onlineProfileDetailsBusinessLogic = new OnlineProfileDetailsService();
            List<OnlineProfileDetails> onlineProfileDetailsList = onlineProfileDetailsBusinessLogic.PrintOnlineProfileDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Online Profile Details : ");
            Console.Write("Id CandidateId   Title   URL Description  SocialProfile CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (OnlineProfileDetails item in onlineProfileDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Title + "        " + item.URL + "           " + item.Description + "        " +  item.SocialProfile + "        " + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}

