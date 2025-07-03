using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class ContactDetailsDisplay
    {
        public static int InsertContactDetails(int CandidateId)
        {
            ContactDetailsService contactDetails = new ContactDetailsService();
            return contactDetails.ReadContactDetails(CandidateId);
        }
        public static void DisplayContactDetails()
        {
            ContactDetailsService contactDetailsBusinessLogic = new ContactDetailsService();
            List<ContactDetails> contactDetailsList = contactDetailsBusinessLogic.PrintContactDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Contact Details : ");
            Console.WriteLine("-----------------------------------------------------\n");
            Console.Write("Id CandidateId   PrimaryEmailAddress   SecondaryEmailAddress PrimaryPhoneNumber SecondaryPhoneNumber IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (ContactDetails item in contactDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.PrimaryEmailAddress + "        " + item.SecondaryEmailAddress + "           " + item.PrimaryPhoneNumber + "        " + item.SecondaryPhoneNumber + "  " + item.IsActive + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
