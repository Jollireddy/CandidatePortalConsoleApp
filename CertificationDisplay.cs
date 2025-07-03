using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class CertificationDisplay
    {

        public static int InsertCertificationDetails(int CandidateId)
        {
            CertificationDetailsService certificationDetails = new CertificationDetailsService();
            return certificationDetails.ReadCertificationDetails(CandidateId);
        }
        public static void DisplayCertificationDetails()
        {
            CertificationDetailsService certificationDetailsBusinessLogic = new CertificationDetailsService();
            List<CertificationDetails> certificationDetailsList = certificationDetailsBusinessLogic.PrintCertificationDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Certifification Details : ");
            Console.Write("Id CandidateId   Title   URL  ValidityFromYear ValidityFromMonth ValidityEndYear ValidityEndMonth CurrentlyWorking Description Name CompletionId IsCertificateExpire   CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (CertificationDetails item in certificationDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Title + "        " + item.URL + "           " + item.ValidityFromYear + "           " + item.ValidityFromMonth + "           " + item.ValidityEndYear + "           " + item.ValidityEndMonth + "           " + item.IsCurrentlyWorking + "           " + item.Description + "             " + item.Name + "             " + item.CompletionId + "             " + item.IsCertificateExpire + " " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}


