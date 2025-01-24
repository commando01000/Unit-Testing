using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using TestNinja.Fundamentals;

namespace UnitTestAuthorizeRegisteration
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
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
            Assert.IsTrue(result);
        }

        [TestMethod]
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
            Assert.IsFalse(result);
        }
    }
}
