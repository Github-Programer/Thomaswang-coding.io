#include <iostream>
using namespace std;
int main()
{
	char symbol;
    cin >> symbol;
    switch(symbol) {
      case  '+' :cout << "+" << endl;
      case  '-' :cout << "-" << endl;
      case  '*' :cout << "*" << endl;
      case  '/' :cout << "/" << endl;
      default:cout <<  "INPUT INVALID" ;
    }
	return 0;
}
