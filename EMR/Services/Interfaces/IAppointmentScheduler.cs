namespace EMR.Services.Interfaces
{
	public interface IAppointmentScheduler
	{
		public int Schedule(string identityNo, DateTime slot);
		
	}
}
