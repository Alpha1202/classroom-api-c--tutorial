using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using classroom_api_c__tutorial.Models;

namespace classroom_api_c__tutorial.Data
{
    public static class SeedData
    {
        public static void Initialize(StudentContext context)
        {
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student
                    {
                        Name = "Kyle XY",
                        Age = 16
                    },
                    new Student
                    {
                        Name = "Superman",
                        Age = 17
                    }
                );

                context.SaveChanges();
            }
        }
    }
}