namespace AddDataBaseForProject.DbStuff.Models;

public class User : BaseModel
{
    public string Name { get; set; }
    
    public string SurName { get; set; }
    
    public int Age { get; set; }
}