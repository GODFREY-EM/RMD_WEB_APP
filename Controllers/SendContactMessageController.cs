using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

public class SendContactMessageController : Controller
{
    public IActionResult SendContactMessage(string name, string email, string subject, string message)
    {
        try
        {
            // Create a new email message
            var emailMessage = new MailMessage();
            emailMessage.From = new MailAddress(email);
            emailMessage.To.Add("godfreymapunda112@gmail.com"); // Change this to your company's email address
            emailMessage.Subject = subject;
            emailMessage.Body = message;

            // Create a direct SMTP client without specifying an SMTP server
            using (var smtpClient = new SmtpClient())
            {
                // Send the email message without an external SMTP server
                smtpClient.Send(emailMessage);
            }

            // Redirect the user to a success page
            return RedirectToAction("Index", "Home");
        }
       catch (Exception)
{
    return RedirectToAction("Index", "Home");
}

    }
}
