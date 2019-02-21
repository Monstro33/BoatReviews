using BoatReviews.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BoatReviews.Tests
{
    public class BoatControllerTests
    {
        public BoatController underTest;
        public BoatControllerTests()
        {
            underTest = new BoatController();
        }
    
        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
