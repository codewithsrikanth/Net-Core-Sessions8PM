using System;

namespace CADelegates
{
    //Custom Delegate
    public delegate void NotificationHandler(string msg);
    class OrderService
    {
        public void PlaceOrder(int orderId,decimal amount)
        {
            Console.WriteLine($"Order {orderId} placed successfully");
            Console.WriteLine($"Order amount is: {amount:C}");
        }
        public void SendEmail(string msg)
        {
            Console.WriteLine($"Email: {msg}");
        }
        public void SendSMS(string msg)
        {
            Console.WriteLine($"SMS: {msg}");
        }
        public void SendWatsapp(string msg)
        {
            Console.WriteLine($"Watsapp: {msg}");
        }
        public void NotifyCustomer(string msg, NotificationHandler notificationHandler)
        {
            notificationHandler(msg);
        }
    }
    class Example1
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            orderService.PlaceOrder(101, 5000);

            NotificationHandler notification;

            notification = orderService.SendEmail;
            notification("Your order has been shipped");

            notification = orderService.SendSMS;
            notification("Your Order has been delivered");


            orderService.NotifyCustomer("Your order has been delivered", orderService.SendSMS);

            //Multicast delegate
            NotificationHandler handler;
            handler = orderService.SendEmail;
            handler += orderService.SendSMS;
            handler += orderService.SendWatsapp;
            handler("Your order successfully Delivered");
        }
    }
}
