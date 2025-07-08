using Contracts.Models;

namespace Contracts.Operations.ApplyForce;

public class ApplyForceContext : OperationContext
{
    public ApplyForceContext(Guid worldId) : base(worldId)
    {
    }

    public Guid BodyId { get; set; }
    public WagonVector3D Direction { get; set; } 
    public WagonVector3D Position { get; set; } 
}