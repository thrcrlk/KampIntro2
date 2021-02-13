using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

using Microsoft.EntityFrameworkCore;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarServiceManager carServiceManager = new CarServiceManager(new EfCarDal());
            
         
            //foreach (var item in carService.GetAll())
            //{
            //    Console.WriteLine(item.CarId+"   "+item.BrandId+"    "+item.ColorId+"    "+item.DailyPrice+"    "+item.Description);
            //}


        }
    }
}
