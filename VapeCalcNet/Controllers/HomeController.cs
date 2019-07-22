using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VapeCalc.Models;

namespace VapeCalcNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadPartialView(double PG, double VG, double H2O, double Aroma, double Nic, double Volume, double NicMix)
        {

            var NicConcentrate = NicMix / Nic;

            ResultMix resultMix = new ResultMix();

            resultMix.Nic = Volume / NicConcentrate;
            resultMix.VG = resultMix.Nic * (NicConcentrate * VG / 100);
            resultMix.H20 = resultMix.Nic * (NicConcentrate * H2O / 100);
            resultMix.Aroma = resultMix.Nic * (NicConcentrate * Aroma / 100);
            resultMix.PG = Volume - (resultMix.Nic * (NicConcentrate * VG / 100)
                                        + resultMix.Nic * (NicConcentrate * H2O / 100)
                                        + resultMix.Nic * (NicConcentrate * Aroma / 100)
                                        + resultMix.Nic);
            return PartialView("Result", resultMix);

        }
    }
}