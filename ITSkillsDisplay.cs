using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public class ITSkillsDisplay
    {
        public static int InsertITSkillsDetails(int candidateId)
        {
            ITSkillsService iTSkillsService = new ITSkillsService();
            return iTSkillsService.ReadITSkillDetails(candidateId);
        }
        public static void DisplayITSkillsDetails()
        {
            ITSkillsService service = new ITSkillsService();
            List<ITSkills> itSkillsList = service.GetITSkills();

            //Display Data in a Table Format
            Console.WriteLine("ITSkills Details:");
            Console.WriteLine();
            Console.WriteLine("Id      CandidateId    Name      Version       LastUsed     SkillExperienceInYears   SkillExperienceInMonths  ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
            foreach (ITSkills item in itSkillsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "         " + item.Name + "           " + item.Version + "               " + item.LastUsed + "               " + item.ExperienceInYears + "           " + item.ExperienceInMonths);
            }
            Console.WriteLine();
        }
    }
}

