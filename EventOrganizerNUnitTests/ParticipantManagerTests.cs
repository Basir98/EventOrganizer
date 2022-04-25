using EventOrganizer;
using NUnit.Framework;

namespace EventOrganizerNUnitTests
{
    public class ParticipantManagerTests
    {
        ParticipantManager participant_manager;

        [SetUp]
        public void Setup()
        {
            participant_manager = new ParticipantManager();
        }

        [Test]
        public void Participant_count_with_no_participant_test()
        {
            Assert.AreEqual(0, participant_manager.Count);
        }

        [Test]
        public void Participant_count_participant_test()
        {
            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            var participant = new Participant("User", "Test lastname", address);
            participant_manager.AddParticipant(participant);
            Assert.AreEqual(1, participant_manager.Count);
        }

        [Test]
        public void Participant_add_participant_test()
        {
            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            var participant = new Participant("User", "Test lastname", address);
            Assert.AreEqual(true, participant_manager.AddParticipant(participant));
        }

        [Test]
        public void Participant_get_all_participants_test()
        {
            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            var participant = new Participant("User", "Test lastname", address);
            participant_manager.AddParticipant(participant);

            Assert.AreEqual(1, participant_manager.GetAllParticipants().Count);
        }

        [Test]
        public void Participant_delete_participant_at_test()
        {
            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            var participant = new Participant("User", "Test lastname", address);
            participant_manager.AddParticipant(participant);

            Assert.AreEqual(true, participant_manager.DeleteParticipantAt(0));
            Assert.AreEqual(0, participant_manager.GetAllParticipants().Count);
        }

        [Test]
        public void Participant_delete_participant_with_no_participant_test()
        {
            Assert.AreEqual(false, participant_manager.DeleteParticipantAt(0));
        }
    }
}