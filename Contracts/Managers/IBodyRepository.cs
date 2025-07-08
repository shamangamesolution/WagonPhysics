using Contracts.Operations.Create;
using Contracts.Operations.Delete;
using Contracts.Operations.Get;

namespace Contracts.Managers;

public interface IBodyRepository
{
    //body operations
    CreateBodyResult CreateBody(CreateBodyContext createBodyContext);
    DeleteBodyResult DeleteBody(DeleteBodyContext createBodyContext);
    GetBodyResult GetBody(GetBodyContext getBodyContext);   
}