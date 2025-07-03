using Candidate.BusinessLogic;
using Candidate.Models;
using System;
using System.Collections.Generic;

namespace CandidatePortal
{
    public static class AddressDetailsDisplay
    {
        public static int InsertAddressDetails(int CandidateId)
        {
            AddressDetailsService addressDetails = new AddressDetailsService();
            return addressDetails.ReadAddressDetails(CandidateId);
        }
        public static void DisplayAddressDetails()
        {
            AddressDetailsService addressDetailsBusinessLogic = new AddressDetailsService();
            List<AddressDetails> addressDetailsList = addressDetailsBusinessLogic.PrintAddressDetails();

             //Display Data in a Table Format
            Console.WriteLine("Enter Address Details : ");
            Console.Write("Id     AddressType            FlatNumber          BuildingNumber       Street          LandMark             City           State          Country           Pincode   IsActive      CreatedDate         UpdatedTime        CreatedBy       UpdatedBy   ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (AddressDetails item in addressDetailsList)
            {
                Console.WriteLine(item.Id + "        " + item.AddressType + "           " + item.FlatNumber + "               " + item.BuildingNumber + "                   " + item.Street + "       "+item.IsActive+"       " + item.LandMark + "          " + item.City + "          " + item.State + "          " + item.Country + "           " + item.Pincode + "       " + item.CreatedDate + "          " + item.UpdatedDate + "        " + item.CreatedBy + "       " + item.UpdatedBy);
            }
            Console.WriteLine();

        }
    }
}