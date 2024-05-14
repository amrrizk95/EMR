using EMR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using EMR.Services.Interfaces;

namespace EMR.Tests
{
	public class AppointmentSchedulerTest
	{
		[Fact]
		public void Schedule_WhenPatientIsNotRegistered_ShouldThrownException()
		{
			// Arrang
			var patientRegistry = A.Fake<IPatientRegistery>();
			A.CallTo(()=>patientRegistry.FindPatient(A<string>.Ignored)).Returns(null);
			var sut = new AppointmentScheduler(patientRegistry);
			//Act && Assert
			Assert.Throws<ArgumentException>(() => sut.Schedule("1251", DateTime.Now));
		}

		[Fact]
		public void Schedule_WhenPatientIsRegistred_AppointmentShouldBeCreated()
		{
			// Arrang
			var patientRegistry = A.Fake<IPatientRegistery>();
			A.CallTo(() => patientRegistry.FindPatient(A<string>.Ignored)).Returns(new Domain.Patient());
			var sut = new AppointmentScheduler(patientRegistry);
			// Act
			var result=sut.Schedule("1251", DateTime.Now);
			// Assert
			Assert.True(result > 0);
		}
	}
}
