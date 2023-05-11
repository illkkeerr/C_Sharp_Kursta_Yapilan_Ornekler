using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9_Example
{
    internal class OrderManager
    {
        //Product:IEntity
        /*
         name,
        category
        price

        //IEntity
        name

        //Person:IEntity
        name,
        surname

        Customer:Person
        name,
        soyad,
        List<Product> Products

        Worker:Person
        name,
        soyad,
        maaşı

        //Order-class
        Customer
        Worker
        TotalPrice

        //OrderManager
        List<Order> Orders
        Add
        Sil
         */
        public List<Order> Orders { get; set; }


        public OrderManager()
        {
            Orders=new List<Order>();
        }
    }
}
