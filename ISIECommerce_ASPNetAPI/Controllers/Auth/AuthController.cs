using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ECommerceWCFService;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    /*private readonly IConfiguration _configuration;

    public AuthController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] UserLogin userLogin)
    {
        // Consumir o serviço WCF
        using (var client = new ECommerceServiceClient())
        {
            var authenticatedClient = client.AuthenticateClient(userLogin.Email, userLogin.Password);

            if (authenticatedClient != null)
            {
                // Gerar o token JWT para o cliente autenticado
                var token = GenerateJwtToken(authenticatedClient);
                return Ok(new { token });
            }
        }

        return Unauthorized("Invalid email or password.");
    }

    private string GenerateJwtToken(Costumer client)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
        new Claim(JwtRegisteredClaimNames.Sub, client.Email),
        new Claim("client_id", client.ID.ToString()),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }*/
}


public class UserLogin
{
    public string Email { get; set; }
    public string Password { get; set; }
}