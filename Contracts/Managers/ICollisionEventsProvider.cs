using Contracts.Operations.Collision;

namespace Contracts.Managers;

public interface ICollisionEventsProvider
{
    Guid AddCollisionHandler(AddCollisionContext context, Func<CollisionContext, Task> handler);
    void RemoveHandler(Guid handlerId);
}