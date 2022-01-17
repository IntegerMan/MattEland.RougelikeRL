using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MattEland.RoguelikeRL.Logic;
using NUnit.Framework;
using Shouldly;

namespace MattEland.RoguelikeRL.Tests;

[TestFixture]
public class NetworkPosTests
{
    [Test]
    public void NetworkPosConstructorSetsPosition()
    {
        // Arrange

        // Act
        NetworkPos networkPos = new(4, 2);

        // Assert
        networkPos.X.ShouldBe(4);
        networkPos.Y.ShouldBe(2);
    }

    [Test]
    public void AdjustNetworkPosShouldResultInCorrectPos()
    {
        // Arrange
        NetworkPos pos = new(1, 3);

        // Act
        NetworkPos result = pos.AdjustPosition(2, 5);

        // Assert
        result.X.ShouldBe(3);
        result.Y.ShouldBe(8);
    }

    [TestCase(1, 5)]
    public void NetworkPosEquality(int x, int y)
    {
        // Arrange
        NetworkPos pos1 = new(x, y);
        NetworkPos pos2 = new(x, y);

        // Act

        // Assert
        pos1.ShouldBe(pos2);
        pos2.ShouldBe(pos1);
    }
}