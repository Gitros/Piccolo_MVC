﻿using Piccolo.DataAccess.Data;
using Piccolo.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piccolo.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductTypeRepository ProductType { get; private set; }
        public IProductRepository Product { get; set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            ProductType = new ProductTypeRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
