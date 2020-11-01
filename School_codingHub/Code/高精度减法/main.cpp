
int a[1000], b[1000];
char sa[1000], sb[10000];
int c[1000];
int f(int la, int lb)
{
    if (la>lb) return 1;//true
    if (la<lb) return 0;//false
    for (int i = la - 1; i >= 0; i--) {
        if (a[i]>b[i]) {
            return 1;
            break;
        }
        if (a[i]<b[i]) {
            return 0;
            break;
        }
    }
    return 1;
}
int largesub(char *sa, char *sb, int *c)//lc是c数组的元素个数
{
    int la, lb, lc;
    int t;
    la = strlen(sa);
    lb = strlen(sb);
    memset(a, 0, sizeof(a));
    memset(b, 0, sizeof(b));
    memset(c, 0, 1000*4);//一个整型是4个字节，所以要乘以4
    for (int i = 0; i < la; i++)
        a[la - i - 1] = sa[i] - '0';
    for (int i = 0; i < lb; i++)
        b[lb - i - 1] = sb[i] - '0';
    t = f(la, lb);
    if (la > lb) lc = la; else lc = lb;
    if (t == 1) {
        for (int i = 0; i < lc; i++) {
            if (a[i] < b[i]) { a[i + 1] -= 1; a[i] += 10; }
            c[i] = a[i] - b[i];
        }
        if (c[lc] > 0) lc++;
        if (lc >= 2 && c[lc - 1] == 0){
            while (c[lc - 1] == 0 && lc >= 2){
                c[lc - 1] = '\0';
                lc--;
            }
        }
    }
    if (t == 0) {
        for (int i = 0; i < lc; i++) {
            if (b[i] < a[i]) { b[i + 1] -= 1; b[i] += 10; }
            c[i] = b[i] - a[i];
        }
        if (c[lc] > 0) lc++;
        printf("-");
        if (lc >= 2 && c[lc - 1] == 0){
            while (c[lc - 1] == 0 && lc >= 2){
                c[lc - 1] = '\0';
                lc--;
            }
        }
    }
    return lc;
}

