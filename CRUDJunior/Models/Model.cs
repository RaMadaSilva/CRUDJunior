using Flunt.Notifications;

namespace CRUDJunior.Models
{
    public abstract class Model: Notifiable<Notification>
    {

        public int Id { get; set; }
    }
}
