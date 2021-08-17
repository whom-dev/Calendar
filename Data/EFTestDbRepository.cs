using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Data
{
    public class EFTestDbRepository : ITestDbRepository
    {
        public TestDbContext context;

        public EFTestDbRepository(TestDbContext ctx)
        {
            context = ctx;
        }

        //public IQueryable<model> model=>context.model;
    }
}
