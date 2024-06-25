using StoreShoes.DbStuff.Models;

namespace StoreShoes.Models.SneackersStore;

public class ShoesModel : BaseModel
{
    public string Name { get; set; }

    public int Size { get; set; }

    public int Price { get; set; }
    
    public string Production { get; set; }
    
    public string Review { get; set; }
}