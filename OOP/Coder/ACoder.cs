
namespace OOP
{
    public class ACoder : ICoder
    {

       

        public string Encode(string text)
        {
            string result = "";
            char[] letter = text.ToCharArray();

            for (int i = 0; i < letter.Length; i++)
            {
                //Если не латиница и не кириллица
                if (((int)(letter[i]) < 65) || ((int)(letter[i]) > 90)&&
                    ((int)(letter[i]) < 97) || ((int)(letter[i]) > 122) &&
                    ((int)(letter[i]) < 1040) || ((int)(letter[i]) > 1103))
                    result += letter[i];
                //Если буква является строчной
                if ((Convert.ToInt16(letter[i]) >= 97) && (Convert.ToInt16(letter[i]) <= 122))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(letter[i]) + 1 > 122)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) + 1 - 26);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) + 1);
                }
                //Если буква является прописной
                if ((Convert.ToInt16(letter[i]) >= 65) && (Convert.ToInt16(letter[i]) <= 90))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(letter[i]) + 1 > 90)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) + 1 - 26);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) + 1);
                }
                //Если буква является строчной
                if ((Convert.ToInt16(letter[i]) >= 1072) && (Convert.ToInt16(letter[i]) <= 1103))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(letter[i]) +1 > 1103)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) +1 - 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) + 1);
                }
                //Если буква является прописной
                if ((Convert.ToInt16(letter[i]) >= 1040) && (Convert.ToInt16(letter[i]) <= 1071))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(letter[i]) + 1 > 1071)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) + 1 - 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(letter[i]) + 1);
                }
            }
            return new string(result);
        }
    }
}