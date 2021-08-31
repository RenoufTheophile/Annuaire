using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Annuaire.Models
{
    [Table("Personne")]
    public class Personne
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string last { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Column("date")]
        public DateTime date { get; set; }
        [Column("phone")]
        public string phone { get; set; }
        [Column("service")]
        public string service { get; set; }
        [Column("first")]
        public string first { get; set; }
        [Column("title")]
        public string title { get; set; }
        [Column("age")]
        public int age { get; set; }
        [Column("email")]
        public string email { get; set; }
        public Root root { get; }

    }

    public class Name
    {
        [Column("title")]
        public string title { get; set; }
        [Column("last")]
        public string last { get; set; }
        [Column("first")]
        public string first { get; set; }
    }


    
    public class Registered
    {
        [Column("date")]
        public DateTime date { get; set; }
        [Column("service")]
        public string service { get; set; }
    }
    public class Result
    {
        public Name name { get; set; }
        public Registered registered { get; set; }
        [Column("email")]
        public string email { get; set; }
        [Column("phone")]
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