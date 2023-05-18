using Microsoft.EntityFrameworkCore;
using WellHeader.Entities;
using WellHeader.Models;

namespace WellHeader.DAL
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Well>().HasData(
                new Well
                { 
                    WellID = 1,
                    WellName = "My Sample Well #1",
                    APINumber = "42000011110000"
                }
            );
            //modelBuilder.Entity<Field>().HasData(
            //    new Field { FieldID = 1, FieldName = "Hamlet" },
            //    new Field { FieldID = 2, FieldName = "King Lear" },
            //    new Field { FieldID = 3, FieldName = "Othello" }
            //);
        }
    }
}
