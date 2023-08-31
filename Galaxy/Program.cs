using Galaxy;

StudentRandomIdSort objStudentRandomIdSort = new StudentRandomIdSort();
List<int> stId=objStudentRandomIdSort.GetRandomNumber();

stId.Sort();
for (int i = 0; i < stId.Count; i++)
{
    Console.WriteLine($"Student ID : {stId[i]}");
}

//Main method
MethodHiding objM1 = new MethodHiding();
objM1.lastName = "ABC";
objM1.firstName = "123";
objM1.PrintFullName();


//Child method
MethodHiding objM = new MethodHiding2();
objM.lastName = "Naik";
objM.firstName = "Taranga";
objM.PrintFullName();
