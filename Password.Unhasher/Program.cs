using Microsoft.AspNetCore.Identity;
using static System.Console;

var ph = new PasswordHasher<User>();

User user = new User
{
    Username = "username",
    Password = "password"
};

var hash = ph.HashPassword(user, "password");

WriteLine("Hash is " + hash);

var isHashValid = ph.VerifyHashedPassword (user, "AQAAAAEAACcQAAAAEFlIiKvcyf6av+gCgUMIEEUbxyzrIOdp4bNk1x7fu2qnNRbprAdF5b2uPO0JTNOEXA==", "password");
WriteLine("Hash Validation is " + isHashValid);
for (int i = 0; i <= 100000000; i++)
{
    var pw = ph.VerifyHashedPassword(user, "ADwElLaoEJAKjc9QoNj57I/QtvPMrfxdTr7vO175aQ+b5Y1bJgXL4RSsjpBcmN6QZw==", i.ToString());
    if (pw == PasswordVerificationResult.Success)
    {
        WriteLine(i.ToString());
        break;
    }
    if(i== 100000000) WriteLine("Password did not match");
}


