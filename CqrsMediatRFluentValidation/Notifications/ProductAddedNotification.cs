using MediatR;

namespace CqrsMediatRFluentValidation.Notifications
{
    public record ProductAddedNotifications(Product Product) : INotification
    {

    }

}
