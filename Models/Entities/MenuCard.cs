using System;
using System.Collections.Generic;
using EnsureThat;

namespace Models.Domain.Entities
{
    public class MenuCard
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public List<Menu> Menus { get; private set; }
        public bool IsComplete { get; private set; }

        private MenuCard()
        {
            
        }

        public static MenuCard Create(string title, List<Menu> menus, bool isComplete)
        {
            Ensure.That(title).IsNotNullOrEmpty();
            Ensure.That(isComplete).IsFalse();
            var instance = new MenuCard { Id = Guid.NewGuid() };
            instance.Update(title, menus, isComplete);
            return instance;
        }

        public void Update(string title, List<Menu> menus, bool isComplete)
        {
            Ensure.That(title).IsNotNullOrEmpty();
            Title = title;
            Menus = menus;
            IsComplete = isComplete;
        }

        
    }
}