using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class SimpleText : MonoBehaviour
{
    //attach file to Text item
    //Text message;  //not drag and drop
    // Start is called before the first frame update

    TextMeshProUGUI message;

    void Start()
    {
        PlayerPrefs.SetInt("AgentNum", 0); //set new global variable
        //message = GetComponent<Text>();
        message = GetComponent<TextMeshProUGUI>(); //update to TMP
        
    }


    // Update is called once per frame
    void Update()
    {
        //message.text = Time.time.ToString("F2");
        message.text = PlayerPrefs.GetInt("AgentNum").ToString();
    }
}
