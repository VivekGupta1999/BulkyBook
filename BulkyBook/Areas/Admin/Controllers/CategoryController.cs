using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BulkyBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        //public CategoryController(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }



        # region API CAlls
            [HttpGet]
            public IActionResult GetAll()
            {
                var allobj = _unitOfWork.Category.GetAll();
                return Json(new { data = allobj });
            }

            

        #endregion
    }
}
