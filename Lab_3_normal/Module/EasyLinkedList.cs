using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_normal.Module
{
    public class EasyLinkedList
    {
        int key;
        LinkedList<Item> myList;
        
        public LinkedList<Item> MyList
        {
            get { return myList; }
            set { myList = value; }
        }
        public EasyLinkedList(int key)
        {
            this.key = key;
            myList = new LinkedList<Item>();
        }
        public int Key
        {
            get { return key; }
        }
        /// <summary>
        /// AddLastEl(Item el) - Додає елементв кінець
        /// </summary>
        /// <param name="el">el - елемент, що буде додано</param>
        public void AddLastEl(Item el)
        {
            myList.AddLast(el);
        }
        /// <summary>
        /// RemoveEl - Видаляє елемент
        /// </summary>
        /// <param name="el">el - елемент, що буде видалено</param>
        public void RemoveEl(Item el)
        {
            myList.Remove(el);
        }
        /// <summary>
        /// FirstEl() - Знаходить перший елемент
        /// </summary>
        /// <returns>Повертає: перший елемент</returns>
        public string FirstEl()
        {
            return myList.First().Inf;
        }
        /// <summary>
        /// Find(string s): Пошук елементу
        /// </summary>
        /// <param name="s">s - елемент, що шукається</param>
        /// <returns>Повертає: знайдений елемент типу Item</returns>
        public Item Find(string s)
        {
            Item res = null;
            foreach (Item it in myList)
                if (it.Inf == s)
                    res = it;
            return res;
        }
        /// <summary>
        /// Check() - Перевірка
        /// </summary>
        /// <returns> Повертає: bool значення чи пустий LinkedList(підсписок)</returns>
        public bool Check()
        {
            bool res = false;

            foreach (Item it in myList)
                if (it.Inf != null)
                    res = true;
            return res;
        }
        /// <summary>
        /// KeyEqual(int key) - Отримання індексу через ключ
        /// </summary>
        /// <param name="key">key - ключ</param>
        /// <returns>Повертає: індекс</returns>
        public bool KeyEqual(int key)
        {
            bool res = false;
            if (Key == key)
                res = true;
            return res;

        }
        /// <summary>
        ///  override string ToString() - Розширення стандартного методу ToString - перетворює список в рядок: записує ключ та всі елементи списку
        /// </summary>
        /// <returns>Повертає: рядок з інформацією зі списку</returns>
        public override string ToString()
        {
            //string res = indList.ToString() + " -> ";
            string res = key.ToString() + " -> ";
            if (MyList.Count > 0)
                foreach (Item el in MyList)
                    res += el.ToString();
            return res;
        }
    }
}



/// <summary>
/// Знайти елемент через int value
/// </summary>
/// <param name="elToDel"></param>
/// <returns></returns>
//public Item Find(int elToDel)
//{
//    Item res = null;

//    foreach (Item it in myList)
//        if (myList.Contains(it.inf))
//            res = it;

//    return res;
//}