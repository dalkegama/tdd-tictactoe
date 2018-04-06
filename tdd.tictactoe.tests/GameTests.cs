using NUnit.Framework;
using Shouldly;
using tdd.tictactoe.contracts;
using System;

namespace tdd.tictactoe.tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Play_ShouldImplementTheContract()
        {
            var game = new Game();

            (game is IGamePlay).ShouldBeTrue();
        }

        [TestCase(4, 5)]
        [TestCase(-1, -1)]
        [TestCase(0, -1)]
        public void Play_WithInvalidCoordinates_ShouldThrowException(int x, int y)
        {
            var game = new Game();

            Should.Throw<ArgumentException>(() => { game.Play(x, y, Player.O); });
        }

        [Test]
        public void Play_WithValidCoordinates_ShouldReflectTheState()
        {
            var game = new Game();

            game.Play(1, 1, Player.O);
            game.State().ShouldNotBeNull();
        }

        [Test]
        public void Play_PlayerShouldNotBeAbleToPlayTwiceInARow()
        {
            var game = new Game();

            game.Play(1, 1, Player.O);
            Should.Throw<ArgumentException>(() => { game.Play(0, 0, Player.O); });
        }

        [Test]
        public void Play_PlayerShouldNotBeAbleToPlaceASymbolAtTheSameLocation()
        {
            var game = new Game();
            game.Play(1, 1, Player.X);
            Should.Throw<ArgumentException>(() => { game.Play(1, 1, Player.O); });
        }
    }
}
