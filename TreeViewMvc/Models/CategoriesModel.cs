using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeViewMvc.Models
{
    public class CategoriesModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public int ParentId { get; set; }
        public IList<CategoriesModel> Children = null;
        public CategoriesModel()
        {
            Children = new List<CategoriesModel>();
        }
    }
}