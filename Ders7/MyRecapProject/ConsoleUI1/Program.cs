using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new ICarServiceManager(new InMemoryCarDal());

            carService.GetAll();
                
                    
        }
    }
}
