// Aditi Mahangade
// MIS 3013 HW3 Task 4 Student Grades

string outMesStr;
string userChoiceStr;

int numOfStudentsInt = 0;
double sumOfAllFinalGrades = 0;

int numLevel1Int = 0;
int numLevel2Int = 0;
int numLevel3Int = 0;

do
{
    numOfStudentsInt++;

    outMesStr = string.Format($"Student {numOfStudentsInt} Exam 1 Grade: ");
    Console.Write(outMesStr);
    string exam1GradeStr = Console.ReadLine();
    double exam1GradeDbl = Convert.ToDouble(exam1GradeStr);

    outMesStr = string.Format($"Student {numOfStudentsInt} Exam 2 Grade: ");
    Console.Write(outMesStr);
    string exam2GradeStr = Console.ReadLine();
    double exam2GradeDbl = Convert.ToDouble(exam2GradeStr);

    outMesStr = string.Format($"Student {numOfStudentsInt} Exam 3 Grade: ");
    Console.Write(outMesStr);
    string exam3GradeStr = Console.ReadLine();
    double exam3GradeDbl = Convert.ToDouble(exam3GradeStr);

// final grades

    double finalGradeDbl = (exam1GradeDbl + exam2GradeDbl + exam3GradeDbl) / 3.0;

// if statement

if (finalGradeDbl >= 80)
{
    Console.WriteLine("Level 1!");
    numLevel1Int++;
}
else if(finalGradeDbl >= 60)
{
    Console.WriteLine("Level 2!");
    numLevel2Int = numLevel2Int + 1;
}
else
{
    Console.WriteLine("Level 3!");
    numLevel3Int += 1;
}
    
// sum of all final grades

    sumOfAllFinalGrades = sumOfAllFinalGrades + finalGradeDbl;
    outMesStr = string.Format($"Final Grade is {finalGradeDb1:F2}");
    Console.WriteLine(outMesStr);

    outMesStr = string.Format($"Final Grade is {finalGradeDbl:F2}");
    Console.WriteLine(outMesStr);

    outMesStr = "Do you want to enter another students grades? {yes/no} ";
    Console.Write(outMesStr);
    userChoiceStr = Console.ReadLine();
}
while(userChoiceStr == "yes");

    Console.WriteLine("Summary Information");
    
    outMesStr = string.Format($"Number of Students: {numOfStudentsInt}");
    Console.WriteLine(outMesStr);

    double averageFinalGradeDbl = sumOfAllFinalGrades / numOfStudentsInt;
    outMesStr = string.Format($"Average of Final Grades is {averageFinalGradeDbl:F2}");
    Console.WriteLine(outMesStr);

    outMesStr = string.Format($"Level 1: {numLevel1Int} out of {numOfStudentsInt}, {1.0 * numLevel1Int / numOfStudentsInt}");
    Console.WriteLine(outMesStr);

    outMesStr = string.Format($"Level 2: {numLevel2Int} out of {numOfStudentsInt}, {1.0 * numLevel2Int / numOfStudentsInt}");
    Console.WriteLine(outMesStr);

    outMesStr = string.Format($"Level 3: {numLevel3Int} out of {numOfStudentsInt}, {1.0 * numLevel3Int / numOfStudentsInt}");
    Console.WriteLine(outMesStr);

Console.ReadLine();
