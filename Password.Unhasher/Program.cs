using Microsoft.AspNetCore.Identity;


var ph = new PasswordHasher<User>();

User user = new User
{
    Username = "username",
    Password = "password"
};

var hash = ph.HashPassword(user, "password");

Console.WriteLine("Hash is " + hash);


var isHashValid = ph.VerifyHashedPassword (user, "AQAAAAEAACcQAAAAEFlIiKvcyf6av+gCgUMIEEUbxyzrIOdp4bNk1x7fu2qnNRbprAdF5b2uPO0JTNOEXA==", "password");



Console.WriteLine("Hash Validation is " + isHashValid);


public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}
