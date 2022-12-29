// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.


string Prompt(string message) {
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}
void ShowArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
string[] CreateArray() {   
    int count = 0;
    string value = String.Empty;
    string[] secondArray = new string[50];
    Console.WriteLine($"Введите 'exit' для завершения ввода");
    for (count = 0; value != "exit"; count++) {
        value = Prompt($"Введите {count+1}-ое значение ");
        if (value != "exit") {
            secondArray[count] = value;
        }
    }
    string[] array = new string[count-1];
    for (int i = 0; i < array.Length; i++) {
         array[i] = secondArray[i];
    }
    return array;
}
string[] CheckArray(string[] array) {   
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++) { 
        if (array[i].Length <= 3) count++;
    }
    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++) { 
        if (array[j].Length <= 3) {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}

string[] array = CreateArray();
Console.Write("Полученные данные: ");
ShowArray(array);
Console.Write("Результат: ");
ShowArray(CheckArray(array));
