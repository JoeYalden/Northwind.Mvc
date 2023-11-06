namespace Packt.Shared
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Data.SqlClient;
    public class NorthwindContext: DbContext
    {
        public NorthwindContext() { }
            public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }
        
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            SqlConnectionStringBuilder builder = new();
            builder.DataSource = ".";
            builder.InitialCatalog = "Northwind";
            builder.IntegratedSecurity = false;
            builder.UserID = "jkoe";
            builder.Password = "password";
            builder.TrustServerCertificate = true;
            builder.MultipleActiveResultSets = true;
            builder.CommandTimeout = 3;
            string? connection = builder.ConnectionString;
        }
    }
}
