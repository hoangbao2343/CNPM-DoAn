using CNPM_DoAn.dtb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNPM_DoAn.dtb;  // namespace chứa DbContext và model


namespace CNPM_DoAn.Controllers
{
    public class HomeController : Controller
    {
        private CNPM_WEB_BAN_HANGEntities db = new CNPM_WEB_BAN_HANGEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TrangChu() {  
       var danhSach = new Dictionary<string, List<San_Pham>>
        {
            { "Nổi bật", db.San_Pham.Where(sp => sp.DISCOUNT > 0).ToList() },
            { "Mới nhất", db.San_Pham.OrderByDescending(sp => sp.MA_SP).Take(8).ToList() }
        };

        return View(danhSach); } 
        public ActionResult GioGang()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ChiTietSanPham()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}