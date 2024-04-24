using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson11
{
    public class Exercises
    {
        /*Вам дан массив строк words и строковая приставка pref.
    Выведите на консоль количество строк в words, содержащих pref в качестве префикса.
    Префиксом строки s является любая непрерывная подстрока строки s.
    Пример: words = ["pay","attention","practice","attend"], pref = "at" => 2*/
        public void FindAtPrefix(string[] words, string pref)
        {
            int count = 0;

            foreach (string word in words)
            {
                if (word.StartsWith(pref))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество строк: {count}");
        }

        /*Вам даны строка s и индексы целочисленного массива одинаковой длины.
        Строка s будет перетасована так, что символ в i-й позиции переместится на индекс[i] в перетасованной строке.
        Выведите на консоль перетасованную строку.
        Пример: tenstdu, [3,4,6,5,1,2,0] => student*/
        public void StringShuffle(string word, int[] indexers)
        {
            char[] arrayChar = new char[word.Length];

            for (int i = 0; i < arrayChar.Length; i++)
            {
                arrayChar[i] = word[indexers[i]]; 
            }

            Console.WriteLine(new string(arrayChar));
        }

        /*Вам дан целочисленный массив nums, переместите все 0 в его конец, сохраняя относительный порядок ненулевых элементов.
        Обратите внимание, что вы должны сделать это на месте, не копируя массив.
        Пример: nums = [0,1,0,3,12] => [1,3,12,0,0]*/
        public void MoveZeroes(int[] nums)
        {
            var left = 0;

            for (var right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                    left++;
                }
            }
        }

        /*Вам дана строка word, поменяйте местами только все гласные в строке и верните ее в консоль.
        Гласные: a e i o u и они могут встречаться как в нижнем, так и в верхнем регистре более одного раза.
        Пример: string word = "hellO" => "hOlle"*/
        public void ReverseVowels(string word)
        {
            var vowels = "äeiouAEIOU";

            var extractedVowels = word.Where(ch => vowels.Contains(ch)).Reverse().ToArray();

            var result = word.ToCharArray();

            var v = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    result[i] = extractedVowels[v];
                    v++;
                }
            }

            Console.WriteLine(new string(result));
        }
    }
}