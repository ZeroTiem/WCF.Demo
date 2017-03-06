using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.Demo.ServiceReference;
using AutoMapper;

namespace WCF.Demo.Controllers
{
    public class CRUDController : Controller
    {

        private ServiceClient _serviceClient;

        public CRUDController()
        {
            _serviceClient = new ServiceClient();
        }

        // GET: CRUD
        public ActionResult Index()
        {
            var members = _serviceClient.Get();
            return View(members);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Member member)
        {
            _serviceClient.Add(member);
            return RedirectToAction("Index", "CRUD");
        }

        public ActionResult Update(int No)
        {
            var member = _serviceClient.GetByNo(No);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Member_GetByNo_Result, Member>());
            config.AssertConfigurationIsValid();//←證驗應對
            var mapper = config.CreateMapper();
            var mapperMember = mapper.Map<Member>(member);
            return View(mapperMember);
        }

        [HttpPost]
        public ActionResult Update(Member member)
        {
            _serviceClient.Update(member);
            return RedirectToAction("Index", "CRUD");
        }

        public ActionResult GetByNo(int No)
        {
            var member = _serviceClient.GetByNo(No);
            return View(member);
        }

        public ActionResult Delete(int No)
        {
            _serviceClient.Delete(No);
            return RedirectToAction("Index", "CRUD");
        }
    }
}