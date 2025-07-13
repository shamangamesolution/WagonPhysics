using Contracts.Operations.ForwardSimulation;
using Contracts.Operations.RewindSimulation;

namespace Contracts.Managers;

public interface ISimulationController
{
    //simulation control
    ForwardSimulationResult ForwardSimulation(ForwardSimulationContext startSimulationContext);
    RewindSimulationResult RewindSimulation(RewindSimulationContext stopSimulationContext);
}