using TreeViewMvc.Models;

namespace TreeViewMvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TreeViewMvc.Models.TreeViewContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TreeViewMvc.Models.TreeViewContext context)
        {
            context.CategoriesModels.AddOrUpdate(x=>x.CategoryName,
                new CategoriesModel {CategoryName = "Root"},//1
                new CategoriesModel { CategoryName = "Category 1",ParentId = 1},//2
                new CategoriesModel { CategoryName = "Category 2", ParentId = 1 },//3
                new CategoriesModel { CategoryName = "Category 1.1", ParentId = 2 },//4
                new CategoriesModel { CategoryName = "Category 1.2", ParentId = 2 },//5
                new CategoriesModel { CategoryName = "Category 2.1", ParentId = 3 },//6
                new CategoriesModel { CategoryName = "Category 1.1.1", ParentId = 4 },//7
                new CategoriesModel { CategoryName = "Category 1.1.1", ParentId = 4 }//8
            );
        }
    }
}
