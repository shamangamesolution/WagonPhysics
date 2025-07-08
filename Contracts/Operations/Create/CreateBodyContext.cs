namespace Contracts.Operations.Create;

public class CreateBodyContext : OperationContext
{
    public CreateBodyContext(Guid worldId) : base(worldId)
    {
    }
}

public class CreateCapsuleContext : CreateBodyContext
{
    public CreateCapsuleContext(Guid worldId) : base(worldId)
    {
    }
}

public class CreateBoxContext : CreateBodyContext
{
    public CreateBoxContext(Guid worldId) : base(worldId)
    {
    }
}