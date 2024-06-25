using StoreShoes.DbStuff.Models;

namespace StoreShoes.DbStuff.Repositories;

public class ShoesRepositories : StoreBaseRepositories<Shoes>
{
    public ShoesRepositories(StoreDbContext storeDbContext) : base(storeDbContext) {}
}