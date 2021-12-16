using ConnectionLibrary.Model;
using ConnectionLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Async;



namespace RSS.Controllers
{
    public class ImageController : Controller
    {
        //
        // GET: /Image/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadFile(Result model)
        {
            //var model = new Result();
            if (Session["UID"] != null)
            {
                model.UserDetail = AccountRepository.GetuserDetail(Convert.ToInt32(Session["UID"]));
                model.ListDoc = MasterRepository.GetListDoc();

                if (model.UserDetail.Roleid.ToString().Trim() == "2")
                {
                    //  model.ListBhag = model.ListBhag.Where(x => x.VibhagID.ToString() == model.UserDetail.RoleWiseDept.ToString().Trim()).ToList();

                }
                else if (model.UserDetail.Roleid.ToString().Trim() == "3")
                {
                    // model.ListBhag = model.ListBhag.Where(x => x.BhagID.ToString() == model.UserDetail.RoleWiseDept.ToString().Trim()).ToList();

                }

                //var firstitembhag = new _Bhag();
                //firstitembhag.BhagID = 0;
                //firstitembhag.Bhag = "--Select Bhag---";
                //model.ListBhag.Insert(0, firstitembhag);

                //model.ViewBhag = MasterRepository.ViewBhag();

                //if (model.UserDetail.Roleid.ToString().Trim() == "2")
                //{
                //    model.ViewBhag = model.ViewBhag.Where(x => x.VibhagID.ToString() == model.UserDetail.RoleWiseDept.ToString().Trim()).ToList();

                //}
                //else if (model.UserDetail.Roleid.ToString().Trim() == "3")
                //{
                //    model.ViewBhag = model.ViewBhag.Where(x => x.BhagID.ToString() == model.UserDetail.RoleWiseDept.ToString().Trim()).ToList();

                //}


            }
            else
            {
                return RedirectToAction("LogOff", "Account");
            }
            return View(model);
        }
       [HttpPost]
        public ActionResult UploadFile(UploadFileModel model, HttpPostedFileBase file)
        {
            // DO Stuff
            return View(model);
        }
    }
}
