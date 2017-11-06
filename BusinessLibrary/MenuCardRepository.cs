using System;
using System.Collections.Generic;
using System.Linq;
using Models.Domain.Entities;
using Models.Domain.Interfaces;
using Models.Persistence;

namespace BusinessLibrary
{
    public class MenuCardRepository : IMenuCardRepository
    {
        private readonly IDatabaseContext _databaseContext;

        public MenuCardRepository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IReadOnlyList<MenuCard> GetAll() => _databaseContext.MenuCards.ToList();

        public MenuCard GetById(Guid id) => _databaseContext.MenuCards.FirstOrDefault(menuCard => menuCard.Id == id);

        public void Add(MenuCard menuCard)
        {
            _databaseContext.MenuCards.Add(menuCard);
            _databaseContext.SaveChanges();
        }

        public void Edit(MenuCard menuCard)
        {
            _databaseContext.MenuCards.Update(menuCard);
            _databaseContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var menuCard = GetById(id);
            if (menuCard != null)
            {
                _databaseContext.MenuCards.Remove(menuCard);
                _databaseContext.SaveChanges();
            }
        }
    }
}
