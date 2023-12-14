using CourierTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CourierTrackerApp.DAL.Services.Repository
{
    public class CourierTrackerRepository : ICourierTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public CourierTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Courier> CreateCourier(Courier courier)
        {
            try
            {
                var result = _dbContext.Couriers.Add(courier);
                await _dbContext.SaveChangesAsync();
                return courier;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteCourierById(long id)
        {
            try
            {
                _dbContext.Couriers.Remove(_dbContext.Couriers.Single(a => a.Id == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Courier> GetAllCouriers()
        {
            try
            {
                var result = _dbContext.Couriers.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Courier> GetCourierById(long id)
        {
            try
            {
                return await _dbContext.Couriers.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }       

        public async Task<Courier> UpdateCourier(Courier model)
        {
            var ex = await _dbContext.Couriers.FindAsync(model.Id);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}