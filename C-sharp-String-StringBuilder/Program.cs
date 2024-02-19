
//int[] arr = { 1, 23, 4, 5 };

//arr[1] = 100;

//List<int> datas = new() { 1, 2, 3, 4 };

//datas.Add(100);

//string name = "Test";

//string newName = name + "salam";

//string name = "test";

//name = "salam";

//using System.Text;

//StringBuilder str  = new StringBuilder("Salam");

//str.Append("sagol");    

//int age = 100;

//Console.WriteLine(age.ToString().GetType());

//string surname = "test";

//Console.WriteLine(surname.Length);

//string str1 = "salam";
//string str2 = " necesiz?";

//string result  = string.Concat(str1, str2);

//Console.WriteLine(result);

//string result = "";

//string result2 = string.Empty;

//var result3 = result2 + "salam";

//string text = " ";

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");


//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//} 

//Console.WriteLine(text.ToUpper());

//Console.WriteLine(text.ToLower());

//string str1 = "Apple";
//string str2 = "apple";

//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());


//string str1 = "  Apple";
//string str2 = "apple";

//Console.WriteLine(str1.Trim().ToLower().Equals(str2.Trim().ToLower()));




//Console.WriteLine(CheakStr(str1).Equals(CheakStr(str2)));

//string CheakStr(string str)
//{
//  return str.Trim().ToLower();
//}

//string str = "This is the \"String\" class.";
//Console.WriteLine(str);

//string message = $"Welcome to{str}";

//string text = "Azerbaycan";

//Console.WriteLine(string.Format(text));

//string students = "Ayxan, Cemile, Orxan, Eli, Veli, ";

//string[] studetsList =  students.Split(", ");

//foreach (string item in studetsList)
//{
//    Console.WriteLine(item);
////}
//using System.Reflection.Metadata;

//string text = "Salam Azerbaycan";

////Console.WriteLine(text.Replace("Salam","Sag ol"));

////Console.WriteLine(text.Substring(2));

//Console.WriteLine(text.Contains("Az"));


//bool ChechCharInStr(string text,string letter)
//{var result = CheachStr(text).Contains(CheachStr(letter));
//    return result;
//}

//Console.WriteLine(ChechCharInStr("Baku","B"));

//string CheachStr(string str)
//{
//    string result=str.Trim().ToLower();
//    return result;
//}

//void StartSearch()
//{

//    Console.WriteLine("Add text:");
//    string text = Console.ReadLine();

//    Console.WriteLine("Add search text: ");
//    string serachText = Console.ReadLine();

//    if (ChechCharInStr(text, serachText))
//    {
//        Console.WriteLine("Found");
//    }
//    else
//    {
//        Console.WriteLine("Notfound");
//    }
//}
//StartSearch();






///Homework
///


///Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin
///
//string Words(string text)
//{
//    string result= string.Empty;
//    for (int i = text.Length-1; i >=0; i--)
//    {
//        result += text[i];
//    }
//    return result;
//}
//Console.WriteLine(Words("Cavid"));