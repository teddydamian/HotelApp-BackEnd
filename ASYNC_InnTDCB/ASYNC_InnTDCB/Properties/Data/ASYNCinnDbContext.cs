using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASYNC_InnTDCB.Properties.Data
{
    public class ASYNCinnDbContext : DbContext
    {
        public ASYNCinnDbContext(DbContextOptions<ASYNCinnDbContext> options) :base(options)
        {

        }
    }
}
