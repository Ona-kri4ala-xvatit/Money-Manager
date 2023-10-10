using Microsoft.EntityFrameworkCore.ChangeTracking;
using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using System;

namespace Money_Manager.Repositories
{
    public class CategoryEFRepository : ICategoryRepository
    {
        private readonly MoneyManagerDbContext dbContext;

        public CategoryEFRepository(MoneyManagerDbContext moneyManagerDbContext) => this.dbContext = moneyManagerDbContext;
        public void CreateCategory(Category category)
        {
           dbContext.Categories.Add(category);
           dbContext.SaveChanges();
        }
    }
}
