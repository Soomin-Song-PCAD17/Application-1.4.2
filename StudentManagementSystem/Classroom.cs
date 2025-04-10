namespace StudentManagementSystem;

class Classroom
{
    private List<Student> students = new List<Student>();
    private int classId;
    private string className;
    private int classSize;

    public Classroom(int classId, string className, int classSize)
    {
        this.classId = classId;
        this.className = className;
        this.classSize = classSize;
    }

    public string displayStudents() {
        string output = $"{className} ({classId}) - {students.Count}/{classSize}";
        foreach (var student in students)
        {
            output = output + "\n\t" + student.ToString();
        }
        return output;
    }
    public override string ToString() => $"{className} ({classId}) - {students.Count}/{classSize}";
    public void AddStudent(Student student)
    {
        students.Add(student);
        student.addClassroom(this);
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