using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LearningDiaryLP_ASP.Models;

namespace LearningDiaryLP_ASP.Data
{
    public class LearningDiaryLP_ASPContext : DbContext
    {
        public LearningDiaryLP_ASPContext (DbContextOptions<LearningDiaryLP_ASPContext> options)
            : base(options)
        {
        }

        public DbSet<LearningDiaryLP_ASP.Models.Topic> Topic { get; set; }
    }
}
