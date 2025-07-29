using System.Linq;
using System.Web.Mvc;
using CNPM_DoAn.dtb; // dùng đúng namespace chứa DbContext và model

public class SanPhamController : Controller
{
    private CNPM_WEB_BAN_HANGEntities db = new CNPM_WEB_BAN_HANGEntities();

    public ActionResult ChiTiet(string id)
    {
        if (string.IsNullOrEmpty(id)) return HttpNotFound();

        var sp = db.San_Pham.Include("Hinh_Anh_San_Pham").FirstOrDefault(s => s.MA_SP == id);
        if (sp == null)
            return HttpNotFound(); // Kiểm tra sp có tồn tại không

        return View("~/Views/Home/ChiTietSanPham.cshtml", sp);
    }

}
