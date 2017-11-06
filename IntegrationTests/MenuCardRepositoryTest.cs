using System;
using System.Collections.Generic;
using System.Text;
using BusinessLibrary;
using Models.Domain.Entities;
using Xunit;

namespace IntegrationTests
{
    [TestClass]
    public class MenuRepositoryTest : BaseIntegrationTest
    {

        [TestMethod]
        public void Given_TodoRepository_When_AddingATodo_Then_TheTodoShouldBeProperlySaved()
        {
            RunOnDatabase(ctx => {
                //Arrange
                var repository = new MenuCardRepository(ctx);
                var todo = MenuCard.Create("descriere originala", false, "titlu original");

                //Act
                repository.Add(todo);

                //Assert
                var todos = repository.GetAll();
                Assert.AreEqual(1, todos.Count);
            });
        }
    }
}
