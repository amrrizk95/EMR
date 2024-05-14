using EMR.Domain;
using EMR.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {

        private readonly IPatientRegistery _patientRegistery;
        public PatientsController(IPatientRegistery patientRegistery)
        {
            _patientRegistery = patientRegistery;
        }

        [HttpGet("{identityNo}")]
        public Patient GetPatient(string identityNo)
        {
            return  _patientRegistery.FindPatient(identityNo);
        }

        [HttpPost]
        public IActionResult AddPatient(Patient patient)
        {
            _patientRegistery.AddPatient(patient);
            return Ok();
        }
    }
}
