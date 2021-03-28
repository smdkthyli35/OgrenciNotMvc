using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvc.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(double sayi1=0, double sayi2=0)
        {
            double toplam = sayi1 + sayi2;
            double cikarma = sayi1 - sayi2;
            double carpim = sayi1 * sayi2;
            double bolme = sayi1 / sayi2;

            ViewBag.tplm = toplam;
            ViewBag.cikar = cikarma;
            ViewBag.crpim = carpim;
            ViewBag.blme = bolme;

            return View();
        }
    }
}