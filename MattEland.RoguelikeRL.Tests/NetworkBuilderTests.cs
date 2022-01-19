using MattEland.RoguelikeRL.Models;
using NUnit.Framework;
using Shouldly;

namespace MattEland.RoguelikeRL.Tests;

[TestFixture]
public sealed class NetworkBuilderTests
{
    [Test]
    public void NetworkBuilderShouldGenerateNonEmptyNetwork()
    {
        // Arrange
        NetworkBuilder builder = new();

        // Act
        Network network = builder.BuildSampleLevel();

        // Assert
        network.ShouldNotBeNull();
        network.Nodes.ShouldNotBeEmpty();
    }
}