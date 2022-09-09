namespace normNamespace{
    public class UserModel () 
    {
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FileRootPath { get; set; }
        public bool Admin { get; set; }
        public bool LoggedIn { get; set; }
    }
}