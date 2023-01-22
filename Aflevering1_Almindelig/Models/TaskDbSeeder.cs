using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace Aflevering1_Almindelig.Models
{
    public class TaskDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new TaskDbContext(serviceProvider.GetRequiredService<DbContextOptions<TaskDbContext>>());

            if(context.Tasks.Any())
            {
                return;
            }
            context.Tasks.AddRange(
                new Task
                {
                    Id = 1,
                    TaskName = "Agurker",
                    Quantity = 2,
                    IsComplete = false
                },

                new Task
                {
                    Id = 2,
                    TaskName = "Tomater",
                    Quantity = 5,
                    IsComplete = false
                }
            );
            context.SaveChanges();
        }
    }
}
