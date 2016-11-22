using Xunit;
using NSubstitute;
using DeelnemerAPI.Models;
using DeelnemerDatabase;
using DeelnemerAPI.Services;
using DeelnemerAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace DeelnemerAPI.Tests
{
    public class DeelnemerControllerTests
    {
        [Fact]
        public void GetDeelnemerTest()
        {
            //Assert
            var context = Substitute.For<IDeelnemerContext>();
            var service = Substitute.For<IDeelnemerService>();
            var controller = new DeelnemerController(context, service);
            var dbSet = Substitute.For<DbSet<PersonCreated>>();

            context.Deelnemers.Returns(dbSet);

            //Act
            var result = controller.Get();

            //Assert
            Assert.Same(dbSet, result);
        }

        [Fact]
        public void UpdateDeelnemerTest()
        {
            //Assert
            var context = Substitute.For<IDeelnemerContext>();
            var service = Substitute.For<IDeelnemerService>();
            var controller = new DeelnemerController(context, service);
            var updatePerson = new UpdatePerson();

            //Act
            var result = controller.Put(updatePerson);

            //Assert
            service.Received().Execute(updatePerson);
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void AddDeelnemerTest()
        {
            //Assert
            var context = Substitute.For<IDeelnemerContext>();
            var service = Substitute.For<IDeelnemerService>();
            var controller = new DeelnemerController(context, service);
            var createPerson = new CreatePerson();

            //Act
            var result = controller.Post(createPerson);

            //Assert
            service.Received().Execute(createPerson);
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void DeleteDeelnemerTest()
        {
            //Assert
            var context = Substitute.For<IDeelnemerContext>();
            var service = Substitute.For<IDeelnemerService>();
            var controller = new DeelnemerController(context, service);
            var id = 1;

            //Act
            var result = controller.Delete(id);

            //Assert
            service.Received().Execute(Arg.Is<DeletePerson>(x => x.Id == id));
            Assert.IsType<OkResult>(result);
        }


    }
}
