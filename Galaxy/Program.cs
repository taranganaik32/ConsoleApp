using Galaxy;

StudentRandomIdSort objStudentRandomIdSort = new StudentRandomIdSort();
List<int> stId=objStudentRandomIdSort.GetRandomNumber();

stId.Sort();
for (int i = 0; i < stId.Count; i++)
{
    Console.WriteLine($"Student ID : {stId[i]}");
}
