using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FlowerShop.Models.CustomValidation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class NoHarshWordsAllowed : ValidationAttribute
    {
        private List<string> harshWords = new List<string>()
        {
            "ugly", "redundant", "eyesore"
        };

        public override bool IsValid(object value)
        {
            string userFeedback = value as string;

            if (string.IsNullOrEmpty(userFeedback))
                return true;

            var userWords = userFeedback.Split(' ');
            bool harshSentence = userWords.Any(uw => harshWords.Contains(uw));

            return !harshSentence;
        }
    }
}