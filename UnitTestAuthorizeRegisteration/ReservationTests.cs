//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestAuthorizeRegisteration
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsOwner_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            reservation.MadeBy = new User()
            {
                IsAdmin = false
            };
            // Act
            var result = reservation.CanBeCancelledBy(reservation.MadeBy);

            // Assert
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            // Arrange
            var User = new User();
            User.IsAdmin = false;

            var reservation = new Reservation();
            reservation.MadeBy = User;

            // Act
            var result = reservation.CanBeCancelledBy(new User()
            {
                IsAdmin = false
            });

            // Assert
            Assert.That(result == false);
        }
    }
}
