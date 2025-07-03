using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public class LanguageDetailsDisplay
    {
        public static int InsertLanguageDetails(int candidateId)
        {
            LanguageDetailsServices languageDetails = new LanguageDetailsServices();
            return languageDetails.ReadLanguageDetails(candidateId);
        }

        public static void DisplayLanguageDetails()
        {
            LanguageDetailsServices languageDetailsBusinessLogic = new LanguageDetailsServices();
            List<Language> languageList = languageDetailsBusinessLogic.PrintLanguagesDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Language Details : ");
            Console.Write("Id CandidateId  Name  Proficiency     Read Write Speak IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (Language item in languageList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Name + "        " + item.Proficiency + "           " + ((item.Read == 1) ? "Yes" : "No") + "        " + ((item.Write == 1) ? "Yes" : "No") + "  " + ((item.Speak == 1) ? "Yes" : "No") + "  " + item.IsActive + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }

    }
}
