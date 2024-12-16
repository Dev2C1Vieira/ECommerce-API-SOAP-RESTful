using System;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order : IOrder
{
    #region Attributes

    /// <summary>
    /// Creation of the Order class atributes
    /// </summary>
    private int id; // 
    private DateTime orderDate; // 
    private float totalCost; //
    private bool status; //
    private int clientID; //

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor
    /// </summary>
    public Order()
    {
        id = 0;
        orderDate = DateTime.Now;
        totalCost = 0;
        status = false;
        clientID = 0;
    }

    /// <summary>
    /// Constructor passed by parameters
    /// </summary>
    /// <param name="id"></param>
    /// <param name="orderDate"></param>
    /// <param name="totalCost"></param>
    /// <param name="status"></param>
    /// <param name="clientID"></param>
    public Order(int id, DateTime orderDate, float totalCost, 
        bool status, int clientID)
    {
        this.id = id;
        this.orderDate = orderDate;
        this.totalCost = totalCost;
        this.status = status;
        this.clientID = clientID;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Property related to the 'ID' attribute
    /// </summary>
    public int ID { get { return id; } set { id = value; } }

    /// <summary>
    /// Property related to the 'OrderDate' attribute
    /// </summary>
    public DateTime OrderDate { get { return orderDate; } set { orderDate = value; } }

    /// <summary>
    /// Property related to the 'TotalCost' attribute
    /// </summary>
    public float TotalCost { get { return totalCost; } set { totalCost = value; } }

    /// <summary>
    /// Property related to the 'Status' attribute
    /// </summary>
    public bool Status { get { return status; } set { status = value; } }

    /// <summary>
    /// Property related to the 'ClientID' attribute
    /// </summary>
    public int ClientID { get { return clientID; } set { clientID = value; } }

    #endregion
}