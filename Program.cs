string[] arrayFirst =  {"labas", "hi", "pryvitannie", "privet"};
int countFirst = CountStringLessThreeChar(arrayFirst);
string[] resultFirst =  FillResultArray(arrayFirst,countFirst);


string[] arraySecond = {"1234", "1567", "-2", "computer science"};
int countSecond  = CountStringLessThreeChar(arraySecond);
string[] resultSecond = FillResultArray(arraySecond,countSecond);


string[] arrayThird = {"Poland", "Lithuania", "Belarus"};
int countThird = CountStringLessThreeChar(arrayThird);
string[] resultThird = FillResultArray(arrayThird, countThird);


PrintArray(resultFirst);
PrintArray(resultSecond);
PrintArray(resultThird);