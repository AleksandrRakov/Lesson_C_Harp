int Max(int arg1, int arg2, int arg3, int arg4)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    return result;
}

int a1 = 23;
int a2 = 21;
int a3 = 62;
int a4 = 8;
int a5 = 19;
int a6 = 33;
int a7 = 13;
int a8 = 42;
int a9 = 52;
int a10 = 5;
int a11 = 99;
int a12 = 76;
int a13 = 45;
int a14 = 66;
int a15 = 82;
int a16 = 100;

// int max1 = Max(a1, a2, a3, a4);
// int max2 = Max(a5, a6, a7, a8);
// int max3 = Max(a9, a10, a11, a12);
// int max4 = Max(a13, a14, a15, a16);
// int max = Max(max1, max2, max3, max4);

int max = Max
(  Max(a1, a2, a3, a4), 
   Max(a5, a6, a7, a8),
   Max(a9, a10, a11, a12),
   Max(a13, a14, a15, a16));


Console.WriteLine(max);

