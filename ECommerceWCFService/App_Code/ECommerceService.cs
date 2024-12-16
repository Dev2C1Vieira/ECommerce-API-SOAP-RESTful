using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Summary description for ECommerceService
/// </summary>
public class ECommerceService : IECommerceService
{
    #region ConnectionString

    private readonly string connectionString;

    public ECommerceService()
    {
        connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }

    #endregion

    #region CategoriesSection

    public List<Category> GetAllCategories()
    {
        try
        {
            var categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Categories", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add(new Category()
                    {
                        ID = (int)reader["id"],
                        Name = (string)reader["name"]
                    });
                }
            }
            return categories;
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when getting categories: " + erro.Message);
        }
    }

    public Category GetCategoryById(int id)
    {
        try
        {
            Category category = new Category();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Categories WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    category.ID = (int)reader["id"];
                    category.Name = (string)reader["name"];
                }
            }
            return category;
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when getting category: " + erro.Message);
        }
    }

    public bool AddCategory(Category category)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Categories VALUES (@name)", connection);
                command.Parameters.AddWithValue("@name", category.Name);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when creating a new category: " + erro.Message);
        }
    }

    public bool UpdateCategory(Category category)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Categories " +
                    "SET name = @name " +
                    "WHERE id = @id", connection);
                command.Parameters.AddWithValue("@name", category.Name);
                command.Parameters.AddWithValue("@id", category.ID);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when updating the category: " + erro.Message);
        }
    }

    public bool DeleteCategory(int id)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Categories WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when deleting the category: " + erro.Message);
        }
    }

    #endregion

    #region ClientsSection

    public List<Costumer> GetAllClients()
    {
        try
        {
            var clients = new List<Costumer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Clients", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clients.Add(new Costumer()
                    {
                        ID = (int)reader["id"],
                        Name = (string)reader["name"],
                        NIF = (int)reader["nif"],
                        PhoneNumber = (int)reader["phoneNumber"],
                        Address = (string)reader["address"],
                        Email = (string)reader["email"],
                        Password = (string)reader["password"]
                    });
                }
            }
            return clients;
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when getting clients: " + erro.Message);
        }
    }

    public Costumer GetCostumerById(int id)
    {
        try
        {
            Costumer costumer = new Costumer();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Clients WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    costumer.ID = (int)reader["id"];
                    costumer.Name = (string)reader["name"];
                    costumer.NIF = (int)reader["nif"];
                    costumer.PhoneNumber = (int)reader["phoneNumber"];
                    costumer.Address = (string)reader["address"];
                    costumer.Email = (string)reader["email"];
                    costumer.Password = (string)reader["password"];
                }
            }
            return costumer;
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when getting costumer: " + erro.Message);
        }
    }

    public bool AddCostumer(Costumer costumer)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Clients " +
                    "VALUES (@name, @nif, @phoneNumber, @address, @email, @password)", connection);
                command.Parameters.AddWithValue("@name", costumer.Name);
                command.Parameters.AddWithValue("@nif", costumer.NIF);
                command.Parameters.AddWithValue("@phoneNumber", costumer.PhoneNumber);
                command.Parameters.AddWithValue("@address", costumer.Address);
                command.Parameters.AddWithValue("@email", costumer.Email);
                command.Parameters.AddWithValue("@password", costumer.Password);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when creating a new costumer: " + erro.Message);
        }
    }

    public bool UpdateCostumer(Costumer costumer)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Clients " +
                    "SET name = @name, " +
                    "nif = @nif, " +
                    "phoneNumber = @phoneNumber, " +
                    "address = @address, " +
                    "email = @email, " +
                    "password = @password " +
                    "WHERE id = @id", connection);
                command.Parameters.AddWithValue("@name", costumer.Name);
                command.Parameters.AddWithValue("@nif", costumer.NIF);
                command.Parameters.AddWithValue("@phoneNumber", costumer.PhoneNumber);
                command.Parameters.AddWithValue("@address", costumer.Address);
                command.Parameters.AddWithValue("@email", costumer.Email);
                command.Parameters.AddWithValue("@password", costumer.Password);
                command.Parameters.AddWithValue("@id", costumer.ID);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when updating the costumer: " + erro.Message);
        }
    }

    public bool DeleteCostumer(int id)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Clients WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when deleting the costumer: " + erro.Message);
        }
    }

    public Costumer AuthenticateClient(string email, string password)
    {
        try
        {
            Costumer client = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Clients " +
                    "WHERE Email = @Email AND " +
                    "Password = @Password", connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    client = new Costumer
                    {
                        ID = (int)reader["id"],
                        Name = (string)reader["name"],
                        NIF = (int)reader["nif"],
                        PhoneNumber = (int)reader["phoneNumber"],
                        Address = (string)reader["address"],
                        Email = (string)reader["email"],
                        Password = (string)reader["password"]
                    };
                }
            }

            return client;
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when authenticating costumer: " + erro.Message);
        }
    }

    #endregion

    #region OrdersSection

    #endregion

    #region OrdersDetailsSection

    #endregion

    #region ProductsSection

    public List<Product> GetAllProducts()
    {
        try
        {
            var products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product()
                    {
                        ID = (int)reader["id"],
                        Name = (string)reader["name"],
                        Description = (string)reader["description"],
                        UnitPrice = (decimal)reader["unitPrice"],
                        Stock = (int)reader["stock"],
                        CategoryID = (int)reader["categoryID"]
                    });
                }
            }
            return products;
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when getting products: " + erro.Message);
        }
    }

    public Product GetProductById(int id)
    {
        try
        {
            Product product = new Product();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    product.ID = (int)reader["id"];
                    product.Name = (string)reader["name"];
                    product.Description = (string)reader["description"];
                    product.UnitPrice = (decimal)reader["unitPrice"];
                    product.Stock = (int)reader["stock"];
                    product.CategoryID = (int)reader["categoryID"];
                }
                // else throw new FaultException("Error when getting product: That product doesnt exist!");
            }
            return product;
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when getting product: " + erro.Message);
        }
    }

    public bool AddProduct(Product product)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Products " +
                    "VALUES (@name, @description, @unitPrice, @stock, @categotyID)", connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
                command.Parameters.AddWithValue("@stock", product.Stock);
                command.Parameters.AddWithValue("@categotyID", product.CategoryID);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when creating a new product: " + erro.Message);
        }
    }

    public bool UpdateProduct(Product product)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Products " +
                    "SET name = @name, " +
                    "description = @description, " +
                    "unitPrice = @unitPrice, " +
                    "stock = @stock, " +
                    "categoryID = @categoryID " +
                    "WHERE id = @id", connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
                command.Parameters.AddWithValue("@stock", product.Stock);
                command.Parameters.AddWithValue("@categoryID", product.CategoryID);
                command.Parameters.AddWithValue("@id", product.ID);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when updating the product: " + erro.Message);
        }
    }

    public bool DeleteProduct(int id)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Products WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception erro)
        {
            throw new FaultException("Error when deleting the product: " + erro.Message);
        }
    }

    #endregion
}