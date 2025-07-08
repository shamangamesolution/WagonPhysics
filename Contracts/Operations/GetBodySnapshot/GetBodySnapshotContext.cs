namespace Contracts.Operations.GetBodySnapshot;

public class GetBodySnapshotContext : OperationContext
{
    public GetBodySnapshotContext(Guid worldId) : base(worldId)
    {
    }

    public Guid BodyId { get; set; }
    public int TickNo { get; set; }
}