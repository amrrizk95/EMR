using EMR.Domain;

namespace EMR.Services.Interfaces
{
	public interface IPatientRegistery
	{
		Patient FindPatient(string patientIdentityNo);
		void AddPatient(Patient patient);
	}
}
