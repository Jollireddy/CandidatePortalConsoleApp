using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class WorkSampleDisplay
    {
       
        public static int InsertWorkSampleDetails(int candidateId)
        {
            WorkSampleDetailsService workSampleDetails = new WorkSampleDetailsService();
            return workSampleDetails.ReadWorkSampleDetails(candidateId);
        }
        public static void DisplayWorkSampleDetails()
        {
            WorkSampleDetailsService workSampleDetailsService = new WorkSampleDetailsService();
            List<WorkSampleDetails> workSampleDetailsList = workSampleDetailsService.PrintWorkSampleDetails();
            //Display Data in a Table Format
            Console.WriteLine("Enter Work Sample Details : ");
            Console.Write("Id CandidateId   Title   URL  ValidityFromYear ValidityFromMonth ValidityEndYear ValidityEndMonth CurrentlyWorking Description   CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (WorkSampleDetails item in workSampleDetailsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Title + "        " + item.URL + "           " + item.ValidityFromYear + "           " + item.ValidityFromMonth + "           " + item.ValidityEndYear + "           " + item.ValidityEndMonth + "           " + item.IsCurrentlyWorking + "           " + item.Description + "       " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
    }
}


