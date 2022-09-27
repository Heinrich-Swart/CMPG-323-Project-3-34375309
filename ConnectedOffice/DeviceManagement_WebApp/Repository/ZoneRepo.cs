using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepo
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //Get:Product
        public List<Zone> Getall()
        {
            return _context.Zone.ToList();
        }
    }
}
