namespace AdventOfCode2023;

public class Day_1
{
    public static int Day1(string document)
    {
        string[] line = document.Split('\n');
        int result = 0;
        for (int i = 0; i < line.Length; i++)
        {
            int nb = 0;
            for (int j = 0; j < line[i].Length; j++)
            {
                if (Char.IsDigit(line[i][j]))
                {
                    nb = (line[i][j] - 48) * 10;
                    break;
                }
            }

            for (int j = line[i].Length-1; j >= 0; j--)
            {
                if (Char.IsDigit(line[i][j]))
                {
                    nb += line[i][j] - 48;
                    break;
                }
            }

            result += nb;
        }

        return result;
    }




}
