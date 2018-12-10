using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RankUpWebPage.Models
{
    public class Company
    {
        public string Name { get; set; }
        public int CVR { get; set; }
        public string Location { get; set; }
        public string Logo { get; set; }
        public DateTime EstablishedDate { get; set; }
        public string Feedback { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public int AvailableSkillPoints { get; set; }

        public Company(string name, int cVR, string location, string logo, DateTime establishedDate, string feedback, string email, string phoneNumber, string description)
        {
            Name = name;
            CVR = cVR;
            Location = location;
            Logo = logo;
            EstablishedDate = establishedDate;
            Feedback = feedback;
            Email = email;
            PhoneNumber = phoneNumber;
            Description = description;
            RandomNumber();
        }
     
        public void RandomNumber()
        {
            Random rnd = new Random();
            AvailableSkillPoints = rnd.Next(100, 1000);
        }
    }
}