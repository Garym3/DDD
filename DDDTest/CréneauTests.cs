using DDD;
using System;
using DDD.Application.Entretien;
using DDD.Models.Entretien;
using DDD.Models.Entretien.Cr�neau;
using Xunit;

namespace DDDTest
{
    public class Cr�neauTests
    {
        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest1()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => new Cr�neau(new DateTime(2019, 4, 20, 7, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest2()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => new Cr�neau(new DateTime(2019, 4, 20, 22, 0, 0), 0));
        }

        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest3()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => new Cr�neau(new DateTime(2019, 4, 20, 20, 0, 0), 15));
        }

        [Fact]
        public void DoitRetournerUneDur�eHorsHeuresOuvr�esExceptionTest4()
        {
            Assert.Throws<Dur�eHorsHeuresOuvr�esException>(() => new Cr�neau(new DateTime(2019, 4, 20, 19, 0, 0), 90));
        }
    }
}
