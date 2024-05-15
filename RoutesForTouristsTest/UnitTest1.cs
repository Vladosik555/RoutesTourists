using RoutesTourists;
using RoutesTourists.Classes;
namespace RoutesForTouristsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckingForNumbersInAWord()
        {
            bool actual = Examination.CheckLetter("abcd1");
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckingForThePresenceOfDigitsInAWordWithThePresenceOfADigit()
        {
            bool actual = Examination.CheckLetter("abcdSDGJJSDFBSD");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void CheckingThecorrectNumber()
        {
            bool actual = Examination.CheckPhoneNumber("89512349056");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void CheckingTheIncorrectNumber()
        {
            bool actual = Examination.CheckPhoneNumber("8955678912349056");
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void checkingTheNumberForLetters()
        {
            bool actual = Examination.CheckPhoneNumber("895123hhfhf49056");
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckingTheCorrectNumber()
        {
            bool actual = Examination.CheckNumber("5792305734894");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void CheckingTheInCorrectNumber()
        {
            bool actual = Examination.CheckNumber("5792gg305734894");
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ReturnsAStringWithOnlyNumbers()
        {
            string number = Examination.GetAllNumber("234325sdjvgsdjfosdjfo");
            string result = "234325";
            Assert.AreEqual(number, result);
        }
        [TestMethod]
        public void checkingCorrectMailUsingMask()
        {
            bool actual = Examination.CheckFormatMail("Masha04@list.ru");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IfTheUserWroteOnlyAMaskThenSuchMailWillNotWork()
        {
            bool actual = Examination.CheckFormatMail("@list.ru");
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void IfTheUserEntersAMaskAtTheBeginningThenSuchMailWillNotWork()
        {
            bool actual = Examination.CheckFormatMail("@list.ru.Masha");
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void HashedPasswordVerification()
        {
            Assert.AreEqual("050248cd2efad770e194ca0e12d44264", Hash.CalculateMD5Hash("1234a"));
        }
    }
}