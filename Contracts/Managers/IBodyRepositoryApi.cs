using Contracts.Operations.Create;
using Contracts.Operations.Get;

namespace Contracts.Managers;

public interface IBodyRepositoryApi
{
    CreateBodyResult CreateCapsule(CreateCapsuleContext createCapsuleContext);
    CreateBodyResult CreateBox(CreateBoxContext createBoxContext);
}