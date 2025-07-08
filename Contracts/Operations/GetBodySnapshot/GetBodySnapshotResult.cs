using Contracts.Models;

namespace Contracts.Operations.GetBodySnapshot;

public class GetBodySnapshotResult : OperationResult
{
    public BodySnapshot BodySnapshot { get; set; }  
}