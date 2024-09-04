using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using BankAPI.Models;

namespace BankAPI.DBO
{
    public class DataBaseConnection: DbContext
    {
        public DbSet<BankModel> Banks { get; set; }
        public DataBaseConnection(DbContextOptions<DataBaseConnection> options):base(options)
        {
			try
			{
                var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if(dbCreator != null)
                {
                    if (!dbCreator.CanConnect())
                        dbCreator.Create();
                    if(!dbCreator.HasTables())
                        dbCreator.CreateTables();
                }
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
        }
    }
}
