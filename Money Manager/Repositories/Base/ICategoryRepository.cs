using Money_Manager.Models;
using System.Collections;
using System.Collections.Generic;

namespace Money_Manager.Repositories.Base
{
    public interface ICategoryRepository
    {
        public void CreateCategory(Category category);
        public IEnumerable<Category> GetIncomeCategories();
        public IEnumerable<Category> GetExpensesCategories();
        public IEnumerable<Category> GetAllCategories();
        public void DeleteCategory(int categoryId);
    }
}
