using Dotnet_Rpg_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Dotnet_Rpg_Project.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base((DbContextOptions) options)
        {

        }
        public DbSet<Character> characters => Set<Character>();

    }
}
