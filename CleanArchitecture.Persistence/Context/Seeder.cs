using AutoFixture;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CleanArchitecture.Persistence.Context;

public static class Seeder
{
    public static void Seed(this DataContext dataContext)
    {
        if (!dataContext.Airports.Any())
        {
            Fixture fixture = new Fixture();
            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            var airport = fixture.Create<Airport>();
            //fixture.Customize<Airport>(product => product.Without(p => p.Id));
            ////--- The next two lines add 100 rows to your database
            dataContext.Add(airport);
           
            dataContext.SaveChanges();
        }
    }
}