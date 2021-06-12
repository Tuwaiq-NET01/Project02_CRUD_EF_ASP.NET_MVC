using animeik.Controllers;
using animeik.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestProject1.Controllers
{
    [TestFixture]
    public class AnimeControllerTest
    {
        [Test]
        public void UintTestIndex()
        {
            AnimeController co = new AnimeController(new AppDbContext(new DbContextOptions<AppDbContext>()));
            ViewResult viewResultObj = co.Index(0) as ViewResult;
            Assert.AreEqual("Index", viewResultObj.ViewName);
        }
    }
}