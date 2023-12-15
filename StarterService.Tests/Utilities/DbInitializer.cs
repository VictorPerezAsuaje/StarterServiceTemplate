using Microsoft.EntityFrameworkCore;
using Services.Sample.Infrastructure;


namespace Services.Sample.Tests.Utilities;

internal class DbInitializer
{
    
    public static void SeedData(SampleDbContext context)
    {
        context.SaveChanges();
    }
}

