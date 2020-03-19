using System.Collections.Generic;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: load from a database
            yield return new Friend {FirstName = "Twinkle", LastName = "Humperdink"};
            yield return new Friend {FirstName = "Jaque", LastName = "Perrie"};
            yield return new Friend {FirstName = "Alastar", LastName = "Guy"};
            yield return new Friend {FirstName = "Jill", LastName = "Valentine"};
        }
    }
}
