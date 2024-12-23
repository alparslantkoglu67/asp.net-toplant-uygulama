namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users=new();
        static Repository()
        {
            _users.Add(new UserInfo(){Id=1,Name="Ali", Email="abc@google.com",Phone="4888151551",WillAttend=true});
            _users.Add(new UserInfo(){Id=2,Name="Mehmet", Email="abc@youtube.com",Phone="881511",WillAttend=false});
            _users.Add(new UserInfo(){Id=3,Name="Ayşe", Email="abfdfdc@gmail.com",Phone="87841266",WillAttend=true});
        }
        public static List<UserInfo> Users
        {
            get{
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id=Users.Count+1;
            _users.Add(user);

        }
        public static UserInfo? GetById(int id) {
            return _users.FirstOrDefault(user => user.Id ==id);
        }

    }
}