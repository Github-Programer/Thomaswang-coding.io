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
//long���͵�������Ҫ��l���ַ���������ʱ����Ҫ&
	char *s;
	scanf("%s", &s);
	printf("%s\n", &s);
//�ַ��������[***]��ȷ�±�Ĳ���Ҫ&��ָ��������Ҫ&������Ҫ&��printf����Ҫ&
    return 0;
}
