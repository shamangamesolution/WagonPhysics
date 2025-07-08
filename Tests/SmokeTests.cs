using System.Diagnostics;
using Contracts;
using Contracts.Models;
using Contracts.Operations.ApplyForce;
using Contracts.Operations.Create;
using Contracts.Operations.CreateWorld;
using Contracts.Operations.DestroyWorld;
using Contracts.Operations.StartSimulation;
using Core;
using NUnit.Framework;

namespace Tests;

[TestFixture]
public class SmokeTests
{
    [Test]
    public async Task SmokeTest1()
    {
        using (var wagon = new WagonPhysicsCore())
        {
            //create world
            var createWorldResult = wagon.CreateWorld(new CreateWorldContext());
            Assert.IsTrue(createWorldResult.IsSuccess);
            var worldId = createWorldResult.WorldId;
            //create capsules
            var createCapsuleResult1 =
                wagon.BodyRepositoryApi.CreateCapsule(new CreateCapsuleContext(worldId));
            var createCapsuleResult2 =
                wagon.BodyRepositoryApi.CreateCapsule(new CreateCapsuleContext(worldId));
            Assert.IsTrue(createCapsuleResult1.IsSuccess);
            Assert.IsTrue(createCapsuleResult2.IsSuccess);
            //start simulation
            var startSimulationResult = wagon.SimulationController.StartSimulation(new StartSimulationContext(worldId)
            {
                TicksPerSecond = 60
            });
            Assert.IsTrue(startSimulationResult.IsSuccess);
            //apply force to first capsule
            var appyForceResult = wagon.ForceApplier.ApplyForce(new ApplyForceContext(worldId)
            {
                Direction = new WagonVector3D(1, 1, 1),
                Position = new WagonVector3D(0, 0, 0),
                BodyId = createCapsuleResult1.Body.Id
            });
            Assert.IsTrue(appyForceResult.IsSuccess);
            var tickReached = false;
            //register post tick handler
            var handlerId = wagon.TickProvider.AddPostWorldTickHandler(worldId, context =>
            {
                if (context.TickNo == 10)
                {
                    tickReached = true;
                    //check capsules positions
                }
            });
            //wait for tick to check capsule1 position
            var sw = new Stopwatch();
            sw.Start();
            while (!tickReached)
            {
                if (sw.ElapsedMilliseconds > 5000)
                    break;
            }
            Assert.IsTrue(tickReached);
            //remove handler
            wagon.TickProvider.RemoveHandler(handlerId);
            //destroy world
            await wagon.DestroyWorldAsync(new DestroyWorldContext(worldId));
        }
    }
}