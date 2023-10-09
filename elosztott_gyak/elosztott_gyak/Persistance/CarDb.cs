using elosztott_gyak.Model;

namespace elosztott_gyak.Persistance
{
    public class CarDb
    {
        private List<Car> cars;

        private static CarDb instance;  

        private CarDb()
        {
            cars= new List<Car>();
        }

        public static CarDb GetInstance()
        {
            if(instance is null)
            {
                instance = new CarDb();
            }

            return instance;
        }

        public Car? GetCar(string licenseplate)
        {
            foreach(var car in cars)
            {
               if(car.LicensePlate == licenseplate)
                    return car;
            }
            return null;
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

    }
}
