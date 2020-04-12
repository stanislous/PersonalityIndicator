using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalityIndicator.Models
{
    public class Answer
    {
        [Key]
        public int KeyNumber { get; set; }
        public int AnswerNumber { get; set; }
        public string Answers { get; set; }
    }
}