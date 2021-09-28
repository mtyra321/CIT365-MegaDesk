using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DeskQuote(Desk desk, int prodTime, String name)
        {
            this.desk = desk;
             materials.TryGetValue(desk.SurfaceMaterial, out materialPrice);
            productionTime = prodTime;
            customerName = name;
            date = DateTime.Now;
        }


        private int calcShippingPrice()
        {
        
            switch (productionTime)
            {
                case 3:
                    if(desk.SurfaceArea < 1000)
                    {
                        return 60;
                    }
                    else if (desk.SurfaceArea < 2000)
                    {
                        return 70;
                    }
                    else
                    {
                        return 80;
                    }
                case 5:
                    if (desk.SurfaceArea < 1000)
                    {
                        return 40;
                    }
                    else if (desk.SurfaceArea < 2000)
                    {
                        return 50;
                    }
                    else
                    {
                        return 60;
                    }

                case 7:
                    if (desk.SurfaceArea < 1000)
                    {
                        return 30;
                    }
                    else if (desk.SurfaceArea < 2000)
                    {
                        return 35;
                    }
                    else
                    {
                        return 40;
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
            totalCost= 200 + shippingPrice + drawerPrice + surfaceAreaPrice;
        }
    }
}
