using EMR.Domain;
using EMR.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EMR.Services
{
	public class PatientRegistery : IPatientRegistery
	{
		private readonly ApplicationDbContext _db;
		public PatientRegistery(ApplicationDbContext db)
        {
            _db = db;
        }
        public Patient FindPatient(string patientIdentityNo)
		{
            var query = $"SELECT * FROM Patients WHERE IdentityNo = '{patientIdentityNo}'";
            var patient =  _db.Patients.FromSqlRaw(query).FirstOrDefault();
			return patient;
		}

		public void AddPatient(Patient patient)
		{
			if (!IsUniqueIdentityNo(patient.IdentityNo))
			{
				throw new ArgumentException($"Identity No {patient.IdentityNo} is already exist");
			}
			_db.Patients.Add(patient);
			_db.SaveChanges();
		}

		private bool IsUniqueIdentityNo(string identityNo)
		{
			return !_db.Patients.Any(p => p.IdentityNo==identityNo);
		}

	}
}
