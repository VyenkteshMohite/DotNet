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

    public Hobby GetProduct(int id)
    {
        List<Hobby> allProducts = GetAllProducts();
        //LINQ Query
        /* var product=from  p in allProducts
                      where p.ProductId ==id
                       select p  ;     
       */
        Hobby product = allProducts.Find((product) => product.hobbyid == id);
        return product;
    }
}