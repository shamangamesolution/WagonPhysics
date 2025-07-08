namespace Contracts.Operations.DestroyWorld;

public class DestroyWorldContext : OperationContext
{
    public DestroyWorldContext(Guid worldId) : base(worldId)
    {
    }
}