namespace ConsoleApp24.Entites;

//Principil Enttiy
public class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }

    public ICollection<Student> Students { get; set; }

}
