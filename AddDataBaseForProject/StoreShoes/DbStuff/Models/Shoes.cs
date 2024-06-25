namespace StoreShoes.DbStuff.Models;

public class Shoes : BaseModel
{
   public string Name { get; set; }
   
   public int Size { get; set; }
   
   public int Price { get; set; }
   
   public string Production { get; set; }
    
   public string Review { get; set; }
}