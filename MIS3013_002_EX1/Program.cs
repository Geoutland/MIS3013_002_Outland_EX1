// MIS 3013 002 Exercise 1
// September 12, 2022 1:30 PM to 2:45 PM
// Gabriel Outland 
Console.WriteLine("Please input the grade of exam 1 for the first student.");
String exam1student1str = Console.ReadLine();
Console.WriteLine("Please input the grade of exam 2 for the first student.");
String exam2student1str = Console.ReadLine();

Double Exam1student1dbl = Convert.ToDouble(exam1student1str);
Double Exam2student1dbl = Convert.ToDouble(exam2student1str);
double Student1Avg = (Exam1student1dbl + Exam2student1dbl) / 2;

string OutMsg = String.Format($"The average for the first student is: {Student1Avg} \n ");
Console.WriteLine(OutMsg);


Console.WriteLine("Please input the grade of exam 1 for the second student.");
String exam1student2str = Console.ReadLine();
Console.WriteLine("Please input the grade of exam 2 for the second student.");
String exam2student2str = Console.ReadLine();

Double Exam1student2dbl = Convert.ToDouble(exam1student2str);
Double Exam2student2dbl = Convert.ToDouble(exam2student2str);
double Student2Avg = (Exam1student2dbl + Exam2student2dbl) / 2;

OutMsg = String.Format($"The average for the second student is: {Student2Avg}\n ");
Console.WriteLine(OutMsg);


Console.WriteLine("Please input the grade of exam 1 for the third student.");
String exam1student3str = Console.ReadLine();
Console.WriteLine("Please input the grade of exam 2 for the third student.");
String exam2student3str = Console.ReadLine();

Double Exam1student3dbl = Convert.ToDouble(exam1student3str);
Double Exam2student3dbl = Convert.ToDouble(exam2student3str);
double Student3Avg = (Exam1student3dbl + Exam2student3dbl) / 2;

OutMsg = String.Format($"The average for the first student is: {Student3Avg}\n ");
Console.WriteLine(OutMsg);

Double StudentAverageExam1 = (Exam1student1dbl + Exam1student2dbl + Exam1student3dbl) / 3;
Double StudentAverageExam2 = (Exam2student1dbl + Exam2student2dbl + Exam2student3dbl) / 3;
Double StudentFinalAverage = (Student1Avg + Student2Avg + Student3Avg) / 3;

OutMsg = String.Format($"Exam 1 grade average is: {StudentAverageExam1}");
Console.WriteLine(OutMsg);
OutMsg = String.Format($"Exam 2 grade average is: {StudentAverageExam2}");
Console.WriteLine(OutMsg);
OutMsg = String.Format ($"Final grade average is: {StudentFinalAverage}");
Console.WriteLine(OutMsg);







Console.ReadLine();
