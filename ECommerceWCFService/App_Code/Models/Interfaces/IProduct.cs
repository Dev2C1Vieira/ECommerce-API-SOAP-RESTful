/// <summary>
/// Summary description for IProduct
/// </summary>
public interface IProduct
{
    /// <summary>
    /// Creation of properties
    /// </summary>
    int ID { get; set; }

    string Name { get; set; }

    string Description { get; set; }

    decimal UnitPrice { get; set; }

    int Stock { get; set; }

    int CategoryID { get; set; }
}