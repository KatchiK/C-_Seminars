
// Унарные операторы - 1 операнд

// Бинарные операторы -2 операнда


// Постфиксной: "после" а++

// Префиксный оператор: "перед" ++а


int a = 1;

int prefixIncrement = ++a * a;

Console.WriteLine(prefixIncrement); // Наибольший приоритет

int b = 1; 
int postfixIncrement = b++ * b; // наименьший приоритет
Console.WriteLine(postfixIncrement);