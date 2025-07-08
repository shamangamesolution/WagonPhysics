using Contracts.Operations.ApplyForce;

namespace Contracts.Managers;

public interface IForceApplier
{
    ApplyForceResult ApplyForce(ApplyForceContext applyForceContext);
}