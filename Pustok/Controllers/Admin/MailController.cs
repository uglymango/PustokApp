using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Pustok.Database.DomainModels;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Pustok.Controllers.Admin
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EmailRequest emailRequest)
        {
            
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "muradval@mail.com");
            
            mimeMessage.From.Add(mailboxAddressFrom);


            MailboxAddress mailboxAddressTo = new MailboxAddress("User", emailRequest.To);

            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Subject = emailRequest.Subject;
            
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("muradval@mail.com", "CodeTest123");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
