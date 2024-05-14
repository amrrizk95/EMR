using EMR.Domain;
using EMR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Tests
{
	public class PatientRegisteryTest
	{
		[Fact]
		public void AddPatient_WhenIdentityNoIsUnique_PatientShouldBeAdded()
		{
			//Arrang
			var dbContext=new InMemoryDbContext();
			var sut = new PatientRegistery(dbContext);
			var patient = new Patient
			{
				Name="Amr Rizk",
				IdentityNo="12345",
				
			};
			//Act
			sut.AddPatient(patient);
			//Assert
			Assert.True(patient.Id > 0);
		}
	}
}
