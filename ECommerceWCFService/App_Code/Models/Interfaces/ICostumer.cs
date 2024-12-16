/// <summary>
/// Summary description for ICostumer
/// </summary>
public interface ICostumer
{
    /// <summary>
    /// Creation of Properties
    /// </summary>
    int ID { get; set; }

    string Name { get; set; }

    int NIF { get; set; }

    int PhoneNumber { get; set; }

    string Address { get; set; }

    string Email { get; set; }

    string Password { get; set; }
}