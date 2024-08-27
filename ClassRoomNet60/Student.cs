namespace ClassRoomNet60;

public class Student
{
    public string name { get; set; }
    public int birthmonth { get; set; }
    public int birthday { get; set; }

    public Student(string name, int birthmonth, int birthday)
    {
        this.name = name;
        this.birthmonth = birthmonth;
        this.birthday = birthday;
    }
}