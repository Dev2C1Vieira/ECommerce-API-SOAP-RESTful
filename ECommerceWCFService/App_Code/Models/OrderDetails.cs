/// <summary>
/// Summary description for OrderDetails
/// </summary>
public class OrderDetails : IOrderDetails
{
    #region Attributes

    /// <summary>
    /// Creation of the OrderDetails class atributes
    /// </summary>
    private int id; // 
    private int quantity; //
    private float cost; //
    private int productID; //
    private int orderID; //

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor
    /// </summary>
    public OrderDetails()
    {
        id = 0;
        quantity = 0;
        cost = 0;
        productID = 0;
        orderID = 0;
    }

    /// <summary>
    /// Constructor passed by parameters
    /// </summary>
    /// <param name="id"></param>
    /// <param name="quantity"></param>
    /// <param name="cost"></param>
    /// <param name="productID"></param>
    /// <param name="orderID"></param>
    public OrderDetails(int id, int quantity, float cost, int productID, int orderID)
    {
        this.id = id;
        this.quantity = quantity;
        this.cost = cost;
        this.productID = productID;
        this.orderID = orderID;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Property related to the 'ID' attribute
    /// </summary>
    public int ID { get { return id; } set { id = value; } }

    /// <summary>
    /// Property related to the 'Quantity' attribute
    /// </summary>
    public int Quantity { get { return quantity; } set { quantity = value; } }

    /// <summary>
    /// Property related to the 'Cost' attribute
    /// </summary>
    public float Cost { get { return cost; } set { cost = value; } }

    /// <summary>
    /// Property related to the 'ProductID' attribute
    /// </summary>
    public int ProductID { get { return productID; } set { productID = value; } }

    /// <summary>
    /// Property related to the 'OrderID' attribute
    /// </summary>
    public int OrderID { get { return orderID; } set { orderID = value; } }

    #endregion
}