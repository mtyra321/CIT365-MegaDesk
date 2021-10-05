using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MegaDesk
{
    public class DeskQuote
    {
        Dictionary<String, int> materials =new Dictionary<string, int> 
        {
            { "Oak", 200 },
            { "Laminate", 100 },
            { "Pine", 50 },
            { "Rosewood", 300 },
            { "Veneer", 125 },
        };

        int totalCost;
        int surfaceAreaPrice;
        int shippingPrice;
        int drawerPrice;
        int materialPrice;
        String customerName;
        int productionTime;
        Desk desk;
        DateTime date;

        public int TotalCost { get => totalCost; set => totalCost = value; }
        public int SurfaceAreaPrice { get => surfaceAreaPrice; set => surfaceAreaPrice = value; }
        public int ShippingPrice { get => shippingPrice; set => shippingPrice = value; }
        public int DrawerPrice { get => drawerPrice; set => drawerPrice = value; }
        public int MaterialPrice { get => materialPrice; set => materialPrice = value; }
        public DateTime Date { get => date; set => date = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public int ProductionTime { get => productionTime; set => productionTime = value; }
        public Desk Desk { get => desk; set => desk = value; }

        public DeskQuote(Desk desk, int prodTime, String name)
        {
            this.desk = desk;
            materials.TryGetValue(desk.SurfaceMaterial, out materialPrice);
            productionTime = prodTime;
            customerName = name;
            date = DateTime.Now;
        }

        [Newtonsoft.Json.JsonConstructor]
        public DeskQuote(int totalCost, int surfaceAreaPrice, int shippingPrice, int drawerPrice, int materialPrice, DateTime datetime, string name, int productionTime, Desk desk)
        {
            this.totalCost = totalCost;
            this.surfaceAreaPrice = surfaceAreaPrice;
            this.shippingPrice = shippingPrice;
            this.drawerPrice = drawerPrice;
            this.materialPrice = materialPrice;
            this.date = datetime;
            customerName = name;
            this.productionTime = productionTime;
            this.desk = desk;
            
        }

        private int calcShippingPrice()
        {
            string[] pricesString = File.ReadAllLines(@"rushOrder.txt", Encoding.UTF8);
            int[] shippingPricesList = new int[pricesString.Length];
            for (int i = 0; i < pricesString.Length; i++)
                shippingPricesList[i] = Convert.ToInt32(pricesString[i]);

            switch (productionTime)
            {
                case 3:
                    if(desk.SurfaceArea < 1000)
                    {
                        return shippingPricesList[0];
                    }
                    else if (desk.SurfaceArea < 2000)
                    {
                        return shippingPricesList[1];
                    }
                    else
                    {
                        return shippingPricesList[2];
                    }
                case 5:
                    if (desk.SurfaceArea < 1000)
                    {
                        return shippingPricesList[3];
                    }
                    else if (desk.SurfaceArea < 2000)
                    {
                        return shippingPricesList[4];
                    }
                    else
                    {
                        return shippingPricesList[5];
                    }

                case 7:
                    if (desk.SurfaceArea < 1000)
                    {
                        return shippingPricesList[6];
                    }
                    else if (desk.SurfaceArea < 2000)
                    {
                        return shippingPricesList[7];
                    }
                    else
                    {
                        return shippingPricesList[8];
                    }
                default:
                    return 0;

            }
        }
        public void calcPrice()
        {
             shippingPrice= calcShippingPrice();
             drawerPrice= (50*desk.DrawerNum);
            if(desk.SurfaceArea > 1000)
            {
            surfaceAreaPrice = (1 * desk.SurfaceArea);

            }
            else
            {
                surfaceAreaPrice = 0;
            }
            totalCost= 200 + shippingPrice + drawerPrice + surfaceAreaPrice + materialPrice;
        }

    }
    //public enum ShippingTimes
    //{
    //    14,
    //    3,
    //    5,
    //    7
    //}
}
