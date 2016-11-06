using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Resume.Models
{
  
        public class ResumeObject
        {
            [Key]
            public Guid Id { get; set; }
            public Basic Basic { get; set; }

            public virtual List<Work> Work { get; set; }
            public virtual List<Volunteer> Volunteer { get; set; }
            public virtual List<Education> Education { get; set; }
            public virtual List<Award> Awards { get; set; }
            public virtual List<Publication> Publications { get; set; }
            public virtual List<Skill> Skills { get; set; }
            public virtual List<Language> Languages { get; set; }
            public virtual List<Interest> Interests { get; set; }
            public virtual List<Reference> References { get; set; }
        }

        public class Basic
        {
            [Key]
            public int Id { get; set; }

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
            [Key]
            public int Id { get; set; }
            public string address { get; set; }
            public string postalCode { get; set; }
            public string city { get; set; }
            public string countryCode { get; set; }
            public string region { get; set; }
        }

        public class Profile
        {
            [Key]
            public int Id { get; set; }
            public string network { get; set; }
            public string username { get; set; }

            [Url]
            public string url { get; set; }
        }

        public class Work
        {
            [Key]
            public int Id { get; set; }
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
            [Key]
            public int Id { get; set; }
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
            [Key]
            public int Id { get; set; }
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
            [Key]
            public int Id { get; set; }
            public string title { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public string date { get; set; }
            public string awarder { get; set; }
            public string summary { get; set; }
        }

        public class Publication
        {
            [Key]
            public int Id { get; set; }
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
            [Key]
            public int Id { get; set; }
            public string name { get; set; }
            public string level { get; set; }
            public string[] keywords { get; set; }
        }

        public class Language
        {
            [Key]
            public int Id { get; set; }
            public string name { get; set; }
            public string level { get; set; }
        }

        public class Interest
        {
            [Key]
            public int Id { get; set; }
            public string name { get; set; }
            public string[] keywords { get; set; }
        }

        public class Reference
        {
            [Key]
            public int Id { get; set; }
            public string name { get; set; }
            public string reference { get; set; }
        }

    
}