/*
Name: Minh Vu Hoang Nguyen
CPSC 463
M-W @ 8:30am

Triangle version 4
*/

#include<iostream>
#include<string>

using namespace std;

int main()
{
    int a, b, c;
    bool c1, c2, c3, IsATriangle;

    do
	{
        cout << "Enter 3 integers which are sides of a triangle" << endl;
        cin >> a;
        cin >> b;
        cin >> c;

        c1 = (1 <= a) && (a <= 300);
        c2 = (1 <= b) && (b <= 300);
        c3 = (1 <= c) && (c <= 300);

        if(!c1)
            cout << "Value of a is not in the range of permitted values" << endl;
        if(!c2)
            cout << "Value of b is not in the range of permitted values" << endl;
        if(!c3)
            cout << "Value of c is not in the range of permitted values" << endl;
	}while(!c1 || !c2 || !c3);
    
    cout << "Side A is " << a << endl;
    cout << "Side B is " << b << endl;
    cout << "Side C is " << c << endl;

    if((a < b + c) && (b < a + c) && (c < a + b))
        IsATriangle = true;
	else
        IsATriangle = false;
    
    if(IsATriangle)
	{
        if((a == b) && (b == c))
            cout << "Equilateral" << endl;
		else if ((c * c == a * a + b * b) || (a * a == c * c + b * b) || (b * b == a * a + c * c))
			cout << "Right triangle" << endl;
		else if ((a != b) && (a != c) && (b != c))
			cout << "Scalene" << endl;		
		else
            cout << "Isosceles" << endl;
	}
	else
        cout << "Not a Triangle" << endl;

    return 0;
}