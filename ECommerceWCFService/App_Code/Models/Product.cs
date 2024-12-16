/// <summary>
/// Summary description for Product
/// </summary>
public class Product : IProduct
{
    #region Attributes

    /// <summary>
    /// Creation of the Product class atributes
    /// </summary>
    private int id; //
    private string name; //
    private string description; //
    private decimal unitPrice; //
    private int stock; //
    private int categoryID; //

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor
    /// </summary>
    public Product()
    {
        id = 0;
        name = string.Empty;
        description = string.Empty;
        unitPrice = 0;
        stock = 0;
        categoryID = 0;
    }

    /// <summary>
    /// Constructor passed by parameters
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="unitPrice"></param>
    /// <param name="stock"></param>
    /// <param name="categoryID"></param>
    public Product(int id, string name, string description, 
        decimal unitPrice, int stock, int categoryID)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.unitPrice = unitPrice;
        this.stock = stock;
        this.categoryID = categoryID;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Property related to the 'ID' attribute
    /// </summary>
    public int ID { get { return id; } set { id = value; } }

    /// <summary>
    /// Property related to the 'Name' attribute
    /// </summary>
    public string Name { get { return name; } set { name = value; } }

    /// <summary>
    /// Property related to the 'Description' attribute
    /// </summary>
    public string Description { get { return description; } set { description = value; } }

    /// <summary>
    /// Property related to the 'UnitPrice' attribute
    /// </summary>
    public decimal UnitPrice { get { return unitPrice; } set { unitPrice = value; } }

    /// <summary>
    /// Property related to the 'Stock' attribute
    /// </summary>
    public int Stock { get { return stock; } set { stock = value; } }

    /// <summary>
    /// Property related to the 'CategoryID' attribute
    /// </summary>
    public int CategoryID { get { return categoryID; } set { categoryID = value; } }

    #endregion
}