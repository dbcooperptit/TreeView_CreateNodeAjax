using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TreeViewMvc.Models
{
    public class TreeViewContext:DbContext
    {
        public TreeViewContext() : base("CategoryContext")
        {
        }

        public DbSet<CategoriesModel> CategoriesModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}