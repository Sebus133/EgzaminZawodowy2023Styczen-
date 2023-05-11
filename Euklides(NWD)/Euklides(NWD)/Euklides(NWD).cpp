

#include <iostream>
using namespace std;

int a=0;
int b=0;
int c=0;

void NWD(int a, int b) {
    if (a == b) {
        c = a;
    }
    else {
        while (a != b) {
            if (a > b) {
                a = a - b;
            }
            else {
                b = b - a;
            }
        }
        c = a;
    }
    c = a;
}

int main()
{
    cout << "Wprowadz liczbe dodatnia, calkowita a:";
    cin >> a;
    
        while (a < 0) {
            cout << "liczba jest ujemna , wprowadz dodatnia";
            cin >> a;
        }
        cout << "Wprowadz liczbe dodatnia, calkowita b:";
        cin >> b;
   
        while (b < 0) {
            cout << "liczba jest ujemna , wprowadz dodatnia";
            cin >> b;
        }

        NWD(a, b);
        cout << "nwd = ";
        cout << + c;
        
}