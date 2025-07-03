using System;
using System.Collections.Generic;
using Candidate.Models;
using Candidate.BusinessLogic;

namespace CandidatePortal
{
    public class LoginUserDisplay
    {
        public static int InsertLoginUserDetails(int candidateId)
        {
            LoginUserService loginUserService = new LoginUserService();
            return loginUserService.ReadLoginUserDetails(candidateId);
        }

        public static void DisplayLoginUserDetails()
        {
            LoginUserService loginUserService = new LoginUserService();
            List<LoginUser> loginUserDetailsList = loginUserService.PrintLoginUsers();  // Updated method name

            // Display Data in a Table Format
            Console.WriteLine("Enter Login User Details: ");
            Console.Write("Id FirstName MiddleName LastName UserName Email Password PhoneNumber IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            foreach (LoginUser item in loginUserDetailsList)
            {
                Console.WriteLine($"{item.CandidateId} {item.FirstName} {item.MiddleName} {item.LastName} {item.UserName} {item.Email} {item.Password} {item.PhoneNumber} {item.IsActive} {item.CreatedDate} {item.UpdatedDate} {item.CreatedBy} {item.UpdatedBy}");
            }
        }
    }
}
