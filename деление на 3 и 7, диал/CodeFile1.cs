using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class UsingIfDemo
{
    static void Main()
    {
        try
        {
            int number;
            number = Int32.Parse(Interaction.InputBox("Введите число: ", "Ввод"));

            if (number % 3 == 0 && number % 7 == 0) MessageBox.Show("Введенное число делится на 3 и 7", "Проверка деления числа на 3 и 7");
            else MessageBox.Show("Число не подходит, введите другое");
        }
        catch
        {
            MessageBox.Show("Введите целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Программа завершена", "Завершение");
        }
    }
}
   
