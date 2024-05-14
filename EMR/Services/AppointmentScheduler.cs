using EMR.Services.Interfaces;

namespace EMR.Services
{
	public class AppointmentScheduler : IAppointmentScheduler
	{
		private readonly IPatientRegistery _patientRegistery;
        public AppointmentScheduler(IPatientRegistery patientRegistery)
        {
			_patientRegistery = patientRegistery;

		}
        public int Schedule(string identityNo, DateTime slot)
		{
			var patient=_patientRegistery.FindPatient(identityNo);
			if (patient == null)
			{
				throw new ArgumentException($"Patient with identityNo {identityNo} not registered");
			}
				return Random.Shared.Next(1,1000);
		}
	}
}
