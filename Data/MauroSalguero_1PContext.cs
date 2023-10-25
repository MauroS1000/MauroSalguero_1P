using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MauroSalguero_1P.Models;

namespace MauroSalguero_1P.Data
{
    public class MauroSalguero_1PContext : DbContext
    {
        public MauroSalguero_1PContext (DbContextOptions<MauroSalguero_1PContext> options)
            : base(options)
        {
        }

        public DbSet<MauroSalguero_1P.Models.MauroSalguero_tabla> MauroSalguero_tabla { get; set; } = default!;
    }
}
