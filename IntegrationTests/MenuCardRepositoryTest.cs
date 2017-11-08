using System.Collections.Generic;
using BusinessLibrary;
using Models.Domain.Entities;
using Xunit;

namespace IntegrationTests
{
    public class MenuRepositoryTest : BaseIntegrationTest
    {

        [Fact]
        public void Given_MenuCardRepository_When_AddingAMenuCard_Then_TheMenuCardShouldBeProperlySaved()
        {
            RunOnDatabase(ctx => {
                //Arrange
                var repository = new MenuCardRepository(ctx);
                var menuCard = MenuCard.Create("descriere originala", new List<Menu>() , false);

                //Act
                repository.Add(menuCard);

                //Assert
                var menus = repository.GetAll();
                Assert.True(1 == menus.Count);
            });
        }
    }
}
