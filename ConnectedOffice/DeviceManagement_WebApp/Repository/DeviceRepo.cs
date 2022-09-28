using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.InterfaceRepo;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepo : GenericRepo<Device>, IDeviceRepo
    {
        public DeviceRepo(ConnectedOfficeContext context) : base(context)
        {

        }

        public Device GetMostRecentDevice()
        {
            return _context.Device.OrderByDescending(device => device.DateCreated).FirstOrDefault();
        }
    }
}
