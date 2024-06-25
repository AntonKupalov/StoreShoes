using Microsoft.EntityFrameworkCore;
using StoreShoes.DbStuff.Models;

namespace StoreShoes.DbStuff.Repositories;

public abstract class StoreBaseRepositories<DbModel> where DbModel : BaseModel
{
    protected readonly DbSet<DbModel> _entites;
    protected readonly DbContext _storeDbContext;

    protected StoreBaseRepositories(DbContext dbContext)
    {
        _entites = dbContext.Set<DbModel>();
        _storeDbContext = dbContext;
    }

    public virtual int Add(DbModel dbModel)
    {
        _entites.Add(dbModel);
        _storeDbContext.SaveChanges();
        return dbModel.Id;
    }

    public virtual void Remove(int id)
    {
        var removeDbModel = _entites.First(dbModel => dbModel.Id == id);
        _entites.Remove(removeDbModel);
        _storeDbContext.SaveChanges();
    }

    public virtual DbModel Get(int id)
    {
        var getDbModel = _entites.SingleOrDefault(ddbModel => ddbModel.Id == id);
        return getDbModel;
    }

    public virtual List<DbModel> GetAll()
    {
        return _entites.ToList();
    }
}