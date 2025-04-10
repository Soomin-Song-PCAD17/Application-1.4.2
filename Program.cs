var student1 = new Student(1, "Soomin", "Song", 'A');
Console.WriteLine(student1);

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

    public override string ToString() => $"{StudentLname}, {StudentFname} ({StudentId}): {StudentGrade}";
}
