#include<iostream>
//1117������ȥ��
using namespace std;
int main()
{
    int n;
    int a[20001];
    bool b[20001];
    int i,j;
 
    cin>>n;//���������Сn
    for(i=1; i<=n; i++)
    {
        cin>>a[i];//����Ԫ��
        b[i]=true;//��ʼ��Ϊû���ظ�
    }
 
    for(i=1; i<=n; i++)
        if(b[i])//�ж�a[i]�Ƿ񱻱��Ϊ�ظ�
            for(j=i+1; j<=n; j++) //Ѱ��a[i]���Ƿ����ظ�����
                if(a[i]==a[j])//������ظ�����
                    b[j]=false;//���Ϊ�������
 
    for(i=1; i<=n; i++) //���û���ظ�����
        if(b[i]==true)
            cout<<a[i]<<" ";
    cout<<endl;
 
    return 0;
}
