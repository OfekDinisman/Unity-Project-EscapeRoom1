using UnityEngine;
using System.IO;

public class HandleTextFile
{
    static string path = "Assets/LogFile/Log.txt";
    static int ID = 1;
    public static void WriteString(string s)
    {
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(s);
        writer.Close();
    }

    public static void ReadString()
    {
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    public static void WriteID()
    {
        int counter;
        counter = PlayerPrefs.GetInt("COUNTER");
        Debug.Log("ID: " + counter + "");
        WriteString("ID: "+ counter + "");
        counter++;
        PlayerPrefs.SetInt("COUNTER", counter);
    }
}