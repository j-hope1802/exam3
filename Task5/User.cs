public class User{

    public int _userid{get;set;}
    public string _username{get;set;}
    public string _password{get;set;}

    public void GetUserInfo()
    {
    this._username = username;
    this._password = password;
    this._userid = userid;
    }
    public List <User> users;
     public Us()
    {
      users = new List<User>();  
    }
        public void add ( User user)
        {
           GetUserInfo.Add;
        }
}