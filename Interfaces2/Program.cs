using System;

namespace Interfaces2
{
    class Program
    {
        //5.gunOdev2
        //interface new'lenemez.
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Update(employeeManager);
            projectManager.Update(new CustomerManager());


            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    //inherits - class -----------------implements-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Calisan Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Calisan Guncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }

    }

}
