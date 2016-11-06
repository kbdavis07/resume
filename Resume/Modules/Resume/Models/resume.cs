using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Resume.Models
{
    public class resume
    {

        public class Resume
        {
            public Basics basics { get; set; }
            public Work[] work { get; set; }
            public Volunteer[] volunteer { get; set; }
            public Education[] education { get; set; }
            public Award[] awards { get; set; }
            public Publication[] publications { get; set; }
            public Skill[] skills { get; set; }
            public Language[] languages { get; set; }
            public Interest[] interests { get; set; }
            public Reference[] references { get; set; }
        }

        public class Basics
        {

            [Required]
            public string name { get; set; }
            public string label { get; set; }

            [Url]
            public string picture { get; set; }

            [EmailAddress]
            public string email { get; set; }

            [Phone]
            public string phone { get; set; }

            [Url]
            public string website { get; set; }

            [Required]
            public string summary { get; set; }
            public Location location { get; set; }
            public Profile[] profiles { get; set; }
        }

        public class Location
        {
            public string address { get; set; }
            public string postalCode { get; set; }
            public string city { get; set; }
            public string countryCode { get; set; }
            public string region { get; set; }
        }

        public class Profile
        {
            public string network { get; set; }
            public string username { get; set; }

            [Url]
            public string url { get; set; }
        }

        public class Work
        {
            public string company { get; set; }
            public string position { get; set; }

            [Url]
            public string website { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string startDate { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string endDate { get; set; }
            public string summary { get; set; }
            public string[] highlights { get; set; }
        }

        public class Volunteer
        {
            public string organization { get; set; }
            public string position { get; set; }

            [DataAnnotationsExtensions.Url]
            public string website { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string startDate { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string endDate { get; set; }
            public string summary { get; set; }
            public string[] highlights { get; set; }
        }

        public class Education
        {
            public string institution { get; set; }
            public string area { get; set; }
            public string studyType { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string startDate { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string endDate { get; set; }
            public string gpa { get; set; }
            public string[] courses { get; set; }
        }

        public class Award
        {
            public string title { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string date { get; set; }
            public string awarder { get; set; }
            public string summary { get; set; }
        }

        public class Publication
        {
            public string name { get; set; }
            public string publisher { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string releaseDate { get; set; }

            [Url]
            public string website { get; set; }
            public string summary { get; set; }
        }

        public class Skill
        {
            public string name { get; set; }
            public string level { get; set; }
            public string[] keywords { get; set; }
        }

        public class Language
        {
            public string name { get; set; }
            public string level { get; set; }
        }

        public class Interest
        {
            public string name { get; set; }
            public string[] keywords { get; set; }
        }

        public class Reference
        {
            public string name { get; set; }
            public string reference { get; set; }
        }

    }
}