using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.InterfaceRepo;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using Microsoft.AspNetCore.Mvc.Controllers;

//Category repository
namespace DeviceManagement_WebApp.Repository
{
    //Category with the IGenericRepo and GenericRepo
    public class CategoriesRepo : GenericRepo<Category>, ICategoryRepo
    {
        public CategoriesRepo(ConnectedOfficeContext context) : base(context)
        {

        }

        public Category GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(category => category.DateCreated).FirstOrDefault();
        }
        

    }
}
