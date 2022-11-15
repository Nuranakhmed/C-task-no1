// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
#region
    Console.WriteLine("sozu daxil edin");
    string word = Console.ReadLine();
    Console.WriteLine("ikinci sozu daxil edin");
    var letters = Console.ReadLine();
    var result = 0;
    for (var i = 0; i < word.Length; i++) ;
    for (var j = 0; j < letters.Length; j++) ;
if (word == letters) {
    result += letters.Length;
}
Console.WriteLine(result);
{ }
#endregion
//int mass;
//int cut = 0;
//Console.WriteLine("massivin olcusunu daxil et:-");
//mass = int.Parse(Console.ReadLine());
//int[] massiv = new int[mass];
//Console.WriteLine("massivin elementerini daxil et:-");
//for (int i = 0; i < massiv.Length; i++)
//{
//    massiv[i] = int.Parse(Console.ReadLine());
//}
//for (int j = 0; j < massiv.Length; j++)
//{
//    if (massiv[j] % 2 == 0)
//        cut += massiv[j];
//}   
//Console.WriteLine(cut);


