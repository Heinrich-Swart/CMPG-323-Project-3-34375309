using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;

//Interface Device Repository
namespace DeviceManagement_WebApp.InterfaceRepo
{
    //IDevice with the IGenericRepo
    public interface IDeviceRepo : IGenericRepo<Device>
    {
        Device GetMostRecentDevice();
    }
}
