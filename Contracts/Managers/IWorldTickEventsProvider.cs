using Contracts.Operations.WorldTicks;

namespace Contracts.Managers;

public interface IWorldTickEventsProvider
{
    Guid AddPreWorldTickHandler(Guid worldId, Action<PreWorldTickContext> handler);
    Guid AddPostWorldTickHandler(Guid worldId, Action<PostWorldTickContext> handler);
    void RemoveHandler(Guid handlerId);
}