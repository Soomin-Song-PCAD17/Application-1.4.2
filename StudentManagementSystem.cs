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

class ClassRoom
{
    private List<Student> students = new List<Student>();
    private int classId;
    private string className;
    private int classSize;

    public ClassRoom(int classId, string className, int classSize)
    {
        this.classId = classId;
        this.className = className;
        this.classSize = classSize;
    }

    public override string ToString(){
        string output = $"{className} ({classId}) - {students.Count}/{classSize}";
        foreach (var student in students)
        {
            output = output + "\n\t" + student.ToString();
        }
        return output;
    } 
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void RemoveStudent(int studentId)
    {
        var student = students.FirstOrDefault(s => s.StudentId == studentId);
        if (student != null)
        {
            students.Remove(student);
        }
    }

    public int ClassId
    {
        get { return classId; }
        set { classId = value; }
    }

    public string ClassName
    {
        get { return className; }
        set { className = value; }
    }

    public int ClassSize {
    get { return classSize; }
        set { classSize = value; }
    }
}