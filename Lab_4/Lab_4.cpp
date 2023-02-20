#include <iostream>

using namespace std;

class Item // клас абстрактного вузла будь-якого рівня
{
public:
    string name;         // власне інформація вузла дерева
    Item* nextItem, *prevItem;     // наступний елемент списку цього рівня
    Item* begin, * end; // початок та кінець підлеглого списку

    Item(string Name) // конструктор
    {
        name = Name;   // заносимо у вузол інформацію
        prevItem = nextItem = begin = end = 0;  // обнуляємо все
    }
    /// <summary>
    /// int Add Метод додавання елементу
    /// </summary>
    /// <param name="where">where - куди будемо вставляти елемент</param>
    /// <param name="what">what - що будемо вставляти</param>
    /// <returns>Повертає 0 коли ОК, 1 - коли не знайшли місце, куди будемо писати дані, 2   - коли дані за такою адресою вже записані</returns>
    int Add(string where, string what) 
    {
        int retCode = 1; // спочатку вважаємо, що ми не знайшли місце(where) у нашому дереві
        for (Item* i = this; i; i = i->nextItem) // переглядаємо поточний список нашого рівня
            // кожного разу під чс виклику методу ми переходимо на  початок списку(begin)
        {
            if (!where.compare(i->name)) // якщо ми знайшли нашу адресу у почтоному списку
            {                             // то виклаикаємо метод для додання даних до нашого підлегого списку 
                retCode = i->AddToList(what); // цей метод може повертати 2 - якщо у списку вже є what
                // або 0 після внесення даних підлеглий список
            } // якщо ми не знайшли нашу адресу у списку, торекурсивно переходимо на аналіз підлеглого списку
            else retCode = i->begin->Add(where, what);// рекурсія з адресою(where) та інформиацією
        }
        return retCode;
    }
    /// <summary>
    /// int AddToList - метод дадовання даних до підлеглого списку нашого вузла
    /// </summary>
    /// <param name="what">what - що будемо вставляти</param>
    /// <returns>Повертає 0 коли ОК, 1 - коли не знайшли місце, куди будемо писати дані, 2   - коли дані за такою адресою вже записані</returns>
    int AddToList(string what)
    {
        Item* t = new Item(what); //  стіворюємо нновий вузол
        int retCode = 0;             // будемо вважати, що додамо дані
        if (begin == end && !end)  begin = end = t;// підлеглий список пустий, тому створюємо список з одного  нового елементу
        else // якщо список не пустий 
        {
            for (Item* i = begin; i; i = i->nextItem) // починаємо переглядати підлеглий список
            {
                if (!what.compare(i->name))
                {
                    delete t;    // звільняємо пам'ять ,тому що новий вузол нам не потрібний
                    retCode = 2; // якщо знайшли такі ж дані як і what
                    // утворюємо  код 2
                }
            }
            if (!retCode) // якщо дані не було знайдено у нашому списку 
                // то ми просто додаємо новий вузол у кінець підлеглого списку
            {
                Item* temp = end;
                end->nextItem = t;  
                end = t;
                end->prevItem = temp;
            }
        }
        return retCode;
    }
    /// <summary>
    /// bool Delete - метод видалення елементу
    /// </summary>
    /// <param name="where">where - звідки видаляти</param>
    /// <param name="what">what - Що видаляти</param>
    /// <returns></returns>
    bool Delete(string where, string what)
    {
        bool retCode = 1; // спочатку вважаємо, що ми не знайшли місце(where) у нашому дереві
        for (Item* i = this; i; i = i->nextItem) // переглядаємо поточний список нашого рівня
            // кожного разу під чс виклику методу ми переходимо на  початок списку(begin)
        {
            if (!where.compare(i->name)) // якщо ми знайшли нашу адресу у почтоному списку
            {                             // то виклаикаємо метод для додання даних до нашого підлегого списку 
                retCode = i->DelFromList(what); // цей метод може повертати 0 - ОК, 1 - не знайдено
            } // якщо ми не знайшли нашу адресу у списку, торекурсивно переходимо на аналіз підлеглого списку
            else retCode = i->begin->Delete(where, what);// рекурсія з адресою(where) та інформиацією
        }
        return retCode;
    }
    /// <summary>
    /// bool DelFromList - метод видалення елементу з підсписку
    /// </summary>
    /// <param name="what">what - те що буде видалено</param>
    /// <returns></returns>
    bool DelFromList(string what)
    {
        bool retCode = 0;             // будемо вважати, що видалемо дані
        if (begin == end && !end)  
            retCode = 1;// підлеглий список пустий, тому немає що видаляти
        else // якщо список не пустий 
        {
            for (Item* i = begin; i; i = i->nextItem) // починаємо переглядати підлеглий список
            {
                if (!what.compare(i->name))
                {
                    if (i->prevItem == NULL) {
                        begin = i->nextItem;
                    }
                    else if (i->nextItem == NULL) {
                        end = i->prevItem;
                    }
                    else {
                        Item* itemPrev = i->prevItem;
                        itemPrev->nextItem = i->nextItem;
                        end = end->prevItem;
                    }
                }
            }
            if (!retCode) // якщо дані не було знайдено у нашому списку немає що вмдалять
            {
                retCode = 1;
            }
        }
        return retCode;
    }

    /// <summary>
    /// GetInfo - формуємо з дерева рядок
    /// </summary>
    /// <returns>Повертає рядок з інформацією</returns>
    string GetInfo()
    {
        string rezult = name; // спочатку у рядок заносимо назву вузла
        if (begin) rezult += " :\n"; // якщо є підлеглий список додаємо фігурну дужку
        for (Item* t = begin; t; t = t->nextItem)// перебираємо усі вузли поточного рівня
        {
            rezult += t->GetInfo(); // рекурсивно перетворюємо у рядок підлеглі вузли
            if (t->nextItem)rezult += " \n";// додаємо  пробіл
        }
        if (!begin)  rezult += ".";  // в кінці крапка
        return rezult;
    }
};

int main()
{
    string bookName, where, what;
    bool checkWhere;

    cout << "Input title of a book" << endl;
    cin >> bookName;

    Item book(bookName);
    where = bookName;
    cout << "Now your start way is" << where << endl;

    int choose;
    while (true)
    {
        cout << endl << "Add - 0, Del - 1, 2 - exit" << endl;
        cin >> choose;
        switch (choose) {
        case 0:

            bool changeWhere;
            cout << "1 - change where, 0 - don`t" << endl;
            cin >> changeWhere;
            if (changeWhere) {
                cout << "Input where to add" << endl;
                cin >> where;
            }

            cout << "Add to  " << where << endl;
            cin >> what;

            book.Add(where, what);
            cout << "\n " << book.GetInfo();
            break;
        case 1:
            cout << "Where to delete" << endl;
            cin >> where;
            cout << "Del From" << where << endl;
            cin >> what;
            book.Delete(where, what);
            cout << "\n " << book.GetInfo();
            break;
        case 2:
            return 0;
        }
    }
    return 0;
}

