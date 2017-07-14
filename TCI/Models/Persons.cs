using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCI.Models
{
    public class Persons
    {
        public int Id { get; set; } 
        /// <summary>
        /// ok
        /// </summary>
        [Required]
        public string Name { get; set; }
        public string Family { get; set; }
    }
}