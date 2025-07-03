using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;
namespace CandidatePortal
{
    public static class PersonalDetailsDisplay
    {
        public static int InsertPersonalDetails()
        {
            PersonalDetailsService personalDetails = new PersonalDetailsService();
            return personalDetails.ReadPersonalDetails();
        }
        public static void DisplayPersonalDetails()
        {
            PersonalDetailsService personalDetailsBusinessLogic = new PersonalDetailsService();
            List<PersonalDetails> personalDetailsList = personalDetailsBusinessLogic.PrintPersonalDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Personal Details : ");
            Console.Write("CandidateId FirstName LastName MiddleName Age Gender BackGround MaritalStatus DateOfBirth Category DifferentlyAbled CareerBreak WorkPermitUSA WorkPermitCountries IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (PersonalDetails item in personalDetailsList)
            {
                Console.WriteLine(item.Id + "   " + item.FirstName + " " + item.LastName + " " + item.MiddleName + item.Age + "   " + item.Gender + "   " + item.Background + "   " + item.MaritalStatus + "   " + item.DateOfBirth
                    + "   " + item.Category + "  " + ((item.DifferentlyAbled == 1) ? "Yes" : "No")
                    + "  " + ((item.CareerBreak == 1) ? "Yes" : "No") + "  " + item.WorkPermitUSA + "  " + item.WorkPermitCountries +
                    "  " + item.IsActive + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}
