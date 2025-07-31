using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CaseStudy
{
    //public class ReportService
    //{
    //    public void GenerateReport(string email)
    //    {
    //        Console.WriteLine("Generating report for " + email);

    //        // ✂️ Commenting out actual email code for now
    //        // MailMessage mail = new MailMessage("admin@exam.com", email);
    //        // mail.Subject = "Exam Report";
    //        // mail.Body = "You have completed the exam.";
    //        // SmtpClient client = new SmtpClient("smtp.exam.com");
    //        // client.Send(mail);

    //        Console.WriteLine("Simulated: Email sent to " + email);
    //    }
    //}
    public class ReportService : IReportService
    {
        public void GenerateReport(string email)
        {
            Console.WriteLine("Generating report for " + email);
            Console.WriteLine("Simulated: Email sent to " + email);
        }
    }
}
