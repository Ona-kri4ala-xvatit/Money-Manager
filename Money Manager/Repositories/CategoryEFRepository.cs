﻿using Money_Manager.Context;
using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Money_Manager.Repositories
{
    public class CategoryEFRepository : ICategoryRepository
    {
        private readonly MoneyManagerDbContext dbContext;

        public CategoryEFRepository(MoneyManagerDbContext moneyManagerDbContext)
        {
            if (dbContext is null)
                this.dbContext = new MoneyManagerDbContext();
            else
                dbContext = moneyManagerDbContext;
        }

        public void CreateCategory(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public IEnumerable<Category> GetExpensesCategories()
        {
            return dbContext.Categories.Where(t => t.TransactionType == Services.TransactionType.Expenses);
        }

        public IEnumerable<Category> GetIncomeCategories()
        {
            return dbContext.Categories.Where(t => t.TransactionType == Services.TransactionType.Income);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return dbContext.Categories.ToList();
        }

        public void DeleteCategory(int categoryId)
        {
            var categoryToDelete = this.dbContext.Categories.FirstOrDefault(x => x.Id == categoryId);

            if (categoryToDelete != null)
            {
                this.dbContext.Categories.Remove(categoryToDelete);
                this.dbContext.SaveChanges();
            }
        }
    }
}
