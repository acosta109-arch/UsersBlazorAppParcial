namespace UserBlazorApp.API.Dtos.User;

public class UserRequest
{
    //public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTimeOffset? LockoutEnd { get; set; }
}
