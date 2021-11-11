using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppTest.Properties;

namespace WindowsFormsAppTest
{
    public class Que
    {
        static public List<string> listQue = new List<string>();

        static public void OnStart()
        {
            listQue.Add("string - це строкове значення? | 1 | 1");
            listQue.Add("int - 64 бітне значення? | 1 | 0");
            listQue.Add("Декрементація числа виконується за допомогою оператора ++ | 1 | 0"); 
            listQue.Add("\"?\" - тернарний оператор? | 1 | 1");
            listQue.Add("Компіляція  - це розрахунок функцій | 1 | 0");
            listQue.Add("Using використовується для підключання бібліотек у С#? | 1 | 1");
            listQue.Add("Exception - це бібліотека для С#? | 1 | 0");
            listQue.Add("null це 0? | 1 | 0");
            listQue.Add("protected дає доступ з любої точки програми в namespace? | 1 | 0");
            listQue.Add("Чи існують статичні об'єкти? | 1 | 0");
            listQue.Add("new використовується для виділення пам'яті? | 1 | 1");
            listQue.Add("Чи працюватиме цей код: \"const int a = 5\"   | 1 | 1");
            listQue.Add("Без явного вказування клас зазвичай публічний? | 1 | 0");
            listQue.Add("string та String - одне і теж саме? | 1 | 0");
            //
            listQue.Add("Оператор виділення пам'яті | 2 | new");
            listQue.Add("Порожнє значення змінної називається... | 2 | Null");
            listQue.Add("Що виведе на екран код:\n        int a = -5;\n        Console.WriteLine(~a); | 2 | 4");
            listQue.Add("Вихід з циклу виконується за допомогою... | 2 | break");
            listQue.Add("Вихід з методу виконується за допомогою...  | 2 | return");
            listQue.Add("Відображення форми виконується за допомогою метода...| 2 | Show");
            listQue.Add("Цикл який буде виконуватися поки умова вірна... | 2 | while");
            listQue.Add("У delegate можна додавати... | 2 | Методи");
            listQue.Add("Тіло для додавання елементів форми називається... | 2 | Контейнер");
            listQue.Add("Visual Studio - це надбання компанії...| 2 | Microsoft");
            listQue.Add("Готовий елемент для інформації по типу баз данних називається...| 2 | DataGridView");
            listQue.Add("Метод закриття форми називається... | 2 | Close");
            listQue.Add("Оператор += додає значення до попереднього... | 2 | значення");
            listQue.Add("Конструктор із знаком ~ перед назвою це... | 2 | Деструктор");
            //
            Que.listQue.Add("hi | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
            Que.listQue.Add(" | 3 | otvet | otvet | wrong | wrong | wrong");
        }

    }
}
