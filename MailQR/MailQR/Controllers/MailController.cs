using Hangfire;
using MailQR.Database;
using MailQR.Models;
using MessagingToolkit.QRCode.Codec;
using Postal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace MailQR.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ConfirmationEmailViewModel model)
        {
            if(model != null)
            {
                using (MailerDbContext db = new MailerDbContext())
                {
                    model.Id = Guid.NewGuid();
                    model.QRCodePath = CreateQRCodeImage(model.Id.ToString());
                    db.ConfirmationEmails.Add(model);
                    db.SaveChanges();
                }

               BackgroundJob.Enqueue(() => SendConfirmationEmail(model.Id));
            }

            return View();
        }

        public string CreateQRCodeImage(string id)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap img = encoder.Encode(id.ToString());
            string path = Server.MapPath("~/QRCodes/") + id + ".jpg";
            img.Save(path, ImageFormat.Jpeg);
            return path;
        }

        public static void SendConfirmationEmail(Guid id)
        {
            var viewsPath = Path.GetFullPath(HostingEnvironment.MapPath(@"~/Views/Emails"));
            var engines = new ViewEngineCollection();
            engines.Add(new FileSystemRazorViewEngine(viewsPath));

            var emailService = new EmailService(engines);

            using (var db = new MailerDbContext())
            {
                var m = db.ConfirmationEmails.Find(id);
                ConfirmationEmail em = new ConfirmationEmail();
                em.Name = m.Name;
                em.Surname = m.Surname;
                em.To = m.Email;
                em.Attachments.Add(new System.Net.Mail.Attachment(m.QRCodePath));
                emailService.Send(em);
            }

        }

    }
}