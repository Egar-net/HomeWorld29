using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    internal class Trade
    {
        public int money { get; set; }

        public enum TraderInventory
        {
            ApplePie = 9,
            El = 3,
            SweetRoll = 6,
            NordsHoney = 8,
            Book = 3,
            Scroll = 1,
            Weapon = 15,
            Armor = 4
        }

        public void Buy()
        {
            Console.WriteLine("У торговца есть:");
            TraderInventory[] traderItems = (TraderInventory[])Enum.GetValues(typeof(TraderInventory));

            for (int i = 0; i < traderItems.Length; i++)
            {
                Console.WriteLine($"{i + 1} {traderItems[i]}: {traderItems[i].GetQuantity()}");
            }

            Console.WriteLine("Выберите номер предмета, чтобы купить:");
            int itemIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (itemIndex >= 0 && itemIndex < traderItems.Length)
            {
                TraderInventory selectedTraderItem = traderItems[itemIndex];
                int itemPrice = selectedTraderItem.GetPrice();

                if (money >= itemPrice)
                {
                    money -= itemPrice;
                    selectedTraderItem.DecreaseQuantity();
                    Console.WriteLine($"Вы купили {selectedTraderItem} за {itemPrice} золотых монет.");
                }
                else
                {
                    Console.WriteLine("Недостаточно денег для покупки.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный номер предмета.");
            }
        }

        public enum InventoryItem
        {
            ApplePie = 2,
            El = 10,
            SweetRoll = 3,
            NordsHoney = 5,
            Book = 0,
            Scroll = 0,
            Weapon = 0,
            Armor = 0
        }

        public void Sell()
        {
            Console.WriteLine("У вас есть:");
            InventoryItem[] userItems = (InventoryItem[])Enum.GetValues(typeof(InventoryItem));

            for (int i = 0; i < userItems.Length; i++)
            {
                Console.WriteLine($"{i + 1} {userItems[i]}: {userItems[i].GetQuantity()}");
            }

            Console.WriteLine("Выберите номер предмета, чтобы продать:");
            int itemIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (itemIndex >= 0 && itemIndex < userItems.Length)
            {
                InventoryItem selectedUserItem = userItems[itemIndex];
                int itemPrice = selectedUserItem.GetPrice();

                selectedUserItem.DecreaseQuantity();
                money += itemPrice;
                Console.WriteLine($"Вы продали {selectedUserItem} за {itemPrice} золотых монет.");
            }
            else
            {
                Console.WriteLine("Некорректный номер предмета.");
            }
        }
    }

    public static class TradeExtensions
    {
        public static int GetQuantity(this Enum enumValue)
        {
            return Convert.ToInt32(enumValue);
        }

        public static int GetPrice(this Enum enumValue)
        {
            int quantity = enumValue.GetQuantity();
            return quantity > 0 ? quantity * 10 : 0; // Assuming each item costs 10 gold coins
        }

        public static void DecreaseQuantity(this Enum enumValue)
        {
            int quantity = enumValue.GetQuantity();
            enumValue = (Enum)Enum.ToObject(enumValue.GetType(), Math.Max(0, quantity - 1));
        }
    }
}

