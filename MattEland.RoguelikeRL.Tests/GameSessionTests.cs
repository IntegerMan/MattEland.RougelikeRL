using System;
using MattEland.RoguelikeRL.Models;
using NUnit.Framework;
using Shouldly;

namespace MattEland.RoguelikeRL.Tests;

public sealed class GameSessionTests
{
    [Test]
    public void GameSessionsShouldStartInTheActiveState()
    {
        // Arrange

        // Act
        GameSession session = new();

        // Assert
        session.Status.ShouldBe(SessionStatus.Active);
    }

    [Test]
    public void GameSessionShouldHaveANetwork()
    {
        // Arrange

        // Act
        GameSession session = new();

        // Assert
        session.ActiveNetwork.ShouldNotBeNull();
    }

    [Test]
    public void GameSessionShouldHaveNetworkNodes()
    {
        // Arrange

        // Act
        GameSession session = new();

        // Assert
        session.ActiveNetwork.NumNodes.ShouldBeGreaterThan(0);
    }
}