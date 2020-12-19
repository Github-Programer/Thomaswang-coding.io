#include <iostream>
#include <string>
#include <cstring>
#include <cstdio>
using namespace std;
int main()
{
	char str[101];
	gets(str);
	int len = strlen(str);
	for (int i = 0; i < len; i++)
	{
		if(str[i] >= 'A' && str[i] <= 'Y' || str[i] >= 'a' && str[i] <= 'y')
			str[i] += 1;
		else if(str[i]=='Z'||str[i]=='z')
            str[i]-=25;
	}
	puts(str);
	return 0;
 } 
// http://ybt.ssoier.cn:8088/problem_show.php?pid=1136
