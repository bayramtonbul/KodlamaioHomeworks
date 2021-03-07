using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        //8.gunOdev2
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framewok -ORM- object relational mapping
            //NHibernate--ORM
            //Dapper

            //GetConstains();
            //GetByCategoryId(1);

            //efProductDalGetAll();

            //efProductDalGetById();

            NorthwindContext context = new NorthwindContext();

            foreach (var personel in context.Personels)
            {
                Console.WriteLine("{0}-{1} {2}",personel.Id,personel.Name,personel.Surname);
            }


            Console.ReadLine();
        }

        private static void efProductDalGetById()
        {
            EfProductDal efProductDal = new EfProductDal();
            Console.WriteLine(efProductDal.GetById(24).ProductName);
        }

        private static void efProductDalGetAll()
        {
            EfProductDal efProductDal = new EfProductDal();

            foreach (var product in efProductDal.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetConstains()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products.Where(p => p.ProductName.Contains("Perth")))
            {

                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetByCategoryId(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products.Where(p=>p.CategoryId==categoryId))
            {
                Console.WriteLine(product.ProductId+":"+product.ProductName);
            }

        }

    }
}
