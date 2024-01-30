﻿string command = Console.ReadLine();
List<Box> boxes = new List<Box>();

while (command != "end")
{
    string[] data = command.Split(" ");
    int serialNumber = int.Parse(data[0]);
    string itemName = data[1];
    int itemQuantity = int.Parse(data[2]);
    decimal itemPrice = decimal.Parse(data[3]);

    Item currentItem = new Item(itemName, itemPrice);
    Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

    boxes.Add(currentBox);
    command = Console.ReadLine();
}

boxes = boxes.OrderByDescending(box => box.BoxPrice).ToList();

foreach(Box box in boxes)
{
    Console.WriteLine($"{box.SerialNumber}");
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: " +
        $"{box.ItemQuantity}");
    Console.WriteLine($"-- ${box.BoxPrice:f2}");
}
public class Item
{
    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }

    public decimal Price { get; set; }
}

public class Box
{
    public Box(int serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        BoxPrice = item.Price * itemQuantity;
        
    }
    public int SerialNumber { get; set; }

    public Item Item { get; set; }
    public int ItemQuantity { get; set; }

    public decimal BoxPrice { get; set; }

}



