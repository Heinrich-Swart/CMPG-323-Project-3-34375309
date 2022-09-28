using DeviceManagement_WebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

//Interface Category Repository
namespace DeviceManagement_WebApp.InterfaceRepo
{
    //ICategory with the IGenericRepo
    public interface ICategoryRepo : IGenericRepo<Category>
    {
        Category GetMostRecentCategory();


    }
}
