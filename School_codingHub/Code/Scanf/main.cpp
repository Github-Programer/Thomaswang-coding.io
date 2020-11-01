#include <cstdio>
#include <string>
#include <iostream>
using namespace std;
int main()
{
//    int a;
//    double b;
//    long c;
//    char d;
//    char s[101];
//    scanf("%d", &a);
//    scanf("%f", &b);
//    scanf("%d", &c);
//    scanf("%c", &d);
//    scanf("%s", &s);
//    cout << a << endl;
//    cout << b << endl;
//    cout << c << endl;
//    cout << d << endl;
//	char s[101];
//	scanf("%s", s);
//	printf("%s\n", s);
//long类型的数据需要加l，字符数组输入时不需要&
	char *s;
	scanf("%s", &s);
	printf("%s\n", &s);
//字符数组带有[***]明确下标的不需要&，指针数组需要&，都需要&，printf都需要&
    return 0;
}
