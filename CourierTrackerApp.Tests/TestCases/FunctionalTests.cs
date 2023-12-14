using CourierTrackerApp.DAL.Interrfaces;
using CourierTrackerApp.DAL.Services;
using CourierTrackerApp.DAL.Services.Repository;
using CourierTrackerApp.Models;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CourierTrackerApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ICourierTrackerService _CourierService;
        public readonly Mock<ICourierTrackerRepository> Courierservice = new Mock<ICourierTrackerRepository>();

        private readonly Courier _Courier;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _CourierService = new CourierTrackerService(Courierservice.Object);
            _output = output;

            _Courier = new Courier
            {
                Id = 1,
                TrackingNumber = "1234",
                Destination = "Mumbai",
                LastUpdated = DateTime.Now,
                Status = "Pending"
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Courier()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repos => repos.CreateCourier(_Courier)).ReturnsAsync(_Courier);
                var result = await _CourierService.CreateCourier(_Courier);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Courier()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repos => repos.UpdateCourier(_Courier)).ReturnsAsync(_Courier);
                var result = await _CourierService.UpdateCourier(_Courier);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetCourierById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repos => repos.GetCourierById(id)).ReturnsAsync(_Courier);
                var result = await _CourierService.GetCourierById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteCourierById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repos => repos.DeleteCourierById(id)).ReturnsAsync(response);
                var result = await _CourierService.DeleteCourierById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}