using Contracts;
using Contracts.Managers;
using Contracts.Operations.CreateWorld;
using Contracts.Operations.DestroyWorld;

namespace Core;

public class WagonPhysicsCore : IWagonPhysicsCore,IDisposable
{
    public CreateWorldResult CreateWorld(CreateWorldContext createWorldContext)
    {
        throw new NotImplementedException();
    }

    public Task<DestroyWorldResult> DestroyWorldAsync(DestroyWorldContext destroyWorldContext)
    {
        throw new NotImplementedException();
    }

    public ISimulationController SimulationController { get; }
    public IBodyRepositoryApi BodyRepositoryApi { get; }
    public IBodySnapshotProvider BodySnapshotProvider { get; }  
    public ICollisionEventsProvider CollisionEventsProvider { get; }
    public IForceApplier ForceApplier { get; }

    public void Dispose()
    {
        // TODO release managed resources here
    }
}