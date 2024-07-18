using CqrsMediatRFluentValidation.Notifications;
using MediatR;

namespace CqrsMediatRFluentValidation.Handlers;

public class EmailHandler : INotificationHandler<ProductAddedNotifications>
{

    private readonly FakeDataStore _fakeDataStore;
    public EmailHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task Handle(ProductAddedNotifications notification, CancellationToken cancellationToken)
    {
        await _fakeDataStore.EventOccured(notification.Product, "Email sent");
        await Task.CompletedTask;
    }
}

