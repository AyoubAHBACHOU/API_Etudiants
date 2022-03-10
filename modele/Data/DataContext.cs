using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modele.Models;
namespace modele.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Etudiant> etudiants { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
