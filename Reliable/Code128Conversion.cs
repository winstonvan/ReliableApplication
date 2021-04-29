using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reliable
{

    enum BarcodeTypes { ALLNUMEVEN, ALLNUMODD, ALLLETTER, THREECHAR, MIXFIRSTTHREE, MIXFIRSTFOUR};

    enum BarcodeSubTypes { MIDDLEEVEN, MIDDLEODD, ENDFOUR, ENDFIVE, ENDSIXEVEN, ENDSIXODD, EXACTCONVERSION, FIRSTEVEN, FIRSTODD };
    enum CharacterTypes { NUMBER, OTHER};

    class Code128Conversion
    {
        //Array required for code 128 conversion

        private static string[] codeArray = { " ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "\\", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{", "|", "}", "~", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê" };

        private string barcode;

        private string initialString;

        private BarcodeTypes category;

        public List<CharacterTypes> findTypeOfBarcode = new List<CharacterTypes>();

        //Constructor for conversion to Code 128. The type of the barcode is identified here.

        public Code128Conversion (string bCode)
        {

            foreach (char code in bCode)
            {

                if((int)code > 47 && (int)code < 58)
                {
                    findTypeOfBarcode.Add(CharacterTypes.NUMBER);
                }

                else
                {
                    findTypeOfBarcode.Add(CharacterTypes.OTHER);
                }

            }

            if (findTypeOfBarcode.Count <= 3)
            {
                category = BarcodeTypes.THREECHAR;
            }

            else if (!findTypeOfBarcode.Contains(CharacterTypes.OTHER))
            {
                if (findTypeOfBarcode.Count % 2 == 0)
                {
                    category = BarcodeTypes.ALLNUMEVEN;
                }

                else
                {
                    category = BarcodeTypes.ALLNUMODD;
                }
            }

            else if (!findTypeOfBarcode.Contains(CharacterTypes.NUMBER))
            {
                category = BarcodeTypes.ALLLETTER;
            }

            else if (findTypeOfBarcode[0] == CharacterTypes.NUMBER && findTypeOfBarcode[1] == CharacterTypes.NUMBER && findTypeOfBarcode[2] == CharacterTypes.NUMBER && findTypeOfBarcode[3] == CharacterTypes.NUMBER)
            {
                category = BarcodeTypes.MIXFIRSTFOUR;
            }

            else
            {
                category = BarcodeTypes.MIXFIRSTTHREE;
            }

            initialString = bCode;

        }

        public string GetBarcode()
        {
            return this.barcode;
        }

        public void ConvertToCode128()
        {
            if(this.category == BarcodeTypes.ALLNUMEVEN)
            {
                AllNumbersEven(this.initialString);
            }

            else if (this.category == BarcodeTypes.ALLNUMODD)
            {
                AllNumbersOdd(this.initialString);
            }

            else if (this.category == BarcodeTypes.ALLLETTER)
            {
                AllLetterCode(this.initialString);
            }

            else if (this.category == BarcodeTypes.THREECHAR)
            {
                ThreeCharactersOrLess(this.initialString);
            }

            else if (this.category == BarcodeTypes.MIXFIRSTTHREE)
            {
                MixFirstThreeOrLessNumbers(this.initialString);
            }

            else if (this.category == BarcodeTypes.MIXFIRSTFOUR)
            {
                MixFirstFourOrMoreNumbers(this.initialString);
            }
        }

        //Converts the barcode string into the propwer encoding for code128 id the barcode is longer than three digits, is all numbers, and has an even number of digits
        private void AllNumbersEven(string bCode)
        {
            int sum = 105;

            List<int> barcodeSum = new List<int>();

            for (int k = 0; k < bCode.Length; k++)
            {

                if (k == 0)
                {
                    barcode += "Í";
                }

                else if (k % 2 == 1)
                {
                    barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                    barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                }

                if (k == bCode.Length - 1)
                {

                    int indexMulti = 1;

                    foreach (int item in barcodeSum)
                    {

                        sum += (item * indexMulti);

                        indexMulti++;

                    }

                    barcode += codeArray[(sum % 103)];

                    barcode += "Î";
                }
            }

        }

        //Converts the barcode string into the proper encoding for code128 if the barcode is longer than three digits, is all numbers, and has an odd number of digits

        private void AllNumbersOdd(string bCode)
        {
            int sum = 105;

            List<int> barcodeSum = new List<int>();

            for (int k = 0; k < bCode.Length; k++)
            {

                if (k == 0)
                {
                    barcode += "Í";
                }

                else if (k % 2 == 1)
                {
                    barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                    barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                }

                if (k == bCode.Length - 1)
                {

                    int indexMulti = 1;

                    barcode += "È" + bCode[k].ToString();

                    barcodeSum.Add(100);

                    barcodeSum.Add(Convert.ToInt32(bCode[k].ToString()) + 16);

                    foreach (int item in barcodeSum)
                    {

                        sum += (item * indexMulti);

                        indexMulti++;

                    }

                    barcode += codeArray[(sum % 103)];

                    barcode += "Î";
                }
            }
        }

        //Converts the barcode string into the propwer encoding for code128 id the barcode is less than or equal to three characters
        private void ThreeCharactersOrLess(string bCode)
        {
            int sum = 104;

            List<int> barcodeSum = new List<int>();

            for (int k = 0; k < bCode.Length; k++)
            {

                if (k == 0)
                {
                    barcode += "Ì";
                }


                    barcodeSum.Add(Array.IndexOf(codeArray, bCode[k].ToString()));

                    barcode += bCode[k].ToString();
                

                if (k == bCode.Length - 1)
                {

                    int indexMulti = 1;

                    foreach (int item in barcodeSum)
                    {

                        sum += (item * indexMulti);

                        indexMulti++;

                    }

                    barcode += codeArray[(sum % 103)];

                    barcode += "Î";
                }
            }

        }

        //Converts the barcode string into the propwer encoding for code128 if the barcode only contains characters other than numbers
        private void AllLetterCode(string bCode)
        {
            int sum = 104;

            List<int> barcodeSum = new List<int>();

            for (int k = 0; k < bCode.Length; k++)
            {

                if (k == 0)
                {
                    barcode += "Ì";
                }


                barcodeSum.Add(Array.IndexOf(codeArray, bCode[k].ToString()));

                barcode += bCode[k].ToString();


                if (k == bCode.Length - 1)
                {

                    int indexMulti = 1;

                    foreach (int item in barcodeSum)
                    {

                        sum += (item * indexMulti);

                        indexMulti++;

                    }

                    barcode += codeArray[(sum % 103)];

                    barcode += "Î";
                }
            }

        }

        //Converts the barcode string into the proper encoding for code128 if the barcode contains a mixture of numbers and letters, with the first three characters or less being numbers
        private void MixFirstThreeOrLessNumbers(string bCode)
        {

            List<int> numberStringsList = new List<int>();

            for (int i = 0; i < findTypeOfBarcode.Count; i++)
            {
                if (i != 0)
                {
                    if (findTypeOfBarcode[i] == CharacterTypes.NUMBER && findTypeOfBarcode[i - 1] == CharacterTypes.OTHER)
                    {
                        numberStringsList.Add(i);
                    }
                }

                if (i != findTypeOfBarcode.Count - 1)
                {
                    if (findTypeOfBarcode[i] == CharacterTypes.NUMBER && findTypeOfBarcode[i + 1] == CharacterTypes.OTHER)
                    {
                        numberStringsList.Add(i);
                    }
                }
            }

            if (findTypeOfBarcode[0] == CharacterTypes.NUMBER)
            {
                numberStringsList.RemoveAt(0);
            }

            int sum = 104;

            int z = 0;

            List<int> barcodeSum = new List<int>();

            BarcodeSubTypes validNumberString = BarcodeSubTypes.EXACTCONVERSION;

            for (int k = 0; k < bCode.Length; k++)
            {

                validNumberString = BarcodeSubTypes.EXACTCONVERSION;

                if (k == 0)
                {
                    barcode += "Ì";
                }

                if (numberStringsList.Count > 0 && z < numberStringsList.Count)
                {

                    if (k == numberStringsList[z])
                    {
                        
                        //If the number list has odd outer indecies, identify the corresponding type of conversion for the number sections in the code
                        if (numberStringsList.Count % 2 == 1)
                        {
                            if ((z < numberStringsList.Count - 1) && z % 2 == 0)
                            {
                                if (numberStringsList[z + 1] - numberStringsList[z] <= 4)
                                {
                                    validNumberString = BarcodeSubTypes.EXACTCONVERSION;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 0)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEEVEN;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 1)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEODD;
                                }

                            }

                            else if (z == numberStringsList.Count - 1)
                            {

                                if ((bCode.Length - 1) - numberStringsList[z] <= 2)
                                {
                                    validNumberString = BarcodeSubTypes.EXACTCONVERSION;
                                }

                                else if ((bCode.Length - 1) - numberStringsList[z] == 3)
                                {
                                    validNumberString = BarcodeSubTypes.ENDFOUR;
                                }

                                else if ((bCode.Length - 1) - numberStringsList[z] == 4)
                                {
                                    validNumberString = BarcodeSubTypes.ENDFIVE;
                                }

                                else if (((bCode.Length) - numberStringsList[z]) % 2 == 0)
                                {
                                    validNumberString = BarcodeSubTypes.ENDSIXEVEN;
                                }

                                else if (((bCode.Length) - numberStringsList[z]) % 2 == 1)
                                {
                                    validNumberString = BarcodeSubTypes.ENDSIXODD;
                                }
                            }
                        }

                        //If the number list has even outer indecies, identify the corresponding type of conversion for the number sections in the code for code 128
                        else if (numberStringsList.Count % 2 == 0)
                        {
                            if (z % 2 == 0)
                            {
                                if (numberStringsList[z + 1] - numberStringsList[z] <= 4)
                                {
                                    validNumberString = BarcodeSubTypes.EXACTCONVERSION;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 0)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEEVEN;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 1)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEODD;
                                }

                            }
                        }


                        z++;

                    }
                }

                //Conversion of number only section to encoded value based on type

                if(validNumberString == BarcodeSubTypes.EXACTCONVERSION)
                {
                    barcodeSum.Add(Array.IndexOf(codeArray, bCode[k].ToString()));

                    barcode += bCode[k].ToString();

                    if (z > 0 && z < numberStringsList.Count)
                    {

                        if (numberStringsList[z - 1] == numberStringsList[z])
                        {
                            z++;
                        }
                    }
                }

                //Conversion of central section of numbers that is an even number of characters and six or more characters long

                else if (validNumberString == BarcodeSubTypes.MIDDLEEVEN)
                {

                    for (int count = 0; count < (numberStringsList[z] - numberStringsList[z - 1] + 1); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {

                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        if (count == (numberStringsList[z] - numberStringsList[z - 1]))
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcode += "È";
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of central section of numbers that is an odd number of characters and longer than six characters

                else if (validNumberString == BarcodeSubTypes.MIDDLEODD)
                {
                    for (int count = 0; count < (numberStringsList[z] - numberStringsList[z - 1] + 1); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        if (count == (numberStringsList[z] - numberStringsList[z - 1]))
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcodeSum.Add(Convert.ToInt32(bCode[k].ToString()) + 16);

                            barcode += "È" + bCode[k].ToString();

                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is four characters long

                else if (validNumberString == BarcodeSubTypes.ENDFOUR)
                {

                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is five characters long

                else if (validNumberString == BarcodeSubTypes.ENDFIVE)
                {

                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k].ToString()) + 16);

                            barcode += bCode[k].ToString();

                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        else if (count % 2 == 0)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is six or more characters long and even in length

                else if (validNumberString == BarcodeSubTypes.ENDSIXEVEN)
                {

                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {

                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        else if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is six or more characters long and odd in length

                else if (validNumberString == BarcodeSubTypes.ENDSIXODD)
                {


                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        if (count == ((bCode.Length - numberStringsList[z - 1]) - 1))
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcodeSum.Add(Convert.ToInt32(bCode[k].ToString()) + 16);

                            barcode += "È" + bCode[k].ToString();

                        }

                        k++;
                    }

                    k--;

                    z++;
                }


                if (k == bCode.Length - 1)
                {

                    int indexMulti = 1;

                    foreach (int item in barcodeSum)
                    {

                        sum += (item * indexMulti);

                        indexMulti++;

                    }

                    barcode += codeArray[(sum % 103)];

                    barcode += "Î";
                }
            }

        }

        //Converts the barcode string into the proper encoding for code128 if the barcode contains a mixture of numbers and letters, with the first four characters or more being numbers

        private void MixFirstFourOrMoreNumbers(string bCode)
        {

            List<int> numberStringsList = new List<int>();

            //For loop is used to obtain the index ranges of consecutive numbers

            for (int i = 0; i < findTypeOfBarcode.Count; i++)
            {
                if (i != 0)
                {
                    if (findTypeOfBarcode[i] == CharacterTypes.NUMBER && findTypeOfBarcode[i - 1] == CharacterTypes.OTHER)
                    {
                        numberStringsList.Add(i);
                    }
                }

                if (i != findTypeOfBarcode.Count - 1)
                {
                    if (findTypeOfBarcode[i] == CharacterTypes.NUMBER && findTypeOfBarcode[i + 1] == CharacterTypes.OTHER)
                    {
                        numberStringsList.Add(i);
                    }
                }
            }

            int firsSectionLength = numberStringsList[0];

            numberStringsList.RemoveAt(0);

            int sum = 105;

            int z = 0;

            List<int> barcodeSum = new List<int>();

            BarcodeSubTypes validNumberString = BarcodeSubTypes.EXACTCONVERSION;

            for (int k = firsSectionLength; k < bCode.Length; k++)
            {
                validNumberString = BarcodeSubTypes.EXACTCONVERSION;

                if (k == 0)
                {
                    barcode += "Í";
                }

                //Identify the type of the initial section of numbers

                if(k == firsSectionLength)
                {
                    if((firsSectionLength + 1) % 2 == 0)
                    {
                        validNumberString = BarcodeSubTypes.FIRSTEVEN;
                    }

                    else
                    {
                        validNumberString = BarcodeSubTypes.FIRSTODD;
                    }
                }

                else if (numberStringsList.Count > 0 && z < numberStringsList.Count)
                {

       
                    if (k == numberStringsList[z])
                    {
                        //If the number list has odd outer indecies, identify the corresponding type of conversion for the number sections in the code
                        if (numberStringsList.Count % 2 == 1)
                        {
                            if ((z < numberStringsList.Count - 1) && z % 2 == 0)
                            {
                                if (numberStringsList[z + 1] - numberStringsList[z] <= 4)
                                {
                                    validNumberString = BarcodeSubTypes.EXACTCONVERSION;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 0)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEEVEN;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 1)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEODD;
                                }

                            }

                            else if (z == numberStringsList.Count - 1)
                            {
                                if ((bCode.Length - 1) - numberStringsList[z] <= 2)
                                {
                                    validNumberString = BarcodeSubTypes.EXACTCONVERSION;
                                }

                                else if ((bCode.Length - 1) - numberStringsList[z] == 3)
                                {
                                    validNumberString = BarcodeSubTypes.ENDFOUR;
                                }

                                else if ((bCode.Length - 1) - numberStringsList[z] == 4)
                                {
                                    validNumberString = BarcodeSubTypes.ENDFIVE;
                                }

                                else if (((bCode.Length) - numberStringsList[z]) % 2 == 0)
                                {
                                    validNumberString = BarcodeSubTypes.ENDSIXEVEN;
                                }

                                else if (((bCode.Length) - numberStringsList[z]) % 2 == 1)
                                {
                                    validNumberString = BarcodeSubTypes.ENDSIXODD;
                                }
                            }
                        }

                        //If the number list has even outer indecies identify the corresponding type of conversion for the number sections in the code for code 128
                        if (numberStringsList.Count % 2 == 0)
                        {
                            if (z % 2 == 0)
                            {
                                if (numberStringsList[z + 1] - numberStringsList[z] <= 4)
                                {
                                    validNumberString = BarcodeSubTypes.EXACTCONVERSION;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 0)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEEVEN;
                                }

                                else if ((numberStringsList[z + 1] - numberStringsList[z] + 1) % 2 == 1)
                                {
                                    validNumberString = BarcodeSubTypes.MIDDLEODD;
                                }

                            }
                        }


                            z++;

                        


                        
                    }

                }
                

                //Conversion of number only section to encoded value based on type

                if (validNumberString == BarcodeSubTypes.EXACTCONVERSION)
                {
                    barcodeSum.Add(Array.IndexOf(codeArray, bCode[k].ToString()));

                    barcode += bCode[k].ToString();

                    if (z > 0 && z < numberStringsList.Count)
                    {

                        if (numberStringsList[z - 1] == numberStringsList[z])
                        {
                            z++;
                        }
                    }
                }

                //Conversion of first number section if it ise even in length

                else if (validNumberString == BarcodeSubTypes.FIRSTEVEN)
                {

                    for (int count = 0; count < firsSectionLength + 1; count++)
                    {

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[count - 1].ToString() + bCode[count].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[count - 1].ToString() + bCode[count].ToString())];
                        }

                        if (count == firsSectionLength)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcode += "È";
                        }

 
                    }

                }
                //Conversion of first number section it is odd in length


                else if (validNumberString == BarcodeSubTypes.FIRSTODD)
                {

                    for (int count = 0; count < firsSectionLength + 1; count++)
                    {

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[count - 1].ToString() + bCode[count].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[count - 1].ToString() + bCode[count].ToString())];
                        }

                        if (count == firsSectionLength)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcodeSum.Add(Convert.ToInt32(bCode[count].ToString()) + 16);

                            barcode += "È" + bCode[count].ToString();

                        }

                    }

                }

                //Conversion of central section of numbers that is an even number of characters and six or more characters long

                else if (validNumberString == BarcodeSubTypes.MIDDLEEVEN)
                {
                    for (int count = 0; count < (numberStringsList[z] - numberStringsList[z - 1] + 1); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        if (count == (numberStringsList[z] - numberStringsList[z - 1]))
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcode += "È";
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of central section of numbers that is an odd number of characters and longer than six characters

                else if (validNumberString == BarcodeSubTypes.MIDDLEODD)
                {
                    for (int count = 0; count < (numberStringsList[z] - numberStringsList[z - 1] + 1); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        if (count == (numberStringsList[z] - numberStringsList[z - 1]))
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcodeSum.Add(Convert.ToInt32(bCode[k].ToString()) + 16);

                            barcode += "È" + bCode[k].ToString();

                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is four characters long

                else if (validNumberString == BarcodeSubTypes.ENDFOUR)
                {

                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is five characters long

                else if (validNumberString == BarcodeSubTypes.ENDFIVE)
                {

                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k].ToString()) + 16);

                            barcode += bCode[k].ToString();

                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        else if (count % 2 == 0)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is six or more characters long and even in length

                else if (validNumberString == BarcodeSubTypes.ENDSIXEVEN)
                {

                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {

                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        else if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        k++;
                    }

                    k--;

                    z++;
                }

                //Conversion of end section of numbers that is six or more characters long and odd in length

                else if (validNumberString == BarcodeSubTypes.ENDSIXODD)
                {
                    
                    for (int count = 0; count < (bCode.Length - numberStringsList[z-1]); count++)
                    {
                        if (count == 0)
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "Ç"));

                            barcode += "Ç";
                        }

                        if (count % 2 == 1)
                        {
                            barcodeSum.Add(Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString()));

                            barcode += codeArray[Convert.ToInt32(bCode[k - 1].ToString() + bCode[k].ToString())];
                        }

                        if (count == ((bCode.Length - numberStringsList[z - 1])-1))
                        {
                            barcodeSum.Add(Array.IndexOf(codeArray, "È"));

                            barcodeSum.Add(Convert.ToInt32(bCode[k].ToString()) + 16);

                            barcode += "È" + bCode[k].ToString();

                        }

                        k++;
                    }

                    k--;

                    z++;
                }


                if (k == bCode.Length - 1)
                {

                    int indexMulti = 1;

                    foreach (int item in barcodeSum)
                    {

                        sum += (item * indexMulti);

                        indexMulti++;

                    }

                    barcode += codeArray[(sum % 103)];

                    barcode += "Î";
                }
            }

        }

    }

    
}
