using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace HizliSatis4.Controllers
{
    public class HizliSatisController : Controller
    {
        // GET: HizliSatis
        public ActionResult Index()
        {
            return View();
        }
            //[HttpPost]
            //public JsonResult Index(Models.Email model)
            //{
            //    MailMessage mailim = new MailMessage();
            //    mailim.To.Add("bilgi@bilsoft.com");
            //    mailim.From = new MailAddress("bilgi@bilsoft.com");
            //    mailim.Subject = "Bize Ulaşın Sayfasından Mesajınız Var. ";
            //    mailim.Body = "Ad:" + model.name + " <br> Mail:" + " " + model.email + " <br>Konu:" + model.subject + " <br>Mesaj:" + model.message;
            //    mailim.IsBodyHtml = true;

            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Credentials = new NetworkCredential("bilgi@bilsoft.com", "#sifre");
            //    smtp.Port = 587;
            //    smtp.Host = "smtp.#.com";
            //    smtp.EnableSsl = false;

            //    try
            //    {
            //        smtp.Send(mailim);
            //    }
            //    catch (Exception)
            //    {

            //    }

            //    return Json("asdasd");
            //}

            public ActionResult SiparisVeTeklif()
            {
                return View();
            }
            public ActionResult OtomatikYedekleme()
            {
                return View();
            }
            public ActionResult ExcelVeriAktarim()
            {
                return View();
            }
            public ActionResult StokSayim()
            {
                return View();
            }
            public ActionResult StokRiskLimiti()
            {
                return View();
            }
            public ActionResult Ozellikler()
            {
                return View();
            }
        }
    }

