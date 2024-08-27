namespace ClassRoomNet60;

public class Classroom
{
    public string classname { get; set; }
    public List<Student> studentList { get; set; }
    public DateTime semesterstart { get; set; }

    public Classroom(string classname, List<Student> studentList, DateTime semesterstart)
    {
        this.classname = classname;
        this.studentList = studentList;
        this.semesterstart = semesterstart;
    }
    
    
    
}