using Contracts.Models;

namespace Contracts.Operations.Create;

public class CreateBodyResult : OperationResult
{
    public WagonBody Body { get; set; }
}