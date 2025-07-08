using Contracts.Managers;
using Contracts.Operations.CreateWorld;
using Contracts.Operations.DestroyWorld;

namespace Contracts;

public interface IWagonPhysicsCore
{
    //create our beautiful world
    CreateWorldResult CreateWorld(CreateWorldContext createWorldContext);
    Task<DestroyWorldResult> DestroyWorldAsync(DestroyWorldContext destroyWorldContext);

    //get object to control simulation
    ISimulationController SimulationController { get; }
    //get object to operate bodies
    IBodyRepositoryApi BodyRepositoryApi { get; }
    //get object to get body snapshots
    IBodySnapshotProvider BodySnapshotProvider { get; }
    //get object to register some handlers on collisions
    ICollisionEventsProvider CollisionEventsProvider { get; }
    //get object to register some handlers for world ticks
    IWorldTickEventsProvider TickProvider { get; }
    //apply some force
    IForceApplier ForceApplier { get; }
}

