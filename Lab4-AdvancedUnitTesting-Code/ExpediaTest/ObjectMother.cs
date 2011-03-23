    using Expedia;
using System;

namespace ExpediaTest
{
	public class ObjectMother
	{
        public static Car Saab()
        {
            return new Car(7) { Name = "Saab 9-5 Sports Sedan" };
        }
        public static Car BMW()
        {
            return new Car(10) { Name = "Big Mexican Woman" };
        }
        public static Flight FlightToSingapore()
        {
            DateTime startDate = new DateTime(1997,1,1);
            DateTime endDate = new DateTime(2000,3,6);
            return new Flight(startDate, endDate,1000);
        }
        public static Flight FlightToChicago()
        {
            DateTime startDate = new DateTime(2000, 1, 1);
            DateTime endDate = new DateTime(2010, 3, 6);
            return new Flight(startDate, endDate, 20);
        }
	}
}
