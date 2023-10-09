
using hm12_delegate;

PrintPersonInfo person = new PrintPersonInfo();

ReaderDelegate[] rd = new ReaderDelegate[3] { person.PrintName, person.PrintBirthDate, person.PrintPhone };

string[] str = { "Oleg", "12.12.1900", "093123413" };

for (int i = 0; i < 3; ++i)
{
    rd[i](str[i]);
}