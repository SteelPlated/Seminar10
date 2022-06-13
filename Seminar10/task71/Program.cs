/*Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
и «в». Покажите все слова, состоящие из n букв, которые можно построить из
букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс*/

string charsWords = "аисв";
int countCharsInWords = 5;

PrintAllWords(charsWords, countCharsInWords, "");

void PrintAllWords(string alphabet, int length, string prefix)
{
    if (length == 0) Console.Write(prefix + " ");
    else foreach (char c in alphabet) PrintAllWords(alphabet, length - 1, prefix + c);
}