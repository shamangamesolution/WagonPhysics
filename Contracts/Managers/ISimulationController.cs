using Contracts.Operations.StartSimulation;
using Contracts.Operations.StopSimulation;

namespace Contracts.Managers;

public interface ISimulationController
{
    //simulation control
    StartSimulationResult StartSimulation(StartSimulationContext startSimulationContext);
    StopSimulationResult StopSimulation(StopSimulationContext stopSimulationContext);
}