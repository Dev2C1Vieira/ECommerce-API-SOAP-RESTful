/// <summary>
/// Summary description for Category
/// </summary>
public class Category : ICategory
{
    #region Attributes

    /// <summary>
    /// Creation of the Category class atributes
    /// </summary>
    private int id; // 
    private string name; // 

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor
    /// </summary>
    public Category()
    {
        id = 0;
        name = string.Empty;
    }

    /// <summary>
    /// Constructor passed by parameters
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    public Category(int id, string name)
    {
        this.id = id;
        this.name = name;
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

    #endregion
}