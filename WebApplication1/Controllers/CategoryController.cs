//using Microsoft.AspNetCore.Mvc;
//using Web.Storage.Data;

//namespace Web.Controllers
//{
//    public class CategoryController : Controller
//    {
//        private readonly AppDbContext _db;

//        public CategoryController(AppDbContext db)
//        {
//            _db = db;
//        }

//        public IActionResult Index()
//        {
//            IEnumerable<Category> objCategoryList = _db.Categories;
//            return View(objCategoryList);
//        }

//        //Get
//        public IActionResult Create()
//        {
//            return View();
//        }

//        //Post
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create(Category obj)
//        {
//            if (ModelState.IsValid)
//            {
//                _db.Categories.Add(obj);
//                _db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(obj);
//        }
//    }
//}
