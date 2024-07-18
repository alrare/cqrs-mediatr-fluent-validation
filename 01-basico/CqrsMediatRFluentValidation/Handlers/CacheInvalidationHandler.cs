
using CqrsMediatRFluentValidation.Notifications;
using MediatR;

namespace CqrsMediatRFluentValidation.Handlers;

public class CacheInvalidationHandler : INotificationHandler<ProductAddedNotifications>
{

    private readonly FakeDataStore _fakeDataStore;
    public CacheInvalidationHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task Handle(ProductAddedNotifications notification, CancellationToken cancellationToken)
    {
        await _fakeDataStore.EventOccured(notification.Product, "Cache invalidated");
        await Task.CompletedTask;
    }
}

