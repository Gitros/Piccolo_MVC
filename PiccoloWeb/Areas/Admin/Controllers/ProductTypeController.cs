using Microsoft.AspNetCore.Mvc;
using Piccolo.DataAccess.Data;
using Piccolo.DataAccess.Repository.IRepository;
using Piccolo.Models;

namespace PiccoloWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<ProductType> objProductTypeList = _unitOfWork.ProductType.GetAll().ToList();
            return View(objProductTypeList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductType obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Product Type created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ProductType? productTypeFromDb = _unitOfWork.ProductType.Get(u => u.Id == id);
            if (productTypeFromDb == null)
            {
                return NotFound();
            }
            return View(productTypeFromDb);
        }
        [HttpPost]
        public IActionResult Edit(ProductType obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Product Type updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
        ProductType? productTypeFromDb = _unitOfWork.ProductType.Get(u => u.Id == id);
            if (productTypeFromDb == null)
            {
                return NotFound();
            }
            return View(productTypeFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult EditPOST(int? id)
        {
            ProductType? obj = _unitOfWork.ProductType.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.ProductType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Product Type deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
