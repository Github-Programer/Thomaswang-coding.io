#include<iostream>
#include<string>
#include<cstdio>
using namespace std;
 
void f(int i);
string str[101], a, b;
 
int main()
{
    int n =0;
    int i;
    char space;
 
    /*����������Ҫ����һ�����ʣ����ʹ��do-while�ṹ����*/
    do
    {
        n ++;
        cin >> str[n];//����һ�����ʣ��ַ��飩
        scanf("%c", &space);//����һ���ո�
    }
    while (space == ' ');
 
    cin >> a >> b;//������滻�ĵ�����Ҫ�滻�ĵ���
 
    for(i = 1; i <= n; i++) //�ӵ�һ�����ʿ�ʼö��
        f(i);//���ú��������жϣ��Ƿ���Ҫ�滻
 
    cout<<endl;
    return 0;
}
void f(int i)
{
    if(a == str[i])
        cout << b << " ";
    else
        cout << str[i] << " ";
}
