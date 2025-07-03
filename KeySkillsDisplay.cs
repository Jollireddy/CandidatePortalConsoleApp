using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public class KeySkillsDisplay
    {
        public static int InsertKeySkillsDetails(int candidateId)
        {
            KeySkillsService keySkillsService = new KeySkillsService();
            return keySkillsService.ReadKeySkillsDetails(candidateId);
        }
        public static void DisplayKeySkillsDetails()
        {
            KeySkillsService service = new KeySkillsService();
            List<KeySkill> keySkillsList = service.GetKeySkill();

            //Display Data in a Table Format
            Console.WriteLine("KeySkills Details:");
            Console.WriteLine();
            Console.WriteLine("Id      CandidateId       Name   ");
            Console.WriteLine("------------------------------------");
            foreach (KeySkill item in keySkillsList)
            {
                Console.WriteLine(item.Id + "      " + item.CandidateId + "         " + item.Name);
            }
            Console.WriteLine();
        }
    }
}
