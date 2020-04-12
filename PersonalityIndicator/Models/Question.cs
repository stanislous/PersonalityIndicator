using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalityIndicator.Models
{
    public class Question
    {
        [Key]
        public int KeyNumber { get; set; }
        public int QuestionNumber { get; set; }
        public string Questions { get; set; }
    }
}