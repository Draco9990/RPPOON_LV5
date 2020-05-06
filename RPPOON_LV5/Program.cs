using System;
using System.Collections.Generic;

namespace RPPOON_LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak1();
            Zadatak2();
            Zadatak3();
            Zadatak4();
            Zadatak5();
            Zadatak6();
            Zadatak7();
        }

        public static void Zadatak1()
        {
            Console.WriteLine("Zadatak 1:");
            List<IShipable> itemList1 = new List<IShipable>();
            itemList1.Add(new Product("Item 1", 12, 4.5));
            itemList1.Add(new Product("Item 2", 15.5, 8));
            Box box1 = new Box("Box 1");
            foreach (IShipable item in itemList1)
            {
                box1.Add(item);
            }
            Console.WriteLine("Ukupna cijena: " + box1.Price);
            Console.WriteLine("Ukupna Kilaža: " + box1.Weight);
            Console.WriteLine("\n*****************************\n");
        }

        public static void Zadatak2()
        {
            Console.WriteLine("Zadatak 2:");
            List<IShipable> itemList1 = new List<IShipable>();
            itemList1.Add(new Product("Item 1", 12, 4.5));
            itemList1.Add(new Product("Item 2", 15.5, 8));
            Box box1 = new Box("Box 1");
            foreach (IShipable item in itemList1)
            {
                box1.Add(item);
            }
            ShippingService service1 = new ShippingService(2.33);
            Console.WriteLine("Cijena dostave: " + service1.GetDeliveryPrice(box1));
            Console.WriteLine("\n*****************************\n");
        }

        public static void Zadatak3()
        {
            Console.WriteLine("Zadatak 3:");
            DataConsolePrinter printer = new DataConsolePrinter();

            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset(@"C:\sensitiveData.csv");
            Console.WriteLine("Virtual Proxy Dataset test: ");
            printer.PrintDataset(virtualProxyDataset);

            User user1 = User.GenerateUser("Korisnik 1");
            User user2 = User.GenerateUser("Korisnik 2");
            ProtectionProxyDataset protectionProxyDataset1 = new ProtectionProxyDataset(user1);
            Console.WriteLine("Protection Proxy Dataset test sa ID 1:");
            printer.PrintDataset(protectionProxyDataset1);

            ProtectionProxyDataset protectionProxyDataset2 = new ProtectionProxyDataset(user2);
            Console.WriteLine("Protection Proxy Dataset test sa ID 2:");
            printer.PrintDataset(protectionProxyDataset2);

            Console.WriteLine("\n*****************************\n");
        }

        public static void Zadatak4()
        {
            Console.WriteLine("Zadatak 4:");
            DataConsolePrinter printer = new DataConsolePrinter();

            LoggingProxyDataset loggingProxyDataset = new LoggingProxyDataset(@"C:\sensitiveData.csv");
            Console.WriteLine("Logging Proxy Dataset test: ");
            printer.PrintDataset(loggingProxyDataset);

            Console.WriteLine("\n*****************************\n");
        }

        public static void Zadatak5()
        {
            Console.WriteLine("Zadatak 5:");
            ReminderNote reminderNote = new ReminderNote("Dovrsiti LV iz RPPOON", new PurpleTheme());
            reminderNote.Show();
            Console.WriteLine("\n*****************************\n");
        }

        public static void Zadatak6()
        {
            Console.WriteLine("Zadatak 6:");
            GroupNote noteGroup = new GroupNote("Rijesit ispit na loomenu", new LightTheme());
            noteGroup.AddUser("Marino");
            noteGroup.AddUser("Marin");
            noteGroup.AddUser("Mari");
            noteGroup.Show();
            GroupNote noteGroup2 = new GroupNote("Rijesit ispit na loomenu u vremenu druge grupe", new PurpleTheme());
            noteGroup2.AddUser("Mar");
            noteGroup2.AddUser("Ma");
            noteGroup2.AddUser("M");
            noteGroup2.Show();
            Console.WriteLine("\n*****************************\n");
        }

        public static void Zadatak7()
        {
            Console.WriteLine("Zadatak 7:");
            Note reminderNote = new ReminderNote("Dovrsiti LV iz RPPOON", new PurpleTheme());
            GroupNote noteGroup = new GroupNote("Rijesit ispit na loomenu", new LightTheme());
            noteGroup.AddUser("Marino");
            noteGroup.AddUser("Marin");
            noteGroup.AddUser("Mari");
            GroupNote noteGroup2 = new GroupNote("Rijesit ispit na loomenu u vremenu druge grupe", new PurpleTheme());
            noteGroup2.AddUser("Mar");
            noteGroup2.AddUser("Ma");
            noteGroup2.AddUser("M");

            /*Notebook notebook = new Notebook();
            notebook.AddNote(reminderNote,true);
            notebook.AddNote(noteGroup, true);
            notebook.AddNote(noteGroup2, true);
            notebook.Display();
            notebook.ChangeTheme(new PurpleTheme());
            notebook.Display();*/

            Notebook notebook2 = new Notebook(new LightTheme());
            notebook2.AddNote(reminderNote);
            notebook2.AddNote(noteGroup);
            notebook2.AddNote(noteGroup2);
            notebook2.Display();

            Console.WriteLine("\n*****************************\n");
        }
    }
}
