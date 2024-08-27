using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppBoostrap_Juan.Models;

namespace WebAppBoostrap_Juan.Data
{
    public class WebAppBoostrap_JuanContext : DbContext
    {
        public WebAppBoostrap_JuanContext (DbContextOptions<WebAppBoostrap_JuanContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppBoostrap_Juan.Models.Aluno> Aluno { get; set; }

        public DbSet<WebAppBoostrap_Juan.Models.Logradouro> Logradouro { get; set; }
    }
}
