using Contracts.Operations.GetBodySnapshot;

namespace Contracts.Managers;

public interface IBodySnapshotProvider
{
    GetBodySnapshotResult GetBodySnapshot(GetBodySnapshotContext getBodySnapshotContext);
}