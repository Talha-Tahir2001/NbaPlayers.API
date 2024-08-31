using Microsoft.EntityFrameworkCore;


namespace NbaPlayers.API.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<NbaPlayer> NbaPlayers => Set<NbaPlayer>(); 

    }
}
