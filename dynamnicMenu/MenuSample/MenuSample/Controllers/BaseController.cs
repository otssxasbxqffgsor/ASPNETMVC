using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MenuSample.Models;

namespace MenuSample.Controllers
{
    public class BaseController : Controller
    {
    
        public BaseController()
        {
         ViewBag.Menu =  BuildMenu();
        }

        private  IList<MenuModel> BuildMenu()
        {
            IList<MenuModel> mmList = new List<MenuModel>(){

                // Parent
                new MenuModel(){ Id = 1, Name = "Home", ParentId = 0, SortOrder = 1} ,
                new MenuModel(){ Id = 2, Name = "Admin", ParentId = 0, SortOrder = 1} ,
                new MenuModel(){ Id = 3, Name = "Accounting", ParentId = 0, SortOrder = 1} ,

                // Children

                new MenuModel() { Id=21, Name = "Create User", ParentId = 2, SortOrder=1 },
                new MenuModel() { Id=22, Name = "Create Group", ParentId = 2, SortOrder=2 },
                new MenuModel() { Id=23, Name = "Create Account", ParentId = 2, SortOrder=3},

                new MenuModel() { Id=31, Name = "Manage Account", ParentId = 3, SortOrder=1 },
                new MenuModel() { Id=32, Name = "GL Accounts", ParentId = 3, SortOrder=2 },
                

                new MenuModel() { Id=321, Name = "Salary Accounts", ParentId = 32, SortOrder=1 },
                new MenuModel() { Id=322,Name = "Savings Accounts", ParentId = 32, SortOrder=2 },

            };

            return mmList;
        }
    }
}
