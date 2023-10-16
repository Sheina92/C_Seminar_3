// Написать код, который принимает на вход пятизначное число number и проверяет,
// является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine("True");
  }
  else Console.WriteLine("False");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else {
    Console.WriteLine("Число не пятизначное");
    Console.WriteLine("False");
}






