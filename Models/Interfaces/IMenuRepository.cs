using System;
using System.Collections.Generic;
using System.Text;
using Models.Domain.Entities;

namespace Models.Domain.Interfaces
{
    public interface IMenuRepository
    {
        IReadOnlyList<Menu> GetAll();
        Menu GetById(Guid id);
        void Add(Menu todo);
        void Edit(Menu todo);
        void Delete(Guid id);
    }
}
