//++++++++++++++ ЗАДАЧА № 1 ++++++++++++++
// // рекурсия вывода от N до 1
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine());
// string result = PrintNumb(N);
// Console.WriteLine(result);

// string PrintNumb(int n){
//     if (n <= 0){
//         return "";
//     }
//     if (n == 1){
//         return "1";
//     }
//     return $"{PrintNumb(n - 1)}, {n}";
// }
//++++++++++++++ ЗАДАЧА № 2 ++++++++++++++
// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine());
// int sum = SumRange(M, N);
// Console.WriteLine($"Сумма чисел от {M} до {N} равна {sum}");

// int SumRange(int m, int n){
//     if (m > n){
//     return 0;
//     }
//     if (m == n){
//     return m;
//     }
//     return m + SumRange(m + 1, n);
// }
//++++++++++++++ ЗАДАЧА № 3 ++++++++++++++
// Функция Аккермана
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

int result = aker(M, N);
Console.WriteLine($"Функция Аккермана для m = {M} и n = {N} равна {result}");

int aker(int M, int N){
    if (M == 0){
        return N + 1;
        }
        else if (M > 0 && N == 0){
        return aker(M - 1, 1);
        }
        else{
        return aker(M - 1, aker(M, N - 1));
        }
}