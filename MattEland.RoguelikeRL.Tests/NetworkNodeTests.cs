﻿using MattEland.RoguelikeRL.Models;
using MattEland.RoguelikeRL.Models.Networks;
using NUnit.Framework;
using Shouldly;

namespace MattEland.RoguelikeRL.Tests;

[TestFixture]
public sealed class NetworkNodeTests
{
    [Test]
    public void NetworkNodesShouldDefaultToUnknownName()
    {
        // Arrange

        // Act
        NetworkNode node = new();

        // Assert
        node.Name.ShouldBe("Unknown");
    }

    [Test]
    public void NetworkNodesShouldRespectNameParameter()
    {
        // Arrange
        const string name = "Test Node";

        // Act
        NetworkNode node = new(name);

        // Assert
        node.Name.ShouldBe(name);
    }


    [Test]
    public void NetworkNodesShouldRespectPositionParameter()
    {
        // Arrange
        NetworkPos pos = new(7, 2);

        // Act
        NetworkNode node = new("Doesn't matter", pos);

        // Assert
        node.Position.ShouldBe(pos);
    }
}