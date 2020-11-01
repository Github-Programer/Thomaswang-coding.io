#include<iostream>  
using namespace std;
int compare(string s1, string s2);
int main()
{
    string str1, str2;
    int a[250], b[250], len;
    int i;
    memset(a, 0, sizeof(a));
    memset(b, 0, sizeof(b));
    cin >> str1 >> str2;
    a[0] = str1.length();
    for (i = 1; i <= a[0]; i++)
        a[i] = str1[a[0] - i] - '0';
    b[0] = str2.length();
    for (i = 1; i <= b[0]; i++)
        b[i] = str2[b[0] - i] - '0';
    if ((compare(str1, str2)) == 0)  //大于等于，做按位减，并处理借位。  
    {
        for (i = 1; i <= a[0]; i++)
        {
            a[i] -= b[i];
            if (a[i] < 0) { a[i + 1]--; a[i] += 10; }
        }
        a[0]++;
        while ((a[a[0]] == 0) && (a[0] > 1)) a[0]--;
        for (i = a[0]; i >= 1; i--)
            cout << a[i];
        cout << endl;
    }
    else
    {
        cout << '-';  //小于就输出负号  
        for (i = 1; i <= b[0]; i++)  //做按位减，大的减小的  
        {
            b[i] -= a[i];
            if (b[i] < 0) { b[i + 1]--; b[i] += 10; }
        }
        b[0]++;
        while ((b[b[0]] == 0) && (b[0] > 1)) b[0]--;
        for (i = b[0]; i >= 1; i--)
            cout << b[i];
        cout << endl;
    }
    return 0;
}
int compare(string s1, string s2)  //比较字符串（两个数）数字的大小，大于等于返回0，小于返回1。  
{
    if (s1.length() > s2.length()) return 0;  //先比较长度，哪个字符串长，对应的那个数就大  
    if (s1.length() < s2.length()) return 1;
    for (int i = 0; i <= s1.length(); i++)  //长度相同时，就一位一位比较。  
    {
        if (s1[i] > s2[i]) return 0;
        if (s1[i] < s2[i]) return 1;
    }
    return 0;   //如果长度相同，每一位也一样，就返回0，说明相等  
}