using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpertSystem.Models
{
    public class PartOfTheWorldModel
    {
        [Required(ErrorMessage = "Select one item")]
        public PartOfTheWorldEnum PartOfTheWorld { get; set; }
    }
}