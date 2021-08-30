using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Annuaire.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string last { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public string phone { get; set; }
        public string service { get; set; }
        public string first { get; set; }
        public string title { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public Root root { get; }

    }

    public class Name
    {
        public string title { get; set; }
        public string last { get; set; }
        public string first { get; set; }
    }


    
    public class Registered
    {
        public DateTime date { get; set; }
        public string service { get; set; }
    }
    public class Result
    {
        public Name name { get; set; }
        public Registered registered { get; set; }
        public string email { get; set; }

        public string phone { get; set; }
    }

    public class Info
    {
        public string seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string version { get; set; }
    }
    public class Root
    {
        public List<Result> results { get; set; }
        public Info info { get; set; }
        

    }



        



    

}