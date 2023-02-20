using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_sharp
{
    public class Item
    {
        public string name; // власне інформація вузла дерева
        public Item nextItem, prevItem; // наступний елемент списку цього рівня
        public Item begin, end; // початок та кінець підлеглого списку

        public Item(string Name) // конструктор
        {
            name = Name;   // заносимо у вузол інформацію
            nextItem = begin = end = null;  // обнуляємо все
        }
        /// <summary>
        /// Метод додавання елементу
        /// </summary>
        /// <param name="where">where - куди будемо вставляти елемент</param>
        /// <param name="what">what - що будемо вставляти</param>
        /// <returns>Повертає 0 коли ОК, 1 - коли не знайшли місце, куди будемо писати дані, 2   - коли дані за такою адресою вже записані</returns>
        public int Add(string where, string what)
        {
            int retCode = 1; // спочатку вважаємо, що ми не знайшли місце(where) у нашому дереві
            for (Item i = this; i != null; i = i.nextItem) // переглядаємо поточний список нашого рівня
                                                     // кожного разу під чс виклику методу ми переходимо на  початок списку(begin)
            {
                if(i.name == where) // якщо ми знайшли нашу адресу у почтоному списку
                {                           // то виклаикаємо метод для додання даних до нашого підлегого списку 
                    retCode = i.AddToList(what);
                }
                else
                {
                    retCode = i.begin.Add(where, what);
                }// рекурсія з адресою(where) та інформиацією
            }
            return retCode;
        }
        /// <summary>
        /// AddToList - метод дадовання даних до підлеглого списку нашого вузла
        /// </summary>
        /// <param name="what">what - що будемо вставляти</param>
        /// <returns>Повертає 0 коли ОК, 1 - коли не знайшли місце, куди будемо писати дані, 2   - коли дані за такою адресою вже записані</returns>
        public int AddToList(string what)
        {
            Item t = new Item(what); //  стіворюємо нновий вузол
            int retCode = 0;             // будемо вважати, що додамо дані
            if (begin == end) // підлеглий список пустий, тому створюємо список з одного  нового елементу
            {
                begin = end = t;
            }
            else // якщо список не пустий 
            {
                for (Item i = begin; i != null; i = i.nextItem) // починаємо переглядати підлеглий список
                {
                    if (i.name == what)
                    {
                        retCode = 2; // якщо знайшли такі ж дані як і what
                                     // утворюємо  код 2
                    }
                }
                if (retCode !=2 ) // якщо дані не було знайдено у нашому списку 
                              // то ми просто додаємо новий вузол у кінець підлеглого списку
                {
                    Item temp = end;
                    end.nextItem = t;
                    end = t;
                    end.prevItem = temp;
                }
            }
            return retCode;
        }

        public int Delete(string where, string what)
        {
            int retCode = 1; // спочатку вважаємо, що ми не знайшли місце(where) у нашому дереві
            for (Item i = this; i != null; i = i.nextItem) // переглядаємо поточний список нашого рівня
                                                     // кожного разу під чс виклику методу ми переходимо на  початок списку(begin)
            {
                if (i.name == where) // якщо ми знайшли нашу адресу у почтоному списку
                {                             // то виклаикаємо метод для додання даних до нашого підлегого списку 
                    retCode = i.DelFromList(what); // цей метод може повертати 0 - ОК, 1 - не знайдено
                } // якщо ми не знайшли нашу адресу у списку, торекурсивно переходимо на аналіз підлеглого списку
                else retCode = i.begin.Delete(where, what);// рекурсія з адресою(where) та інформиацією
            }
            return retCode;
        }
        public int DelFromList(string what)
        {
            int retCode = 0; // будемо вважати, що видалемо дані
            if (begin == end)
                retCode = 1;// підлеглий список пустий, тому немає що видаляти
            else // якщо список не пустий 
            {
                for (Item i = begin; i != null; i = i.nextItem) // починаємо переглядати підлеглий список
                {
                    if (i.name == what)
                    {
                        for(Item j = i; j.nextItem != null; j = j.nextItem)
                        {
                            j = j.nextItem;
                        }
                        //Item temp = i.nextItem;
                        //i = i.prevItem;
                        //i.nextItem = temp;
                    }
                }
            }
            return retCode;
        }

        /// <summary>
        /// GetInfo - формуємо з дерева рядок
        /// </summary>
        /// <returns>Повертає рядок з інформацією</returns>
        public string GetInfo()
        {
            string rezult = name; // спочатку у рядок заносимо назву вузла
            if (begin != null)
                rezult += " :\n"; // якщо є підлеглий список додаємо фігурну дужку

            for (Item t = begin; t != null; t = t.nextItem)// перебираємо усі вузли поточного рівня
            {
                rezult += t.GetInfo(); // рекурсивно перетворюємо у рядок підлеглі вузли
                if (t.nextItem != null)
                    rezult += " \n";
            }
            if (begin != null)
                rezult += ".";  // в кінці крапка

            return rezult;
        }
    };
}
