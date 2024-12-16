using System.Collections.Generic;
using System.ServiceModel;

/// <summary>
/// Summary description for IECommerceService
/// </summary>
[ServiceContract]
public interface IECommerceService
{
    #region CategoriesSection

    /// <summary>
    /// Method that returns all categories
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    List<Category> GetAllCategories();

    /// <summary>
    /// Method that returns a specific category
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [OperationContract]
    Category GetCategoryById(int id);

    /// <summary>
    /// Method that creates a new category
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    [OperationContract]
    bool AddCategory(Category category);

    /// <summary>
    /// Method that updates the information of a category
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    [OperationContract]
    bool UpdateCategory(Category category);

    /// <summary>
    /// Method that deletes a category
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [OperationContract]
    bool DeleteCategory(int id);

    #endregion

    #region ClientsSection

    /// <summary>
    /// Method that returns all clients
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    List<Costumer> GetAllClients();

    /// <summary>
    /// Method that returns a specific costumer
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [OperationContract]
    Costumer GetCostumerById(int id);

    /// <summary>
    /// Method that creates a new costumer
    /// </summary>
    /// <param name="costumer"></param>
    /// <returns></returns>
    [OperationContract]
    bool AddCostumer(Costumer costumer);

    /// <summary>
    /// Method that updates the information of a costumer
    /// </summary>
    /// <param name="costumer"></param>
    /// <returns></returns>
    [OperationContract]
    bool UpdateCostumer(Costumer costumer);

    /// <summary>
    /// Method that deletes a costumer
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [OperationContract]
    bool DeleteCostumer(int id);

    /// <summary>
    /// Method that authenticates a costumer
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    [OperationContract]
    Costumer AuthenticateClient(string email, string password);

    #endregion

    #region OrdersSection

    #endregion

    #region OrdersDetailsSection

    #endregion

    #region ProductsSection

    /// <summary>
    /// Method that returns all products
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    List<Product> GetAllProducts();

    /// <summary>
    /// Method that returns a specific product
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [OperationContract]
    Product GetProductById(int id);

    /// <summary>
    /// Method that creates a new product
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    [OperationContract]
    bool AddProduct(Product product);

    /// <summary>
    /// Method that updates the information of a product
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    [OperationContract]
    bool UpdateProduct(Product product);

    /// <summary>
    /// Method that deletes a product
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [OperationContract]
    bool DeleteProduct(int id);

    #endregion
}