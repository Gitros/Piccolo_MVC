using Piccolo.DataAccess.Data;
using Piccolo.DataAccess.Repository.IRepository;
using Piccolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Piccolo.DataAccess.Repository
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
    {
        private ApplicationDbContext _db;

        public ProductTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductType obj)
        {
            _db.ProductTypes.Update(obj);
        }
    }
}
