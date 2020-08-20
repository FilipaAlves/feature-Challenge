using BombChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static BombChallenge.Bomb;

namespace BombChallengeTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Add_Sucess_Input_Returns_Sucess_BombState()
        {
            string input = "branco, vermelho, verde, branco";
            BombOutputVM bomb = ProcessBombDisarm(input);

            int expectedStateId = 0;
            int responseStateId = bomb.BombState;

            Assert.AreEqual(expectedStateId, responseStateId);
        }

        [TestMethod]
        public void Add_NeedToCute_Input_Returns_AnotherHire_BombState()
        {
            string input = "vermelho";
            BombOutputVM bomb = ProcessBombDisarm(input);

            int expectedStateId = 2;
            int responseStateId = bomb.BombState;

            Assert.AreEqual(expectedStateId, responseStateId);
        }

        [TestMethod]
        public void Add_WithErrorSyntax_Input_Returns_Error_BombState_And_SyntaxOfError()
        {
            string input = "branco, vermelho, amarelo, verde, branco";
            BombOutputVM bomb = ProcessBombDisarm(input);

            int expectedStateId = 3;
            int responseStateId = bomb.BombState;

            string expectedSyntax = "amarelo";
            string responseSyntax = bomb.IncorretInput;

            Assert.AreEqual(expectedStateId, responseStateId);
            Assert.AreEqual(expectedSyntax, responseSyntax);
        }

        [TestMethod]
        public void Add_Error_Input_Returns_Expload_BombState()
        {

            string input = "branco, laranja, verde, preto";
            BombOutputVM bomb = ProcessBombDisarm(input);

            int expectedStateId = 1;
            int responseStateId = bomb.BombState;
            Assert.AreEqual(expectedStateId, responseStateId);
        }

        [TestMethod]
        public void Add_Upper_Sucess_Input_Returns_Sucess_BombState()
        {

            string input = "BRANCO, VERMELHO, verde, branco";
            BombOutputVM bomb = ProcessBombDisarm(input);

            int expectedStateId = 0;
            int responseStateId = bomb.BombState;

            Assert.AreEqual(expectedStateId, responseStateId);
        }

        [TestMethod]
        public void Add_ManySpace_Sucess_Input_Return_Sucess_BombState()
        {

            string input = "branco       ,          verde, branco        ";
            BombOutputVM bomb = ProcessBombDisarm(input);

            int expectedStateId = 0;
            int responseStateId = bomb.BombState;

            Assert.AreEqual(expectedStateId, responseStateId);
        }
    }
}
