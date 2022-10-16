Console.Clear();
string [] text = {"Hello","23","Bye","Denmark","-71"};
for (int i = 0; i < text.Length; i++)
{
  Console.WriteLine(text[i]);  
}
System.Console.WriteLine();
void FillNewArray (string[]array, int n)
{
string [] newText = new string[text.Length];
for (int i = 0; i < text.Length; i++)
{
  if (text[i].Length<=n)
  {
    newText[i] = text[i];
    Console.WriteLine(newText[i]);  
  }  
}
}
FillNewArray(text,3);