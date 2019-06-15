using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using FlowerShop.Models.CustomValidation;

namespace FlowerShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }

        [Required(ErrorMessage = "Please, add name.")]
        [StringLength(100, ErrorMessage = "Max name lenght: 100")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, add email.")]
        [StringLength(100, ErrorMessage = "Max Email lenght: 100")]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
           ErrorMessage = "Incorrect email format.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please, add message")]
        [NoHarshWordsAllowed(ErrorMessage = "Please be nice.")]
        [StringLength(5000, ErrorMessage = "Max message lenght: 5000")]
        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}