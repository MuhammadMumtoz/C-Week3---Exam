var users = new List<User>();
var student1 = new Student(1,"Salim","RemaKe1");
var student2 = new Student(2,"Hakim","RemaKe2");
var teacher1 = new Teacher(3,"Sharif","TeacheR1");
var teacher2 = new Teacher(4,"Said","TeacheR2");
users.Add(student1);
users.Add(student2);
users.Add(teacher1);
users.Add(teacher2);
foreach(var item in users){
    item.GetUserInfo();
}