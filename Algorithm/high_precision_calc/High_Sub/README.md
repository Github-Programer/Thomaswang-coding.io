# 高精度减法(High Accuracy Algorithm of subtraction)

## 逻辑



## 代码的不同写法

长得不一样，但是逻辑是一样的。

```java
#include <iostream>
#include <cstdio>
#include <cstring>
using namespace std; 
int a[200000],b[200000];
//自定义函数，比较两个字符串数字大小，大于等于返回true，小于返回false 
bool compare(string str1,string str2)
{
	//先比较长度
	if(str1.length()>str2.length())	//字符串长的对应的数就大 
		return true;
	else if(str1.length()<str2.length())	//字符串短的对应的数就小 
		return false;
	else	//字符串长度相等时一位一位的比 
	{
		for(int i=1;i<=str1.length();i++)
		{
			if(str1[i]>str2[i])
				return true;
			else if(str1[i]<str2[i])
				return false;
		}
	}
	return true;	//长度相等且每一位的数也相等，返回false
}
int main() 
{
	string s1,s2;
	memset(a,0,sizeof(a));	//数组初始化 
	memset(b,0,sizeof(b));
	cin>>s1>>s2;	//输入字符串
	a[0]=s1.length();	//第一个字符串的长度存入a[0]
	for(int i=1;i<=a[0];i++)//把第一个字符串转换为整数，存放在数组a
		a[i]=s1[a[0]-i]-'0';
	b[0]=s2.length();	//第二个字符串的长度存入b[0]
	for(int i=1;i<=b[0];i++)//把第二个字符串中转换为整数，存放在数组b
		b[i]=s2[b[0]-i]-'0';
	if(compare(s1,s2))	//第一个字符串大于等于第二个，做按位减，并处理借位 
	{
		for(int i=1;i<=a[0];i++)
		{
			a[i]-=b[i];
			if(a[i]<0)	
			{
				a[i+1]--;
				a[i]+=10;
			}
		}
		a[0]++;	
		while((a[a[0]]==0)&&(a[0]>1))	//清除前导零 
			a[0]--;
		for(int i=a[0];i>=1;i--)	//前面反向存入数组，现在反向输出
			printf("%d",a[i]);
		printf("\n");
	}
	else
	{
		printf("-");	//小于则先输出负号 
		for(int i=1;i<=b[0];i++)
		{
			b[i]-=a[i];
			if(b[i]<0)
			{
				b[i+1]--;
				b[i]+=10;
			}
		}
		b[0]++;
		while((b[b[0]]==0)&&(b[0]>1))	//清除前导零 
			b[0]--;
		for(int i=b[0];i>=1;i--)	//反向输出 
			printf("%d",b[i]);
		printf("\n");
	}
	return 0;
}
```

如下是我的代码，带了很多注释

```cpp
#include <iostream>
#include <string>
using namespace std;
int compare(string s1, string s2); // 比较函数
int main()
{
    string str1, str2; // 输入的字符串
    int a[250], b[250], len; // 转存的数组
    int i;
    memset(a, 0, sizeof(a));
    memset(b, 0, sizeof(b)); // 全部清零
    cin >> str1 >> str2;
    a[0] = str1.length(); // 吹牛B，长度获取
    for (i = 1; i <= a[0]; i++)
        a[i] = str1[a[0] - i] - '0'; // 字符串按位转数组(ﾉ"◑ ◑)ﾉ"(｡•́︿•̀｡)
    b[0] = str2.length();
    for (i = 1; i <= b[0]; i++)
        b[i] = str2[b[0] - i] - '0'; // 倒序存储，这样可以让各位对齐，不需要前面补零
    // 给a[0] 和 b[0] 赋予长度，因为从1开始，也可以使用两个int len存储
    // 基本操作已经完成，下面是正式减法
    if ((compare(str1, str2)) == 0) //大于等于，做按位减，并处理借位。
    { // 如果第一个数字大于第二个数字执行这一段，否则执行负数段
        for (i = 1; i <= a[0]; i++) // 在长度内循环
        {
            a[i] -= b[i]; // 由于确定了大小，直接减掉
            if (a[i] < 0) // 也就是如果a[i] 的值小于 b[i]的值，减出一个负数
            {
                a[i + 1]--; // 后一位借位1
                a[i] += 10; // 当前位按十进制加10
            }
        }
        a[0]++; // 为了去0，加一位
        while ((a[a[0]] == 0) && (a[0] > 1))
        {
             // 如果都是零，比如10000-9999，倒叙是00001(000..)-99990(000..)=10000
             // 这里的四个零都要按照while的第一个判断去掉
             // 第二个a[0]>1是限制为0 保留一个，比如9999-9999=0000，总不能全部扔掉，需要留下一个0
            a[0]--; // 长度减一，为了输出
        }
        for (i = a[0]; i >= 1; i--)
            cout << a[i]; // 倒序输出
        cout << endl;
    }
    else
    {
        cout << '-';                //小于就输出负号
        for (i = 1; i <= b[0]; i++) //做按位减，大的减小的
        {
            b[i] -= a[i]; // 有理数法则，既然b[]>a[]，那就加负号然后b-a
            if (b[i] < 0) // 借位操作
            {
                b[i + 1]--;
                b[i] += 10; // 依然如故
            }
        }
        b[0]++;
        while ((b[b[0]] == 0) && (b[0] > 1))
            b[0]--;
        for (i = b[0]; i >= 1; i--)
            cout << b[i];
        cout << endl; // 如上操作
    }
    return 0;
}
int compare(string s1, string s2) //比较字符串（两个数）数字的大小，大于等于返回0，小于返回1。
{
    if (s1.length() > s2.length())
        return 0; //先比较长度，哪个字符串长，对应的那个数就大
    if (s1.length() < s2.length())
        return 1;
    for (int i = 0; i <= s1.length(); i++) //长度相同时，就一位一位比较。
    {
        if (s1[i] > s2[i])
            return 0;
        if (s1[i] < s2[i])
            return 1;
    }
    return 0; //如果长度相同，每一位也一样，就返回0，说明相等
}
```

```cpp
// C = A - B, 满足 A >= B, A >= 0, B >= 0
bool cmp(vector<int>& A, vector<int>& B){ // 判断A是否>=B
    if(A.size() != B.size()) // 先比较A和B的位数
        return A.size() > B.size();
    for(int i = A.size() - 1; i >= 0; i --)
        if(A[i] != B[i])
            return A[i] > B[i];
    return true;
}

vector<int> sub(vector<int>& A, vector<int>& B){
    vector<int> C;
    int t = 0;
    for(int i = 0; i < A.size(); i ++){
        t = A[i] - t;
        if(i < B.size()) // 如果B里面还有数
            t -= B[i];
        C.push_back((t + 10) % 10); // 若t < 0, 就应该取(t + 10), 否则，取t, 合并起来就是((t + 10) % 10)
        if(t < 0) // 如果有借位
            t = 1;
        else
            t = 0;
    }
    while(C.size() > 1 && C.back() == 0) // 处理前导0
        C.pop_back();
    return C;
}
```

