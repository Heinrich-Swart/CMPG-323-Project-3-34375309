using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepo
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //Get:Product
        public List<Device> Getall()
        {
            return _context.Device.ToList();
        }
    }
}
