namespace TicTacToe
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Field field = new Field();
            bool moveX = true;

            while (field.ItHaveEmptyBox() && !field.CheckWin())
            {
                Console.WriteLine("Игровое поле:");
                field.DrawField();
                Console.WriteLine((moveX ? "Ход крестиков" : "Ход ноликов") + ", введите координаты через запятую:");
                string? str = Console.ReadLine();

                try
                {
                    string[] split = str.Split(",");
                    int i = int.Parse(split[0]);
                    int j = int.Parse(split[1]);
                    char c = moveX ? 'x' : 'o';

                    if (field.AddWalk(i, j, c))
                    {
                        moveX ^= true;
                    }
                    else
                    {
                        Console.WriteLine("Введены не корректные координаты");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Неверное количество координат");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат координат");
                }

                Console.WriteLine("");
            }
            if (field.ItHaveEmptyBox() || field.CheckWin())
                Console.WriteLine("Победили " + (!moveX ? "крестики" : "нолики") + '!');
            else
                Console.WriteLine("Ничья");
            field.DrawField();
        }
    }
}