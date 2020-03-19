using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Twinkle", LastName = "Humperdink" },
                new Friend { FirstName = "Jaque", LastName = "Perrie" },
                new Friend { FirstName = "Alastar", LastName = "Guy" },
                new Friend { FirstName = "Jill", LastName = "Valentine" }
                );
        }
    }
}
