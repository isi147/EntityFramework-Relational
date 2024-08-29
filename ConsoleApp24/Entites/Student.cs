namespace ConsoleApp24.Entites;


//Depend Enttiy
public class Student
{
    //Enttiy framawork bizden migraton emelyatari ucun primary key yarada bilmelyi ucun en azi asagidakilaran birinin olmasini teleb edir
    //public int ID { get; set; }
    //public int Id { get; set; }
    //public int StudentID  { get; set; }
    //public int StudentId  { get; set; }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public int GroupId { get; set; }  //Foreign Key

    //Navigation property
    public Group Group { get; set; }

}

