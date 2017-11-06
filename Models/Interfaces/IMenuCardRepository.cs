using System;
using System.Collections.Generic;
using System.Text;
using Models.Domain.Entities;

namespace Models.Domain.Interfaces
{
    public interface IMenuCardRepository
    {
        IReadOnlyList<MenuCard> GetAll();
        MenuCard GetById(Guid id);
        void Add(MenuCard todo);
        void Edit(MenuCard todo);
        void Delete(Guid id);
    }
}
