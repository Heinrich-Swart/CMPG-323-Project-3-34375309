using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.InterfaceRepo;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepo : GenericRepo<Zone>, IZoneRepo
    {
        public ZoneRepo(ConnectedOfficeContext context) : base(context)
        {

        }

        public Zone GetMostRecentZone()
        {
            return _context.Zone.OrderByDescending(zone => zone.DateCreated).FirstOrDefault();
        }

    }
}
