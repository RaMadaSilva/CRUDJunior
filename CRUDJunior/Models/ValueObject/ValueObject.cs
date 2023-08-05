using Flunt.Notifications;

namespace CRUDJunior.Models.ValueObject
{
    public abstract class ValueObject : Notifiable<Notification>
    {
        public int Id { get; private set; }
    }
}
