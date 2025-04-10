namespace StudentManagementSystem;
class Student
{
    public Student(int studentId, string studentFname, string studentLname, char studentGrade)
    {
        StudentId = studentId;
        StudentFname = studentFname;
        StudentLname = studentLname;
        StudentGrade = studentGrade;
    }
    private int studentId;
    private string studentFname;
    private string studentLname;
    private char studentGrade;

    private List<Classroom> classrooms = new List<Classroom>();

    public int StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }
    public string StudentFname
    {
        get { return studentFname; }
        set { studentFname = value; }
    }
    public string StudentLname
    {
        get { return studentLname; }
        set { studentLname = value; }
    }
    public char StudentGrade
    {
        get { return studentGrade; }
        set { studentGrade = value; }
    }

    public void addClassroom(Classroom classroom)
    {
        classrooms.Add(classroom);
    }

    public void removeClassroom(Classroom classroom)
    {
        classrooms.Remove(classroom);
    }
    public string getClassrooms()
    {
        string output= "";
        // foreach (var classroom in classrooms)
        // {
        //     output = output + "\n\t" + classroom.ToString();
        // }
        return output;
    }

    public override string ToString() => $"{StudentLname}, {StudentFname} ({StudentId}): {StudentGrade}";
}
