using ClassLibrary_lab2.Models;

namespace TestProject_lab2
{
    public class LiczTest
    {
        private Licz licz;

        [SetUp]
        public void Setup()
        {
            licz = new Licz();
        }

        [Test]
        [TestCase()]

        public void ShouldCreateObject()
        {
            Assert.NotNull(licz);
        }

        public void Dodaj_Test(int i, int expect)
        {
            licz.Dodaj(5);
            Assert.AreEqual(5, licz.Value);
        }

    }
}
