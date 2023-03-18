using System.Collections;
using System.Text.RegularExpressions;
using Thunderquack.Huification.Exceptions;

namespace Thunderquack.Huification
{
    public static class Huification
    {
        public static string Huificate(this string str)
        {
            string lastWord = GetLastWord(str);
            Regex regex = new Regex(@"^[\p{IsCyrillic}]+$");
            bool containsCyrillic = regex.IsMatch(lastWord);
            if (!containsCyrillic)
            {
                throw new NotCyrillicException();
            }
            return HuificateWord(lastWord);
        }

        private static string GetLastWord(string st)
        {
            string[] words = st.Split(' ');
            if (words.Length == 0)
            {
                throw new TooShortStringException();
            }
            return words[words.Length - 1];
        }

        private static string HuificateWord(string word)
        {
            char[] vowels = { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё' };
            Hashtable diff = new Hashtable
            {
                { 'у', 'ю' },
                { 'а', 'я' },
                { 'о', 'ё' },
                { 'э', 'е' },
                { 'ы', 'и' }
            };
            int len = word.Length;
            int vowelscount = 0;
            bool start = true;
            int startindex = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        vowelscount++;
                        if (start)
                        {
                            start = false;
                            startindex = i;
                        }
                    }
                }
            }
            if (vowelscount > 1)
            {
                if (vowelscount > 3)
                {
                    int idx = 0;
                    for (int i = len - 1; i > -1; i--)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (word[i] == vowels[j])
                            {
                                idx++;
                                if (idx == 3)
                                {
                                    startindex = i;
                                    break;
                                }
                            }
                        }
                        if (idx == 3)
                        {
                            break;
                        }
                    }
                }
                string newword = word.Substring(startindex + 1);
                if (diff.ContainsKey(word[startindex]))
                {
                    newword = "ху" + diff[word[startindex]] + newword;
                }
                else
                {
                    newword = "ху" + word[startindex] + newword;
                }
                return newword;
            }
            else
            {
                throw new NotEnughVowels();
            }
        }
    }
}