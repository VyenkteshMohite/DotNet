namespace BLL;
using BOL;
using DAL;
using DAL.Connected;
//using DAL.DisConnected;
public class CatalogManager
{
    public List<Hobby> GetAllProducts()
    {
        List<Hobby> data = new List<Hobby>();
        data = DBManager.GetAllProducts();
        return data;
    }

    public Hobby GetHobbyById(int id){
        Hobby hb=DBManager.GetHobbyById(id);
        return hb;
    }
}