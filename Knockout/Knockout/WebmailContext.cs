using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Knockout.Models
{
    public class WebmailContext : DbContext
    {
        public WebmailContext (DbContextOptions<WebmailContext> options)
            : base(options)
        {
        }

        public DbSet<Email> Email { get; set; }
    }
}
