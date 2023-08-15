using Flunt.Notifications;

namespace CRUDJunior.Domain.Models
{
    public abstract class Model: Notifiable<Notification>
    {

        public int Id { get; set; }
    }
}
