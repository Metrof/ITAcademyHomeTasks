//Переменные

bool blVakue = true; //1
blVakue = false;
Console.WriteLine(blVakue);

//

string strValue = "Bonny";  //2
strValue = "Klide";
Console.WriteLine(strValue);

string strValue2 = "Finn";  //3
strValue2 = "Jake";
Console.WriteLine(strValue2);

//

char crValue = 'R';  //4
crValue = 'r';
Console.WriteLine(crValue);

char crValue2 = 'S';  //5
crValue2 = 's';
Console.WriteLine(crValue2);

//

byte bValue = 1;  //6
bValue = 255;
Console.WriteLine(bValue);

byte bValue2 = 2;  //7
bValue2 = 254;
Console.WriteLine(bValue2);

//

sbyte sbValue = -126;  //8
sbValue = 125;
Console.WriteLine(sbValue);

sbyte sbValue2 = -127;  //9
sbValue2 = 126;
Console.WriteLine(sbValue2);

//

short shValue = -32768;  //10
shValue = 32767;
Console.WriteLine(shValue);

short shValue2 = -32767;  //11
shValue2 = 32766;
Console.WriteLine(shValue2);

//

ushort ushValue = 1;  //12
ushValue = 65535;
Console.WriteLine(ushValue);

ushort ushValue2 = 2;  //13
ushValue2 = 65534;
Console.WriteLine(ushValue2);

//

int intValue = -2147483648;  //14
intValue = 2147483647;
Console.WriteLine(intValue);

int intValue2 = -2147483647;  //15
intValue2 = 2147483646;
Console.WriteLine(intValue2);

//

uint uiValue = 1;  //16
uiValue = 4294967295;
Console.WriteLine(uiValue);

uint uiValue2 = 2;  //17
uiValue2 = 4294967294;
Console.WriteLine(uiValue2);

//

long lgValue = -9223372036854775808;  //18
lgValue = 9223372036854775807;
Console.WriteLine(lgValue);

ulong ulgValue = 1;  //19
ulgValue = 18446;
Console.WriteLine(ulgValue);

Single sglValue = .1f;  //20
sglValue = .2f;
Console.WriteLine(sglValue);

//

float floatValue = 4.5f;  //21
floatValue = 5.4f;
Console.WriteLine(floatValue);

float floatValue2 = 4.4f;  //22
floatValue2 = 5.3f;
Console.WriteLine(floatValue2);

//

double doubleValue = 3.45d;  //23
doubleValue = 7.89d;
Console.WriteLine(doubleValue);

decimal decValue = 3.14m;  //24
decValue = 6.283m;
Console.WriteLine(decValue);

//

object objValue = 45;  //25
objValue = "room";
Console.WriteLine(objValue);

object objValue2 = 'D';  //26
objValue2 = 9.9f;
Console.WriteLine(objValue2);

//

var vrValue = 'O';  //27
vrValue = 'E';
Console.WriteLine(vrValue);

DayOfWeek dayOfWeekValue = DayOfWeek.Monday;  //28
dayOfWeekValue = DayOfWeek.Tuesday;
Console.WriteLine(dayOfWeekValue);

NewStruct newStruct = new NewStruct("Foma");  //29
newStruct = new NewStruct("Arnold");
Console.WriteLine(newStruct.name);

NewClass newClass = new NewClass("Kojima");  //30
newClass = new NewClass("genius?");
Console.WriteLine(newClass.name);

//Вывод на консоль различных литералов

Console.WriteLine("hello world");
Console.WriteLine(0b11);   
Console.WriteLine(0b1011);
Console.WriteLine(0xFF);
Console.WriteLine(0xA1);
Console.WriteLine(3.2e3);
Console.WriteLine(true);

//Константы

const string firstName = "Evgeniy";
const string lastName = "Polyakov";
const char initial = 'E';
const byte age = 22;
const bool married = false;


class NewClass
{
    public string name;
    public NewClass(string name = "Evgeniy")
    {
        this.name = name;
    }
}

struct NewStruct
{
    public string name;
    public NewStruct(string name = "Evgeniy")
    { 
        this.name = name;
    }
}

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
