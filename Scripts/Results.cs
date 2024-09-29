using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class Results : MonoBehaviour
{

    public TextMeshProUGUI textMeshPro;  // Reference to the TMP Text component
    public string fileName = "output.txt";  // Name of the .txt file

    // Start is called before the first frame update
    void Start()
    {
        UploadTextFromFile(fileName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UploadTextFromFile(string fileName)
    {
        string path = Path.Combine(Application.dataPath, fileName);
        string fileContents = File.ReadAllText(path);
        textMeshPro.text = fileContents;
        PlayerPrefs.SetInt("AgentNum", 0);
    }
}
