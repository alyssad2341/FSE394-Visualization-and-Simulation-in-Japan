using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;


public class FileIO : MonoBehaviour
{

    //attach this file to Manager Object

    string fileName;
    Timer timer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        PlayerPrefs.SetInt("AgentNum", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FSE394WriteFile(){
        fileName = Application.dataPath + "/output.txt";
        /*if(File.Exists(fileName)){
            Debug.Log(fileName + " already exists!");
            return;

        } */

        timer = GameObject.Find("TextTimer").GetComponent<Timer>();

        StreamWriter sw = File.CreateText(fileName);
        sw.WriteLine("Results:");
        int num = PlayerPrefs.GetInt("AgentNum");
        sw.WriteLine("Num of Agents is {0}", num);
        sw.WriteLine("Saved Time is {0}", timer.message.text);
        sw.Close();
    }

    public void FSE394ReadFile(){
        fileName = Application.dataPath + "/output.txt";
        if(File.Exists(fileName)){
            StreamReader sr = File.OpenText(fileName);
            string line = sr.ReadLine();
            while(line != null){
                Debug.Log(line);
                line = sr.ReadLine();
            }
        }else{
            Debug.Log("Could not open the file: " + fileName + " for reading");
            return;
        }
    }

    public void FSE394TimeChange(){
        if(Time.timeScale != 0){
            Time.timeScale = 0;

        }else{
            Time.timeScale = 1;

        }
    
    }

    public void FSE394TimeScaleSlider(){
        GameObject slider = GameObject.Find("TimeScaleSlider");
        Time.timeScale = slider.GetComponent<UnityEngine.UI.Slider>().value;
    }

    public void FSE394Start(){
        SceneManager.LoadScene("Day6");
    }

    public void FSE394Results(){
        SceneManager.LoadScene("Day6_Results");
    }

    public void FSE394HomePage(){
        SceneManager.LoadScene("Day6_Start");
    }



}
