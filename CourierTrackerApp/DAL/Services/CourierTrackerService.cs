using CourierTrackerApp.DAL.Interrfaces;
using CourierTrackerApp.DAL.Services.Repository;
using CourierTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CourierTrackerApp.DAL.Services
{
    public class CourierTrackerService : ICourierTrackerService
    {
        private readonly ICourierTrackerRepository _repository;

        public CourierTrackerService(ICourierTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Courier> CreateCourier(Courier courier)
        {
            return _repository.CreateCourier(courier);
        }

        public Task<bool> DeleteCourierById(long id)
        {
            return _repository.DeleteCourierById(id);
        }

        public List<Courier> GetAllCouriers()
        {
            return _repository.GetAllCouriers();
        }

        public Task<Courier> GetCourierById(long id)
        {
            return _repository.GetCourierById(id);
        }

        public Task<Courier> UpdateCourier(Courier model)
        {
            return _repository.UpdateCourier(model);
        }
    }
}