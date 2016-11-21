using Microsoft.EntityFrameworkCore;
using NSubstitute;
using rabbitmq_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PersonCreatedListener.Tests
{
    public class Test_Listener
    {
        [Fact]
        public void PersonCreatedServices_receives_new_Person()
        {
            //Arrange
            var dbset = Substitute.For<DbSet<PersonCreated>>();
            var context = Substitute.For<IPersonCreatedContext>();
            context.Persons.Returns(dbset);

            var service = new PersonCreatedService(context);


            //Act
            service.Execute(new PersonCreated() {
                FirstName = "Klaas-Teake"
            });


            //Assert
            dbset.Received(1).Add(Arg.Any<PersonCreated>());

        }

        [Fact]
        public void PersonCreatedService_receives_new_Person_and_Saves_to_Database()
        {

        }

    }
}
