using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string s = "Hello World";
        string result = "";
            foreach (char c in s)
        {
            // If result does not contain current character, adds it to the list
            if (!result.Contains(c.ToString()))
                result += c;
        }

        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
