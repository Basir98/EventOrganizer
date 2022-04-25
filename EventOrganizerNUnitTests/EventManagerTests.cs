using EventOrganizer;
using NUnit.Framework;

namespace EventOrganizerNUnitTests
{
    class EventManagerTests
    {
        EventManager eventManager;
        [SetUp]
        public void Setup()
        {
            eventManager = new EventManager();
        }

        [Test]
        public void EventManager_CostPerPerson_with_no_input_test()
        {
            Assert.AreEqual(0, eventManager.CostPerPerson);
        }

        [Test]
        public void EventManager_CostPerPerson_test()
        {
            eventManager.CostPerPerson = 100;
            Assert.AreEqual(100, eventManager.CostPerPerson);
        }

        [Test]
        public void EventManager_FeePerPerson_with_no_input_test()
        {
            Assert.AreEqual(0, eventManager.FeePerPerson);
        }

        [Test]
        public void EventManager_FeePerPerson_test()
        {
            eventManager.FeePerPerson = 100;
            Assert.AreEqual(100, eventManager.FeePerPerson);
        }

        [Test]
        public void EventManager_Title_with_no_input_test()
        {
            Assert.AreEqual(null, eventManager.Title);
        }

        [Test]
        public void EventManager_Title_test()
        {
            eventManager.Title = "Title test";
            Assert.AreEqual("Title test", eventManager.Title);
        }

        [Test]
        public void EventManager_numberOfParticipants_with_no_input_test()
        {
            Assert.AreEqual(0, eventManager.numberOfParticipants());
        }

        [Test]
        public void EventManager_numberOfParticipants_test()
        {
            ParticipantManager participant_manager = new ParticipantManager();

            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            var participant = new Participant("User", "Test lastname", address);
            participant_manager.AddParticipant(participant);

            eventManager = new EventManager(participant_manager);

            Assert.AreEqual(1, eventManager.numberOfParticipants());
        }

        [Test]
        public void EventManager_CalcTotalCost_with_no_input_test()
        {
            Assert.AreEqual(0.0, eventManager.CalcTotalCost());
        }

        [Test]
        public void EventManager_CalcTotalCost_test()
        {
            ParticipantManager participant_manager = new ParticipantManager();
            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            var participant = new Participant("User", "Test lastname", address);
            participant_manager.AddParticipant(participant);

            eventManager = new EventManager(participant_manager);
            eventManager.CostPerPerson = 100;

            Assert.AreEqual(100.0, eventManager.CalcTotalCost());
        }

        [Test]
        public void EventManager_CalcTotalFees_with_no_input_test()
        {
            Assert.AreEqual(0.0, eventManager.CalcTotalFees());
        }

        [Test]
        public void EventManager_CalcTotalFees_test()
        {
            ParticipantManager participant_manager = new ParticipantManager();
            var address = new Address("Test", "Test city", "11122", Countries.Sverige);
            var participant = new Participant("User", "Test lastname", address);
            participant_manager.AddParticipant(participant);

            eventManager = new EventManager(participant_manager);
            eventManager.FeePerPerson = 100;

            Assert.AreEqual(100.0, eventManager.CalcTotalFees());
        }
    }
}
