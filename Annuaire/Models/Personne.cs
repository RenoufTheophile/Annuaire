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
        public string Last { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("service")]
        public string Service { get; set; }
        [Column("first")]
        public string First { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("email")]
        public string Email { get; set; }
        public Root Root { get; }
        public List<Result> Results { get; set; }
        public Info Info { get; set; }
        public List<Personne> Personnes;
        
        public string PersonneService { get; set; }
        public string SearchString { get; set; }
    }

    public class Name
    {
        [Key]
        [Column("title")]
        public string Title { get; set; }
        [Column("last")]
        public string Last { get; set; }
        [Column("first")]
        public string First { get; set; }
    }


    
    public class Registered
    {
        [Key]
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("service")]
        public string Service { get; set; }
    }
    public class Result
    {
        public Name Name { get; set; }
        public Registered Registered { get; set; }
        [Key]
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
    }

    public class Info
    {
        [Key]
        [Column("seed")]
        public string Seed { get; set; }
        [Column("results")]
        public int Results { get; set; }
        [Column("page")]
        public int Page { get; set; }
        [Column("version")]
        public string Version { get; set; }
    }
    public class Root
    {
        public List<Result> Results { get; set; }
        public Info Info { get; set; }
        

    }



        



    

}