/// <summary>
/// Summary description for Costumer
/// </summary>
public class Costumer : ICostumer
{
    #region Attributes

    /// <summary>
    /// Creation of the Costumer class atributes
    /// </summary>
    private int id; // 
    private string name; // 
    private int nif; //
    private int phoneNumber; //
    private string address; //
    private string email; //
    private string password;

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor
    /// </summary>
    public Costumer()
    {
        id = 0;
        name = string.Empty;
        nif = 0;
        phoneNumber = 0;
        address = string.Empty;
        email = string.Empty;
        password = string.Empty;
    }

    /// <summary>
    /// Constructor passed by parameters
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="nif"></param>
    /// <param name="phoneNumber"></param>
    /// <param name="address"></param>
    /// <param name="email"></param>
    /// <param name="password"></param>
    public Costumer(int id, string name, int nif, int phoneNumber,
        string address, string email, string password)
    {
        this.id = id;
        this.name = name;
        this.nif = nif;
        this.phoneNumber = phoneNumber;
        this.address = address;
        this.email = email;
        this.password = password;
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
    /// Property related to the 'NIF' attribute
    /// </summary>
    public int NIF { get { return nif; } set { nif = value; } }

    /// <summary>
    /// Property related to the 'PhoneNumber' attribute
    /// </summary>
    public int PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

    /// <summary>
    /// Property related to the 'Address' attribute
    /// </summary>
    public string Address { get { return address; } set { address = value; } }

    /// <summary>
    /// Property related to the 'Email' attribute
    /// </summary>
    public string Email { get { return email; } set { email = value; } }

    /// <summary>
    /// Property related to the 'Password' attribute
    /// </summary>
    public string Password { get { return password; } set { password = value; } }

    #endregion
}