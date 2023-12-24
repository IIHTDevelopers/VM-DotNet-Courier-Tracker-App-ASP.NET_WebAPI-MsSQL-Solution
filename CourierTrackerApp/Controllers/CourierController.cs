using CourierTrackerApp.DAL.Interrfaces;
using CourierTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CourierTrackerApp.Controllers
{
    public class CourierController : ApiController
    {
        private readonly ICourierTrackerService _service;
        public CourierController(ICourierTrackerService service)
        {
            _service = service;
        }
        public CourierController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Courier/CreateCourier")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateCourier([FromBody] Courier model)
        {
            var leaveExists = await _service.GetCourierById(model.Id);
            var result = await _service.CreateCourier(model);
            return Ok(new Response { Status = "Success", Message = "Courier created successfully!" });
        }


        [HttpPut]
        [Route("api/Courier/UpdateCourier")]
        public async Task<IHttpActionResult> UpdateCourier([FromBody] Courier model)
        {
            var result = await _service.UpdateCourier(model);
            return Ok(new Response { Status = "Success", Message = "Courier updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Courier/DeleteCourier")]
        public async Task<IHttpActionResult> DeleteCourier(long id)
        {
            var result = await _service.DeleteCourierById(id);
            return Ok(new Response { Status = "Success", Message = "Courier deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Courier/GetCourierById")]
        public async Task<IHttpActionResult> GetCourierById(long id)
        {
            var expense = await _service.GetCourierById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Courier/GetAllCouriers")]
        public async Task<IEnumerable<Courier>> GetAllCouriers()
        {
            return _service.GetAllCouriers();
        }
    }
}
