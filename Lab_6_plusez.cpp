#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;
const int n = 10;


void PrintInfMasMatr(int  mas[10], int  matr[10][10])
{

    //check inf
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cout << matr[i][j] << " \t";
        }
        cout << endl;
    }
    cout << endl;

    cout << "mas:  ";
    for (int i = 0; i < n; i++) {
        cout << mas[i] << "  ";
    }
    cout << endl;

    //zeros to matr
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            matr[i][j] = 0;
        }
    }
}

int NewDigit(int chislo, int razr)
{
    while (razr > 1)
    {
        chislo /= 10;
        razr--;
    }
    return chislo % 10;
}

void SortRazr(int matr[n][n], int mas[n], int razr)
{
    int masCol[n], temp = 0;
    for (int i = 0; i < n; i++)
        masCol[i] = 0;

    //забиваем матрицу по числам
    for (int i = 0; i < n; i++)
    {
        int a = NewDigit(mas[i], razr); 
        matr[masCol[a]][a] = mas[i];
        masCol[a]++;
    }

    //забивка массива
    for (int i = 0; i < n; i++)
        for (int j = 0; j < masCol[i]; j++)
        {
            mas[temp] = matr[j][i];
            temp++;
        }

    PrintInfMasMatr(mas, matr);
}


int main()
{
    int razr, i;
    int mas[n]; // = { 4,56,78,190,2 };
    int matr[n][n];

    //rand inf to mas
    srand(time(NULL));
    for (int i = 0; i < n; i++) {
        mas[i] = rand() % 1000;
    }

    //zeros to matr
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            matr[i][j] = 0;
        }
    }

    //sort algorithm R
    for (razr = 1; razr < 4; razr++) {
        cout << "Rozrad: " << razr << endl;
        SortRazr(matr, mas, razr);
    }

    return 0;
}


