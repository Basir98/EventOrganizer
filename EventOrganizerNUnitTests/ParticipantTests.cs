using EventOrganizer;
using NUnit.Framework;

namespace EventOrganizerNUnitTests
{
    public class ParticipantTests
    {
        Participant participant;

        [SetUp]
        public void Setup()
        {
            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            participant = new Participant("User", "Test lastname", address);
        }

        [Test]
        public void Participant_address_test()
        {
            Assert.AreEqual("Test", participant.Address.Street);
            Assert.AreEqual("Test city", participant.Address.City);
            Assert.AreEqual("11122", participant.Address.ZipCode);
        }

        [Test]
        public void Participant_first_name_test()
        {
            Assert.AreEqual("User", participant.FirstName);
        }

        [Test]
        public void Participant_last_name_test()
        {
            Assert.AreEqual("Test lastname", participant.LastName);
        }

        [Test]
        public void Participant_full_name_test()
        {
            Assert.AreEqual("User, Test lastname", participant.FullName);
        }
    }
}