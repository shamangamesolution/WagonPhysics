namespace Contracts.Operations.StartSimulation;

public class StartSimulationContext : OperationContext
{
    public int TicksPerSecond { get; set; }

    public StartSimulationContext(Guid worldId) : base(worldId)
    {
    }
}