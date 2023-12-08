using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pustok.ViewModels
{
    public class EmailSenderViewModel
    { 
        
    [Required(ErrorMessage = "Please enter subject")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Please enter content")]
    public string Body { get; set; }

    [Required(ErrorMessage = "Please enter email receivers")]
    public string To { get; set; }

}
}
