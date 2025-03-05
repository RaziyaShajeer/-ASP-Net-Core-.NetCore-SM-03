internal class user
{
    internal int id;
    internal string? name;
    internal string? email;
    internal string? password;

    public object UserRole { get; internal set; }
    public object PublicUser { get; internal set; }
    public object Admin { get; internal set; }
}