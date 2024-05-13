public class Inventory
{
    public  List<Item> myItems = new List<Item>();
     public Inventory()
     {
      Item item1 = new Item();
      item1.itemName="Sword";
      item1.attack =10;
      item1.health = 5;
      myItems.Add(item1);
      // 
      Item item2 = new Item();
      item2.itemName="Bow";
      item2.attack =20;
      item2.health = 10;
      myItems.Add(item2);
     //
      Item item3 = new Item();
      item3.itemName="Shield";
      item3.attack = 1;
      item3.health = 2;
     myItems.Add(item3);
     }  //
}