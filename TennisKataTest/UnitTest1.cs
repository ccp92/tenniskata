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

        public class GivenANewGame
        {
            private readonly Game _game = new Game();
            
            [Test]
            public void PlayerOneHasNoPoints()
            {
                Assert.AreEqual(_game.PlayerOneScore(), "Love");
            }

            [Test]
            public void PlayerTwoHasNoPoints()
            {
                Assert.AreEqual(_game.PlayerTwoScore(), "Love");
            }

            [Test]
            public void CurrentScoreShouldBeLoveLove()
            {
                Assert.AreEqual(_game.CurrentScore(), "Love: Love");
            }
        }
    }
}