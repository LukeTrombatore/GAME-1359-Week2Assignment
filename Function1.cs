using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function1 : MonoBehaviour
{
    public List<string> num;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 1000; i++)
        {
            if (i.ToString().Contains("3") && i.ToString().Contains("7"))
            {
                Debug.Log(i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
