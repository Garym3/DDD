using DDD;
using System;
using DDD.Application.Entretien;
using DDD.Models.Entretien;
using DDD.Models.Entretien.Créneau;
using Xunit;

namespace DDDTest
{
    public class CréneauTests
    {
        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest1()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => new Créneau(new DateTime(2019, 4, 20, 7, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest2()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => new Créneau(new DateTime(2019, 4, 20, 22, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest3()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => new Créneau(new DateTime(2019, 4, 20, 20, 0, 0), 15));
        }

        [Fact]
        public void DoitRetournerUneDuréeHorsHeuresOuvréesExceptionTest4()
        {
            Assert.Throws<DuréeHorsHeuresOuvréesException>(() => new Créneau(new DateTime(2019, 4, 20, 19, 0, 0), 90));
        }
    }
}
