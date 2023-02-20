#include <iostream>
#include <ctime>
#include <cstdlib>
#include <chrono>
#include <ratio>
#include <thread>
using namespace std;
using namespace chrono;
const int n = 500;

struct Structure
{
    int Key;
    int Value;

    Structure(){ }
    Structure(int key, int value)
    {
        Key = key;
        Value = value;
    }
};

int NewDigit(int chislo, int razr)
{
    while (razr > 1)
    {
        chislo /= 10;
        razr--;
    }
    return chislo % 10;
}
void SortRazr(int matr[n][n], Structure mas[n], int razr)
{
    int masCol[n], temp = 0;
    for (int i = 0; i < n; i++)
        masCol[i] = 0;

    //забиваєм матрицу по числам
    for (int i = 0; i < n; i++)
    {
        int a = NewDigit(mas[i].Key, razr);
        matr[masCol[a]][a] = mas[i].Key;
        masCol[a]++;
    }

    //забиваєм масив
    for (int i = 0; i < n; i++)
        for (int j = 0; j < masCol[i]; j++)
        {
            mas[temp].Key = matr[j][i];
            temp++;
        }
}


int main()
{
    Structure mas[n];
    int razr, i;
    int matr[n][n];

    auto startTime =  high_resolution_clock::now(), endTime = high_resolution_clock::now();;
    duration<double, milli> time_ms;


    //rand inf to mas
    srand(time(NULL));
    for (int i = 0; i < n; i++) {
        mas[i].Key = rand() % 111 + i;
        mas[i].Value = rand() % 1000;
    }


    //zeros to matr
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            matr[i][j] = 0;
        }
    }
    cout << "Size: " << n << endl;
    //inf
    /*for (int i = 0; i < 10; i++) {
        cout << "[key:" << mas[i].Key << ", value:" << mas[i].Value << "] " << endl;
    }
    cout << "----" << endl;*/


    //sort algorithm Rand
    cout << "Sorted Rand" << endl;
    startTime =  high_resolution_clock::now(); // ?????????? ???
    for (razr = 1; razr < 4; razr++) {
        SortRazr(matr, mas, razr);
    }
    endTime =  high_resolution_clock::now(); // ???????? ???
    /*for (int i = 0; i < 10; i++) {
        cout << "[key:" << mas[i].Key << ", value:" << mas[i].Value << "] " << endl;
    }*/
    time_ms = endTime - startTime;
    cout << "Time: " << time_ms.count() << " ms" << endl;
    //cout << "----" << endl;


    //sort algorithm R a-z
    cout << "Sort a-z" << endl;
    startTime = high_resolution_clock::now(); // ?????????? ???
    for (razr = 1; razr < 4; razr++) {
        SortRazr(matr, mas, razr);
    }
    endTime = high_resolution_clock::now(); // ???????? ???
    /*for (int i = 0; i < 10; i++) {
        cout << "[key:" << mas[i].Key << ", value:" << mas[i].Value << "] " << endl;
    }*/
    time_ms = endTime - startTime;
    cout << "Time: " << time_ms.count() << " ms" << endl;
    //cout << "----" << endl;


    //reverse
    Structure masRev[n];
    for (int i = 0; i < n; i++) {
        masRev[i] = mas[i];
    }
    int rev = n - 1;
    for (int i = 0; i < n; i++) {
        mas[i].Key = masRev[rev].Key;
        mas[i].Value = masRev[rev].Value;
        rev--;
    }


    //sort algorithm R z-a
    cout << "Sort z-a" << endl;
    startTime = high_resolution_clock::now();
    for (razr = 1; razr < 4; razr++) {
        SortRazr(matr, mas, razr);
    }
    endTime = high_resolution_clock::now(); // ???????? ???

    /*for (int i = 0; i < 10; i++) {
        cout << "[key:" << mas[i].Key << ", value:" << mas[i].Value << "] " << endl;
    }*/
    time_ms = endTime - startTime;
    cout << "Time: " << time_ms.count() << " ms" << endl;

    return 0;
}


