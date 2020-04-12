using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalityIndicator.Models;

namespace PersonalityIndicator.ViewModels
{
    public class QuestionWithAnswers
    {
        public Question Question { get; set; }
        public List<Answer> Answer { get; set; }
    }
}