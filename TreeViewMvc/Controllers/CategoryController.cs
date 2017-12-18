using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TreeViewMvc.Models;

namespace TreeViewMvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly TreeViewContext _treeView;

        public CategoryController()
        {
            _treeView=new TreeViewContext();
        }

        public ActionResult Index()
        {
            var totalRecord = _treeView.CategoriesModels.ToList();
            var rootRecord = _treeView.CategoriesModels.FirstOrDefault(x => x.ParentId == 0);
            SetChildren(rootRecord, totalRecord);
            return View(rootRecord);
        }
        [HttpPost]
        public ActionResult Create(string name, int id)
        {
            var cate=new CategoriesModel();
            cate.CategoryName = name;
            cate.ParentId = id;
            var data =_treeView.CategoriesModels.Add(cate);
            _treeView.SaveChanges();
            return Json(data.ID, JsonRequestBehavior.AllowGet);
        }
        private void SetChildren(CategoriesModel model, List<CategoriesModel> categoryList)
        {
            var childenList = categoryList.Where(x => x.ParentId == model.ID).ToList();
            if (childenList.Count>0)
            {
                foreach (var itemModel in childenList)
                {
                    SetChildren(itemModel,categoryList);
                    model.Children.Add(itemModel);
                }
            }
        }


    }
}