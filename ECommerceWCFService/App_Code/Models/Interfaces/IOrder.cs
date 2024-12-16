using System;

/// <summary>
/// Summary description for IOrder
/// </summary>
public interface IOrder
{
    /// <summary>
    /// Creation of Properties
    /// </summary>
    int ID { get; set; }

    DateTime OrderDate { get; set; }

    float TotalCost { get; set; }

    bool Status { get; set; }

    int ClientID { get; set; }
}