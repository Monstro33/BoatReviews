//using BoatReviews.Controllers;
//using BoatReviews.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Xunit;

//namespace BoatReviews.Tests
//{
//    public class BoatControllerTests
//    {
//        public BoatController underTest;
//        public BoatControllerTests()
//        {
//            underTest = new BoatController();
//        }

//        [Fact]
//        public void Index_Returns_A_View_Result()
//        {
//            var result = underTest.Index();
//            Assert.IsType<ViewResult>(result);
//        }
//        [Fact]
//        public void Index_Model_Has_3_Boats()
//        {
//            var result = underTest.Index();
//            var model = (IEnumerable<Boat>)result.Model;
//            Assert.Equal(3, model.Count());
//        }
//        [Fact]
//        public void Details_Model_Has_Correct_ID()
//        {
//            var expectedId = 2;
//            var result = underTest.Details(expectedId);
//            var model = (Boat)result.Model;
//            Assert.Equal(expectedId, model.Id);
//        }
//    }
//}
