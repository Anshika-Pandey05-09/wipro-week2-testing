// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using System;
//using System.Net.Mail;

//namespace SOLID_CaseStudy
//{
//    class OnlineExamSystem
//    {
//        public void Authenticate(string username, string password)
//        {
//            Console.WriteLine("Authenticating user...");
//            // Authentication logic here (hardcoded for simplicity)
//            if (username == "admin" && password == "admin123")
//                Console.WriteLine("Login successful.");
//            else
//                Console.WriteLine("Invalid credentials.");
//        }

//        public void LoadQuestions()
//        {
//            Console.WriteLine("Loading questions...");
//        }

//        public void SubmitAnswers()
//        {
//            Console.WriteLine("Submitting answers...");
//        }

//        public void GenerateReport(string email)
//        {
//            Console.WriteLine("Generating report...");

//            MailMessage mail = new MailMessage("admin@exam.com", email);
//            mail.Subject = "Exam Report";
//            mail.Body = "You have completed the exam.";

//            SmtpClient client = new SmtpClient("smtp.exam.com");
//            client.Send(mail); // ❌ Tightly coupled to email logic
//        }

//        public void Notify(string type)
//        {
//            if (type == "SMS")
//            {
//                Console.WriteLine("Sending SMS...");
//            }
//            else if (type == "Email")
//            {
//                Console.WriteLine("Sending Email...");
//            }
//            else
//            {
//                Console.WriteLine("Unknown notification type.");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            OnlineExamSystem system = new OnlineExamSystem();

//            system.Authenticate("admin", "admin123");
//            system.LoadQuestions();
//            system.SubmitAnswers();
//            system.GenerateReport("student@example.com");
//            system.Notify("Email");
//        }
//    }
//}

//using System;
//using System.Net.Mail;

//namespace SOLID_CaseStudy
//{
//    public class ReportService
//    {
//        public void GenerateReport(string email)
//        {
//            Console.WriteLine("Generating report...");

//            MailMessage mail = new MailMessage("admin@exam.com", email);
//            mail.Subject = "Exam Report";
//            mail.Body = "You have completed the exam.";

//            SmtpClient client = new SmtpClient("smtp.exam.com");
//            client.Send(mail);
//        }
//    }
//}

using SOLID_CaseStudy;

namespace SOLID_CaseStudy
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var authService = new AuthService();
    //        var reportService = new ReportService();

    //        if (authService.Authenticate("admin", "admin123"))
    //        {
    //            Console.WriteLine("Loading questions...");
    //            Console.WriteLine("Submitting answers...");
    //            reportService.GenerateReport("student@example.com");

    //             Notification strategy applied
    //            NotificationContext notification = new NotificationContext(new SMSNotification());
    //            notification.Notify("Your exam report has been sent.");

    //            // To switch to email, just do:
    //            // NotificationContext notification = new NotificationContext(new EmailNotification());
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var authService = new AuthService();

    //        // Use interface, not concrete class
    //        IReportService reportService = new ReportService();

    //        if (authService.Authenticate("admin", "admin123"))
    //        {
    //            Console.WriteLine("Loading questions...");
    //            Console.WriteLine("Submitting answers...");
    //            reportService.GenerateReport("student@example.com");

    //            var notification = new NotificationContext(new SMSNotification());
    //            notification.Notify("Your exam report has been sent.");
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            var authService = new AuthService();
            IReportService reportService = new ReportService();

            if (authService.Authenticate("admin", "admin123"))
            {
                // 💡 Create user dynamically based on role
                User user = UserFactory.CreateUser("student");
                user.AccessPortal();

                Console.WriteLine("Loading questions...");
                Console.WriteLine("Submitting answers...");
                reportService.GenerateReport("student@example.com");

                var notification = new NotificationContext(new SMSNotification());
                notification.Notify("Your exam report has been sent.");
            }
        }
    }
}