// See https://aka.ms/new-console-template for more information
int len1, len2, min, max, num1, num2, i, j, k, val1, val2; 
Console.Write("Enter Length of Array 1:\t");
num1 = int.Parse(Console.ReadLine());
Console.Write("Enter Length of Array 2:\t");
num2 = int.Parse(Console.ReadLine());

int [] arr = new int [num1];
int [] brr = new int [num2];

for (i =0; i<num1; i++)
{
Console.Write($"Enter the value of {i+1} Position in Array 1:\t");
val1 = int.Parse(Console.ReadLine());
arr[i] = val1;
}

for (j =0; j<num2; j++)
{
Console.Write($"Enter the value of {j+1} Position in Array 2:\t");
val2 = int.Parse(Console.ReadLine());
brr[j] = val2;
}

len1 = arr.Length;
len2 = brr.Length;

if (len1 < len2)
{
min = len1;
max = len2;
}
else
{
min = len2;
max = len1;
}

int [] crr = new int [max];

for (k = 0; k < max; k++)
{
if (k < min)
{
crr[k] = arr[k]+brr[k];
}
else if (arr.Length == max)
{
crr[k] = arr[k];
}
else
{
crr[k] = brr[k];
}
}

foreach (int item in crr)
{
Console.Write(item+" ");
}
