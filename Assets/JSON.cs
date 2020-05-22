using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[Serializable]
public class MyClass
{
    //以下JSONの中の要素
    public int level;
    public float timeElapsed;
    public string playerName;
}

public class JSON : MonoBehaviour
{
    MyClass myObject = new MyClass();
    public GameObject test_text = null;
    // Start is called before the first frame update
    void Start()
    {
        
        myObject.level = 10;
        myObject.timeElapsed = 50.0f;
        myObject.playerName = "Player1";

        

    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            string json = JsonUtility.ToJson(myObject);
            Text test = test_text.GetComponent<Text>();
            test.text = json;
        }    
    }


}
