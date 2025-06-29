using System.Linq;

string text = "777-717-123";
int count = text.Count(c => c == '7');
Console.WriteLine(count);  // Çıxış: 4
