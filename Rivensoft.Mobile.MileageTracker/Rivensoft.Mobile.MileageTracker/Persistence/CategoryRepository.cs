//-----------------------------------------------------------------------
// <copyright file="CategoryRepository.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoryRepository
    {
        public IEnumerable<Category> GetAll()
        {
            List<Category> categories = new List<Category>();

            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                var dbCategories = dataContext.Categories;

                foreach (var dbCategory in dbCategories)
                {
                    Category category =
                        new Category()
                        {
                            Id = dbCategory.Id,
                            Name = dbCategory.Name
                        };

                    categories.Add(category);
                }
            }

            return categories;
        }

        public Category GetById(int id)
        {
            Category category;

            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                CategoryLinqEntity dbCategory =
                    dataContext.Categories
                        .Where(j => j.Id == id)
                        .Single();

                // TODO: Make data adapter or use automapper?
                category = new Category()
                {
                    Id = dbCategory.Id,
                    Name = dbCategory.Name
                };
            }

            return category;
        }

        public void Insert(Category category)
        {
            CategoryLinqEntity categoryLinq = new CategoryLinqEntity()
            {
                Name = category.Name
            };

            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                dataContext.Categories.InsertOnSubmit(categoryLinq);

                dataContext.SubmitChanges();
            }
        }

        public void Update(Category category)
        {
            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                CategoryLinqEntity dbCategory =
                    dataContext.Categories
                        .Where(c => c.Id == category.Id)
                        .Single();

                dbCategory.Name = category.Name;

                dataContext.SubmitChanges();
            }
        }
    }
}
