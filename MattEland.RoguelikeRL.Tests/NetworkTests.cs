using System;
using MattEland.RoguelikeRL.Logic;
using NUnit.Framework;
using Shouldly;

namespace MattEland.RoguelikeRL.Tests;

public sealed class NetworkTests
{
    [Test]
    public void NetworksShouldStartEmpty()
    {
        // Arrange
        Network network = new();

        // Act
        var nodes = network.Nodes;

        // Assert
        nodes.ShouldBeEmpty();
        network.NumNodes.ShouldBe(0);
    }

    [Test]
    public void AddingANodeShouldIncreaseNodeCount()
    {
        // Arrange
        Network network = new();
        NetworkNode node = new();

        // Act
        network.Add(node);

        // Assert
        network.NumNodes.ShouldBe(1);
    }

    [Test]
    public void AddingAnEmptyNodeShouldError()
    {
        // Arrange
        Network net = new();

        // Act / Assert
        Should.Throw<ArgumentNullException>(() => net.Add(null!));
    }
}