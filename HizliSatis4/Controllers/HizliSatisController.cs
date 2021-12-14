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
        public ActionResult Contact()
        {
            return View();
        }
    }
}

