using Microsoft.EntityFrameworkCore;

namespace CertMaker5000.Screens.Interfaces
{
    interface IGetConnectionStringUI
    {
        string GetConnectionString();
        //DbContextOptions<DataContext> GetDbContextOptions();
        DbContextOptionsBuilder BuildOptions(DbContextOptionsBuilder builder);
    }
}