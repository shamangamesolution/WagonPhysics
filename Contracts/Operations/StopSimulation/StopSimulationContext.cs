namespace Contracts.Operations.StopSimulation;

public class StopSimulationContext : OperationContext
{
    public StopSimulationContext(Guid worldId) : base(worldId)
    {
    }
}