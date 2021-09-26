using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuction2 : MonoBehaviour
{
    // Start is called before the first frame update
    Dictionary<char, int> letters = new Dictionary<char, int>();
    void Start()
    {
        //Vairable 

        string s = "Hello World";
        int currentHighestValue = 0;
        char currentMostCommon = ' ';
        foreach(char c in s)
        {
            if (!letters.ContainsKey(c))
            {
                letters.Add(c, 1);
            }
            else
            {
                letters[c]++;
            }
        }

        //NOTE: key = char, Value = int
        foreach (var v in letters)
        {
            Debug.Log(v.Key + ", " + v.Value);

            if (v.Value > currentHighestValue)
            {
                currentHighestValue = v.Value;
                currentMostCommon = v.Key;
            }
        }

        Debug.Log("The most common letter is " + currentMostCommon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
