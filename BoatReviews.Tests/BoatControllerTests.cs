using BoatReviews.Controllers;
using BoatReviews.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System.Text;
using BoatReviews.Repositories;
using NSubstitute;

namespace BoatReviews.Tests
{
    public class BoatControllerTests
    {
        BoatController sut;
        private IBoatRepository repo;

        public BoatControllerTests()
        {
            repo = Substitute.For<IBoatRepository>();
            sut = new BoatController(repo);
        }

        [Fact]
        public void Index_Returns_View_Result()
        {
            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Boat>();
            repo.GetAll().Returns(expectedModel);

            var result = sut.Index();
            var model = (IEnumerable<Boat>)result.Model;

            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Boat();

            repo.GetById(expectedId).Returns(expectedModel);

            var result = sut.Details(expectedId);
            var model = (Boat)result.Model;
            Assert.Equal(expectedModel, model);
        }
    }
}
