using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace Thunderquack.Huification
{
    public static class Huification
    {
        /// <summary>
        /// Huificate the last word
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Huificated word</returns>
        public static string Huificate(this string str)
        {
            string lastWord = str.Split(' ').Last().ToLower();
            Regex regex = new Regex(@"^[\p{IsCyrillic}]+$");
            bool containsCyrillic = regex.IsMatch(lastWord);
            if (!containsCyrillic)
            {
                return string.Empty;
            }
            return HuificateWord(lastWord);
        }

        private static string HuificateWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return string.Empty;
            }

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
                for (int j = 0; j < vowels.Length - 1; j++)
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
                return string.Empty;
            }
        }
    }
}