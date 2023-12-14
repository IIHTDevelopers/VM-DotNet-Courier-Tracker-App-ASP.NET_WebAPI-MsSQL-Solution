
using CourierTrackerApp.DAL.Interrfaces;
using CourierTrackerApp.DAL.Services;
using CourierTrackerApp.DAL.Services.Repository;
using CourierTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CourierTrackerApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ICourierTrackerService _CourierService;
        public readonly Mock<ICourierTrackerRepository> Courierservice = new Mock<ICourierTrackerRepository>();

        private readonly Courier _Courier;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _CourierService = new CourierTrackerService(Courierservice.Object);

            _output = output;

            _Courier = new Courier
            {
                Id= 1,
                TrackingNumber="1234",
                Destination="Mumbai",
                LastUpdated= DateTime.Now,
                Status="Pending"
            };
        }

        [Fact]
        public async Task<bool> Testfor_TrackingNumber_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repo => repo.CreateCourier(_Courier)).ReturnsAsync(_Courier);
                var result = await _CourierService.CreateCourier(_Courier);
                var actualLength = _Courier.TrackingNumber.ToString().Length;
                if (result.TrackingNumber.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_CourierId_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repo => repo.CreateCourier(_Courier)).ReturnsAsync(_Courier);
                var result = await _CourierService.CreateCourier(_Courier);
                var actualLength = _Courier.Id.ToString().Length;
                if (result.Id.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_CourierDate_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repo => repo.CreateCourier(_Courier)).ReturnsAsync(_Courier);
                var result = await _CourierService.CreateCourier(_Courier);
                var actualLength = _Courier.LastUpdated.ToString().Length;
                if (result.LastUpdated.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Destination_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Courierservice.Setup(repo => repo.CreateCourier(_Courier)).ReturnsAsync(_Courier);
                var result = await _CourierService.CreateCourier(_Courier);
                var actualLength = _Courier.Destination.ToString().Length;
                if (result.Destination.ToString().Length == actualLength)
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