using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;

namespace DeviceManagement_WebApp.InterfaceRepo
{
    public interface IZoneRepo : IGenericRepo<Zone>
    {
        Zone GetMostRecentZone();
    }
}
