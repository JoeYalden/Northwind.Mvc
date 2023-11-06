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
            builder.UserID = "tlevel-joey";
            builder.Password = "zvww3r1zk()()7";
            builder.TrustServerCertificate = true;
            builder.MultipleActiveResultSets = true;
            builder.CommandTimeout = 3;
            string? connection = builder.ConnectionString;
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
