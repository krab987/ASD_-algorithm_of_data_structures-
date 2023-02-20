using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_normal.Module
{
    public class EasyArrayList
    {
        ArrayList myArrayList;

        public EasyArrayList()
        {
            myArrayList = new ArrayList();
        }
        public ArrayList MyArrayList
        {
            get { return myArrayList; }
            set { myArrayList = value; }
        }
        /// <summary>
        /// AddEl(int index, EasyLinkedList el) - Метод, що додає підсписок до списку 
        /// </summary>
        /// <param name="index">index - індекс для ArrayList</param>
        /// <param name="el">el - елемент LinkedList(підсписку), що буде додано до ArraList(списку)</param>
        public void AddEl(int index, EasyLinkedList el) 
        {
            myArrayList.Insert(index, el);
        }
        /// <summary>
        /// RemoveEl(int i, string j) - Видаляє елемент
        /// </summary>
        /// <param name="i">i - індекс для ArrayList</param>
        /// <param name="j">j - елемент, що буде видалено</param>
        public void RemoveEl(int i, string j)
        {
            (myArrayList[i] as EasyLinkedList).RemoveEl((myArrayList[i] as EasyLinkedList).Find(j));
        }
        /// <summary>
        /// AddLastElem(int i, Item el) - Додає елемент до LinkedList(підсписку) за індексом
        /// </summary>
        /// <param name="i">i - індекс списку</param>
        /// <param name="el">el - елемент, що буде додано</param>
        public void AddLastElem(int i, Item el)
        {
            (myArrayList[i] as EasyLinkedList).AddLastEl(el);
        }
        /// <summary>
        /// FirstEl - Знаходження першого елементу
        /// </summary>
        /// <param name="i">i - індекс ArraList(списку)</param>
        /// <returns>Повертає: перший елемент LinkedList(підсписку) за індексом ArraList(списку)</returns>
        public string FirstEl(int i)
        {
            return (myArrayList[i] as EasyLinkedList).FirstEl();
        }
        /// <summary>
        /// Check(int i) - Перевірка чи пустий підсписок
        /// </summary>
        /// <param name="i">i - індекс для ArraList(списку)</param>
        /// <returns>Повертає: true/false значення - чи пустий зазначений підсписок</returns>
        public bool Check(int i)
        {
            return (myArrayList[i] as EasyLinkedList).Check();
        }
        /// <summary>
        /// GetIndex(int key) - Дізнатись індекс по ключу
        /// </summary>
        /// <param name="key">key - ключ, по якомй знайдемо значення індексу</param>
        /// <returns>Повертає: індекс ArraList(списку)</returns>
        public int GetIndex(int key)
        {
            int res = -1;

            for (int i = 0; i < myArrayList.Count; i++)
            {
                if ((myArrayList[i] as EasyLinkedList).KeyEqual(key))
                    res = i;
            }
            return res;
        }
    }
}


//public void RemoveEl2(int i, int j)// remove from i list j pidlist
//{
//    (myArrayList[i] as EasyLinkedList).RemoveEl((myArrayList[i] as EasyLinkedList).Find(j));
//}