namespace EMR.Services
{
	public class BMICalculator
	{
		public double CalculateBMI(double heightInMeters,double weightInKilos)
		{
			if (weightInKilos==0||heightInMeters==0)
			{
				return 0;
			}
			return weightInKilos / (heightInMeters * heightInMeters);
		}
	}
}
