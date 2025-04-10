using StudentManagementSystem;
var student1 = new Student(1, "Soomin", "Song", 'A');
var student2 = new Student(2, "Bar", "Foo", 'B');
Console.WriteLine(student1);

var math101 = new Classroom(1101, "Math 101", 30);
math101.AddStudent(student1);
math101.AddStudent(student2);
Console.WriteLine(math101);

var cmps101 = new Classroom(2101, "CMPS 101", 20);
cmps101.AddStudent(student2);
Console.WriteLine(cmps101);

// Console.WriteLine(student1.getClassrooms);