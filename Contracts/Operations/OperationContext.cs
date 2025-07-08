namespace Contracts.Operations;

public class OperationContext
{
    public Guid WorldId { get; set; }

    public OperationContext(Guid worldId)
    {
        WorldId = worldId;
    }
}