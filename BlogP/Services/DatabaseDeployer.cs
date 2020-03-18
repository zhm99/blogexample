using BlogP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogP.Services
{
    public class DatabaseDeployer
    {
        private BlogPContext _context;

        public DatabaseDeployer(BlogPContext context)
        {
            _context = context;
        }

        public void Migrate()
        {
            _context.Database.Migrate();
        }
    }
}
