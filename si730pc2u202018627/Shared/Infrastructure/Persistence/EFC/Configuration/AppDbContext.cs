using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using si730pc2u202018627.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

namespace si730pc2u202018627.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

       /* builder.Entity<FavoriteSource>().ToTable("FavoriteSources");
        builder.Entity<FavoriteSource>().HasKey(f => f.Id);
        builder.Entity<FavoriteSource>().Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<FavoriteSource>().Property(f => f.NewsApiKey).IsRequired();
        builder.Entity<FavoriteSource>().Property(f => f.SourceId).IsRequired();
        builder.UseSnakeCaseNamingConvention();
        
        
        builder.Entity<EducationalResource>().ToTable("EducationalResources");
        builder.Entity<EducationalResource>().HasKey(f => f.Id);
        builder.Entity<EducationalResource>().Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<EducationalResource>().Property(f => f.Title).IsRequired();
        builder.Entity<EducationalResource>().Property(f => f.Author).IsRequired();
        builder.Entity<EducationalResource>().Property(f => f.ContentType).IsRequired();
        builder.Entity<EducationalResource>().Property(f => f.VideoUrl).IsRequired();
        builder.UseSnakeCaseNamingConvention();
        
        builder.Entity<LegalCase.Domain.Model.LegalCase>().ToTable("LegalCases");
        builder.Entity<LegalCase.Domain.Model.LegalCase>().HasKey(l => l.Id);
        builder.Entity<LegalCase.Domain.Model.LegalCase>().Property(l => l.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<LegalCase.Domain.Model.LegalCase>().Property(l => l.CaseNumber).IsRequired();
        builder.Entity<LegalCase.Domain.Model.LegalCase>().Property(l => l.Description).IsRequired();
        builder.Entity<LegalCase.Domain.Model.LegalCase>().Property(l => l.Status).IsRequired();
        // Apply SnakeCase Naming Convention
        builder.UseSnakeCaseNamingConvention();*/
        
    }
}