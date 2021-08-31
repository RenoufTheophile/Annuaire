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
        public string seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string version { get; set; }

    }




        



    

}