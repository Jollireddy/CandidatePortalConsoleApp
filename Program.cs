using System;
namespace CandidatePortal
{
    public class Program
    {
        static void Main(string[] args)
        {
      //Reading Candidate Details from Console screen and Inserting to Database
int candidateId = PersonalDetailsDisplay.InsertPersonalDetails();
      ContactDetailsDisplay.InsertContactDetails(candidateId);
       AddressDetailsDisplay.InsertAddressDetails(candidateId);
      CareerProfileDisplay.InsertCareerProfile(candidateId);
        ITSkillsDisplay.InsertITSkillsDetails(candidateId);
        EmploymentDetailsDisplay.InsertEmploymentDetails(candidateId);
       ProjectDetailsDisplay.InsertProjectDetails(candidateId);
      ProfileSummaryDisplay.InsertProfileSummary(candidateId);
       ResumeHeadlineDisplay.InsertResumeHeadline(candidateId);
       DocumentDetailsDisplay.InsertDocumentDetails(candidateId);
       LanguageDetailsDisplay.InsertLanguageDetails(candidateId);
       TenthDisplay.InsertTenthDetails(candidateId);
      TwelfthDisplay.InsertTwelfthDetails(candidateId);
       GraduationDisplay.InsertGraduationDetails(candidateId);
      ITSkillsDisplay.InsertITSkillsDetails(candidateId);
       PostGraduationDisplay.InsertPostGraduationDetails(candidateId);
      DoctorateDisplay.InsertDoctorateDetails(candidateId);
        PresentationDisplay.InsertPresentationDetails(candidateId);
      OnlineProfileDisplay.InsertOnlineProfileDetails(candidateId);
      ResearchPublicationDisplay.InsertResearchPublication(candidateId);
      PatentDisplay.InsertPatentDetails(candidateId);
      CertificationDisplay.InsertCertificationDetails(candidateId);
        WorkSampleDisplay.InsertWorkSampleDetails(candidateId);
        KeySkillsDisplay.InsertKeySkillsDetails(candidateId);
        if (candidateId > 0)
        {
            Console.WriteLine("Successfully inserted data in database!");
        }
        // Read Candidate Details from the database and Display on to the Console Screen
           PersonalDetailsDisplay.DisplayPersonalDetails();
          ContactDetailsDisplay.DisplayContactDetails();
          AddressDetailsDisplay.DisplayAddressDetails();
          CareerProfileDisplay.DisplayCareerProfile();
          ITSkillsDisplay.DisplayITSkillsDetails();
          EmploymentDetailsDisplay.DisplayEmploymentDetails();
            ProjectDetailsDisplay.DisplayProjectDetails();
           ProfileSummaryDisplay.DisplayProfileSummary();
           ResumeHeadlineDisplay.DisplayResumeHeadline();
          DocumentDetailsDisplay.DisplayDocumentDetails();
              LanguageDetailsDisplay.DisplayLanguageDetails();
          TenthDisplay.DisplayTenthDetails();
            TwelfthDisplay.DisplayTwelfthDetails();
           GraduationDisplay.DisplayGraduationDetails();
           PostGraduationDisplay.DisplayPostGraduationDetails();
          DoctorateDisplay.DisplayDoctorateDetails();
            PresentationDisplay.DisplayPresentationDetails();
          OnlineProfileDisplay.DisplayOnlineProfileDetails();
          ResearchPublicationDisplay.DisplayResearchPublicationDetails();
          PatentDisplay.DisplayPatentDetails();
          CertificationDisplay.DisplayCertificationDetails();
          WorkSampleDisplay.DisplayWorkSampleDetails();
          KeySkillsDisplay.DisplayKeySkillsDetails();
            Console.ReadLine();
        }
    }
}
