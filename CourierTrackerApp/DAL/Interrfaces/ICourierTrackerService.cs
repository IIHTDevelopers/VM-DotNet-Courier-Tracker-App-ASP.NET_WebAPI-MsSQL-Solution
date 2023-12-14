using CourierTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierTrackerApp.DAL.Interrfaces
{
    public interface ICourierTrackerService
    {
        List<Courier> GetAllCouriers();
        Task<Courier> CreateCourier(Courier courier);
        Task<Courier> GetCourierById(long id);
        Task<bool> DeleteCourierById(long id);
        Task<Courier> UpdateCourier(Courier model);
    }
}
