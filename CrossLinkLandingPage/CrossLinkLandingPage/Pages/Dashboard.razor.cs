//using MailKit.Net.Smtp;
//using MimeKit;
//using Org.BouncyCastle.Asn1.X509;
using System;
//using System.Net;
//using System.Net.Mail;

namespace CrossLinkLandingPage.Pages
{
    partial class Dashboard
    {
        private string actualEmail { get; set; }
        private string actualSubject { get; set; }
        private string actualBody { get; set; }

        //Modals
        private bool analyzeModal { get; set; }
        private bool designModal { get; set; }
        private bool developmentModal { get; set; }
        private bool validationModal { get; set; }

        private Task ShowAnalyzeModal()
        {
            analyzeModal = true;
            return  Task.CompletedTask;
        }

        private Task ShowDesignModal()
        {
            designModal = true;
            return Task.CompletedTask;
        }

        private Task ShowDevelopmentModal()
        {
            developmentModal = true;
            return Task.CompletedTask;
        }

        private Task ShowValidationModal()
        {
            validationModal = true;
            return Task.CompletedTask;
        }

        private Task HideAnalyzeModal()
        {
            analyzeModal = false;
            return Task.CompletedTask;
        }

        private Task HideDesignModal()
        {
            designModal = false;
            return Task.CompletedTask;
        }

        private Task HideDevelopmentModal()
        {
            developmentModal = false;
            return Task.CompletedTask;
        }

        private Task HideValidationModal()
        {
            validationModal = false;
            return Task.CompletedTask;
        }

        private Task SendMail()
        {
            try
            {
                //using var email = new MimeMessage();


                //email.From.Add(new MailboxAddress(actualEmail, actualEmail));
                //email.To.Add(new MailboxAddress("Diego Henriquez", "funuser@gmail.com"));


                //email.Subject = actualSubject;
                //email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                //{
                //    Text = actualBody
                //};


                //using var smtp = new SmtpClient();
                //smtp.Connect("smtp.server.address", 587, false);


                ////// Note: only needed if the SMTP server requires authentication
                ////smtp.Authenticate("api", "your_api_token");

                //smtp.Send(email);
                //smtp.Disconnect(true);

                //using (MailMessage mailMessage = new MailMessage())
                //{
                //    mailMessage.From = new MailAddress(actualEmail);
                //    mailMessage.To.Add("funuser535@gmail.com");
                //    mailMessage.Subject = actualSubject;
                //    mailMessage.Body = actualBody;
                //    mailMessage.IsBodyHtml= true;

                //    using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)) 
                //    { 
                    
                //    }
                //}

                actualEmail = string.Empty;
                actualSubject = string.Empty;
                actualBody = string.Empty;

                return Task.CompletedTask;
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
                return Task.CompletedTask;
            }
        }
    }
}
