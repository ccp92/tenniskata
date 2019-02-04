using Newtonsoft.Json.Bson;
using NUnit.Framework;
using TennisKata;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlayerOneHasNoPoints()
        {
            var game = new Game();
            Assert.AreEqual(game.PlayerOneScore(), "Love");
        }

        [Test]
        public void PlayerTwoHasNoPoints()
        {
            var game = new Game();
            Assert.AreEqual(game.PlayerTwoScore(), "Love");
        }

        [Test]
        public void CurrentScoreShouldBeLoveLove()
        {
            var game = new Game();
            Assert.AreEqual(game.CurrentScore(), "Love: Love");
        }
    }
}