using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System.Threading.Tasks;
using EF_Sqlite_IPoint_Problem.Data;

namespace EF_Sqlite_IPoint_Problem.Tests
{
    public class VenueTests
    {
        [Fact]
        public async Task Should_Create_New_Venue()
        {
            using (var connection = new SqliteConnection("DataSource=:memory:"))
            {
                connection.Open();

                var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection, x => x.UseNetTopologySuite()).Options;

                // ensure the database was created
                using (var context = new ApplicationDbContext(options))
                {
                    context.Database.EnsureCreated();
                }
            }
        }
    }
}
