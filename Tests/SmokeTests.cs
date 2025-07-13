using System.Diagnostics;
using CaesarMath;
using Contracts;
using Contracts.Models;
using Contracts.Operations.ApplyForce;
using Contracts.Operations.Create;
using Contracts.Operations.CreateWorld;
using Contracts.Operations.DestroyWorld;
using Contracts.Operations.ForwardSimulation;
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
            //apply force to first capsule
            var appyForceResult = wagon.ForceApplier.ApplyForce(new ApplyForceContext(worldId)
            {
                Direction = new WagonVector3D(1, 1, 1),
                Position = new WagonVector3D(0, 0, 0),
                BodyId = createCapsuleResult1.Body.Id
            });
            Assert.IsTrue(appyForceResult.IsSuccess);
            //forward world to 1/6 sec
            var forwardResult = wagon.SimulationController.ForwardSimulation(new ForwardSimulationContext()
            {
                ForwardSec = (Fixed)1 / (Fixed)6
            });
            Assert.IsTrue(forwardResult.IsSuccess);
            //destroy world
            await wagon.DestroyWorldAsync(new DestroyWorldContext(worldId));
        }
    }
}