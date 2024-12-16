/// <summary>
/// Summary description for IOrderDetails
/// </summary>
public interface IOrderDetails
{
    int ID { get; set; }

    int Quantity { get; set; }

    float Cost { get; set; }

    int ProductID { get; set; }

    int OrderID { get; set; }
}