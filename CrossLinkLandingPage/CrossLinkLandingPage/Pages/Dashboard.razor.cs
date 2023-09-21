using System;


namespace CrossLinkLandingPage.Pages
{
    partial class Dashboard
    {
        private string actualEmail { get; set; }
        private string actualSubject { get; set; }
        private string actualBody { get; set; }

        private Task SendMail()
        {
            try
            {
                //cuxpgfoybnifhhlz

                actualEmail = string.Empty;
                actualSubject= string.Empty;
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
