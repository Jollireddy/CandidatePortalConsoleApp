using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class ResumeHeadlineDisplay
    {
        public static int InsertResumeHeadline(int CandidateId)
        {
            ResumeHeadlineServices resumeHeadline = new ResumeHeadlineServices();
            return resumeHeadline.ReadResumeHeadline(CandidateId);
        }
        public static void DisplayResumeHeadline()
        {
            ResumeHeadlineServices resumeHeadlineBusinessLogic = new ResumeHeadlineServices();
            List<ResumeHeadline> resumeHeadlineList = resumeHeadlineBusinessLogic.PrintResumeHeadline();
            //Display Data in a Table Format
            Console.WriteLine("Enter Resume Headline  : ");
            Console.Write("Id CandidateId   Headline  IsActive CreatedDate UpdatedDate CreatedBy UpdatedBy\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (ResumeHeadline item in resumeHeadlineList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "           " + item.Headline + "   " + item.IsActive + "  " + item.CreatedDate + "  " + item.UpdatedDate + "  " + item.CreatedBy + "  " + item.UpdatedBy);
            }
        }
        
    }
}

