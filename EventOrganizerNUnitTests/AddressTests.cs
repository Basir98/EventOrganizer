using EventOrganizer;
using NUnit.Framework;

namespace EventOrganizerNUnitTests
{
    class AddressTests
    {
        Address address;
        [SetUp]
        public void Setup()
        {
            address = new Address("Test street", "Test city", "11122", Countries.Sverige);
        }

        [Test]
        public void Address_city_test()
        {
            Assert.AreEqual("Test city", address.City);
        }

        [Test]
        public void Address_country_test()
        {
            Assert.AreEqual(Countries.Sverige, address.Country);
        }

        [Test]
        public void Address_street_test()
        {
            Assert.AreEqual("Test street", address.Street);
        }

        [Test]
        public void Address_ZipCode_test()
        {
            Assert.AreEqual("11122", address.ZipCode);
        }
    }
}
