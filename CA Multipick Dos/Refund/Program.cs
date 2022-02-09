using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Refund.com.channeladvisor.api;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace Refund
{


    class Program
    {



        static void Main(string[] args)
        {

        start:
            Console.Clear();

            APICredentials cred = new APICredentials();
            cred.DeveloperKey = "2476c33f-a06b-41f7-8af3-3f337bbfdca6";
            cred.Password = "kennyb15";


            OrderService svc = new OrderService();
            svc.APICredentialsValue = cred;

            string location = null;

            string SKU = null;

            string titlez = null;

            int Quantity = 0;

            int orderz = 0;

            List<int> lineids = new List<int>();


            List<int> lnumbers = new List<int>();


            List<string> mydata = new List<string>();

            Console.WriteLine("Enter Order For Picking Type 777 to Start Picking");



        sexy:

            string ordernum = Console.ReadLine();





            if (ordernum == "777")
            {
                goto supa;
            }

            int cum = Convert.ToInt32(ordernum);

            lnumbers.Add(cum);



            goto sexy;



        supa:

            

            int[] balls = lnumbers.ToArray();

        

          

            OrderCriteria criteria = new OrderCriteria();          
            criteria.OrderIDList = balls;
            criteria.DetailLevel = "High";
            criteria.PageSize = 50;


            APIResultOfArrayOfOrderResponseItem response0 = svc.GetOrderList("afe6a7ba-dd0c-4292-827d-4385fba66ae2", criteria);
            APIResultOfArrayOfOrderResponseItem response1 = svc.GetOrderList("4d779e61-a9d6-4e63-815d-fd7094b230a3", criteria);
            APIResultOfArrayOfOrderResponseItem response2 = svc.GetOrderList("c90abf9f-feae-40e7-b560-3eb97e104250", criteria);







            
          

            foreach (OrderResponseItem order in response0.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse title in highOrder.ShoppingCart.LineItemSKUList)

                    
                    mydata.Add(title.WarehouseLocation);
                   
            }

            foreach (OrderResponseItem order in response1.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse title in highOrder.ShoppingCart.LineItemSKUList)

                    
                    mydata.Add(title.WarehouseLocation);

            }

            foreach (OrderResponseItem order in response2.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse title in highOrder.ShoppingCart.LineItemSKUList)


                    mydata.Add(title.WarehouseLocation);

            }

            foreach (OrderResponseItem order in response0.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse poop in highOrder.ShoppingCart.LineItemSKUList)

                    lineids.Add(poop.LineItemID);

                    
            }

            foreach (OrderResponseItem order in response1.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse poop in highOrder.ShoppingCart.LineItemSKUList)

                    lineids.Add(poop.LineItemID);

            }

            foreach (OrderResponseItem order in response2.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse poop in highOrder.ShoppingCart.LineItemSKUList)

                    lineids.Add(poop.LineItemID);

            }

            
            

            string[] pimp = mydata.ToArray();
            int[] pimp2 = lineids.ToArray();

            int masterlength = pimp.Length - 1;

            string[] pimp3 = pimp2.Select(x => x.ToString()).ToArray();

            string[] pimp4 = new string[pimp.Length];

            int i = 0;

            thetip:

          


                pimp4[i] = pimp[i] + " " + pimp3[i];

            if (i == pimp.Length -1)
            {
                goto cumps;
            }
            

            i++;
            goto thetip;


        cumps:

            string[] smear = new string[pimp.Length];
            
            Array.Sort(pimp4);

        for (int l = 0; l < pimp4.Length; l++)
        {
            smear[l] = Strings.Right(pimp4[l], 7);
        }

        

        int[] values = new int[smear.Length];

        for (int x = 0; x < smear.Length; x++)
        {

            values[x] = Convert.ToInt32(smear[x].ToString());

        }



        int m = 0;


            dupes:

        try
        {

            foreach (OrderResponseItem order in response0.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse poop in highOrder.ShoppingCart.LineItemSKUList)

                    if (poop.LineItemID == values[m])
                    {
                        SKU = poop.SKU;
                        location = poop.WarehouseLocation;
                        titlez = poop.Title;
                        Quantity = poop.Quantity;
                        orderz = order.OrderID;
                    }

            }
            foreach (OrderResponseItem order in response1.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse poop in highOrder.ShoppingCart.LineItemSKUList)

                    if (poop.LineItemID == values[m])
                    {
                        SKU = poop.SKU;
                        location = poop.WarehouseLocation;
                        titlez = poop.Title;
                        Quantity = poop.Quantity;
                        orderz = order.OrderID;
                    }

            }
            foreach (OrderResponseItem order in response2.ResultData)
            {
                OrderResponseDetailHigh highOrder = order as OrderResponseDetailHigh;

                foreach (OrderLineItemItemResponse poop in highOrder.ShoppingCart.LineItemSKUList)

                    if (poop.LineItemID == values[m])
                    {
                        SKU = poop.SKU;
                        location = poop.WarehouseLocation;
                        titlez = poop.Title;
                        Quantity = poop.Quantity;
                        orderz = order.OrderID;
                    }

            }
        }

        catch
        {
            Console.WriteLine("You Are Done Pulling the Multiples");
            Console.ReadLine();
            Environment.Exit(0);
        }

            int index1 = Array.FindIndex(balls, item => item == orderz);

        Console.WriteLine(SKU);
        Console.WriteLine(location);
        Console.WriteLine(titlez);
        Console.WriteLine(Quantity);
        Console.WriteLine("Bin " + index1);

                Console.ReadLine();
                Console.Clear();

                m++;
                goto dupes;
        }





        }
    }

