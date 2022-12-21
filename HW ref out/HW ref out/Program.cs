using System;
using static System.Net.Mime.MediaTypeNames;

namespace HW_ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 2

            //Console.WriteLine("Yazin:");
            //string sentence = Console.ReadLine();
            //Console.WriteLine(FindWordsCount(sentence));
            //fixSentence(ref sentence);
            //Console.WriteLine(sentence);

            //task 3

            //int[] arr = { 1, 2, 3 };

            //Add(ref int[] arr, 44);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //task 4 

            //string[] fullnames = { "Hikmet Abbasov", "Tofiq Qulamov", "Nermin Memmedov" };

            //var names = MakeFirstnamesArr(fullnames);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

           
            // task 5 
        }

    }

    //task 1 
    //static void fixSentence(ref string sentence)
    //{
    //    sentence = sentence.Trim();

    //    string newSentence = "";

    //    var arr = sentence.Split(' ');

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] != "")
    //        {
    //            newSentence += arr[i];

    //            if (i < arr.Length - 1)
    //            {
    //                newSentence += " ";
    //            }
    //        }

    //    }
    //    sentence = newSentence;
    //}

    //task 2 Verilmiş string dəyərdəki sözlərin sayını tapan metod (boşluqlarla ayrılmış bütün ifadələr)

    //static int FindWordsCount(string str)
    //{
    //    fixSentence(ref str);
    //    return str.Split(' ').Length;
    //}

    // task 3 Parameter olaraq integer array variable-ı (reference) və bir
    // integer value qəbul edən və həmin integer value-nu integer array-ə yəni element kimi əlavə edən metod.

    //static void Add(ref int value, ref int[] arr)
    //{
    //    int[] newArr = new int[arr.Length + 1];

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        newArr[i] = arr[i];
    //    }

    //    newArr[newArr.Length - 1] = value;

    //    arr = newArr;
    //}

    // task 4 Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.
    // Fullname arrayinin icindeki butun value-lar ad+" "+soyad formatindadir.Misalcun "Hikmet Abbasov".
    // Misalcun gelen arraydeki deyerler {"Hikmet Abbasov","Abdulla Qulamov","Cemile Hikmetova"}
    // olarsa return olunan arraydeki deyerler {"Hikmet","Abdulla","Cemile"} olmalidir

    //static string[] MakeFirstnamesArr(string[] fullnames)
    //{
    //    string[] arr = new string[fullnames.Length];

    //    for (int i = 0; i < fullnames.Length; i++)
    //    {
    //        //int firstSpaceIndex = fullnames[i].IndexOf(' ');
    //        //arr[i] = fullnames[i].Substring(0,firstSpaceIndex);

    //        arr[i] = fullnames[i].Split(' ')[0];
    //    }

    //    return arr;
    //}

    static bool IsCapitalized(string str)
    {
        if (!Char.IsUpper(str[0]))
            return false;

        for (int i = 1; i < str.Length; i++)
        {
            if (!Char.IsLower(str[i]))
                return false;
        }

        return true;
    }

    static bool IsFullname(string str)
    {
        var words = str.Split(' ');

        if (words.Length != 2)
            return false;

        if (!IsCapitalized(words[0]) || !IsCapitalized(words[1]))
            return false;

        return true;
    }
}

