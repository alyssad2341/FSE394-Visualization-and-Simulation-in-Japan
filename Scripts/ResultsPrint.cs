using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class ResultsPrint : MonoBehaviour
{
    //attach this file to Manager Object

    string fileName;
    //Timer timer;
    public int numUnhappyPedestrians;
    public int CarCollisions;
    SimpleSpawn[] spawns;
    CarSpawn[] carspawns;
    int pedestrianDensity;
    int carDensity;

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("AgentNum", 0);
        numUnhappyPedestrians = 0;
        CarCollisions = 0;
        pedestrianDensity = 0;
        carDensity = 0;

        GameObject[] spawnObjects = GameObject.FindGameObjectsWithTag("Respawn");
        spawns = new SimpleSpawn[spawnObjects.Length];

        for (int i = 0; i < spawnObjects.Length; i++)
        {
            spawns[i] = spawnObjects[i].GetComponent<SimpleSpawn>();
        }

        GameObject[] spawnObjects2 = GameObject.FindGameObjectsWithTag("CarSpawn");
        carspawns = new CarSpawn[spawnObjects2.Length];

        for (int i = 0; i < spawnObjects2.Length; i++)
        {
            carspawns[i] = spawnObjects2[i].GetComponent<CarSpawn>();
        }
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

        //timer = GameObject.Find("TextTimer").GetComponent<Timer>();

        StreamWriter sw = File.CreateText(fileName);
        sw.WriteLine("Inputs:");
        //int density = 
        sw.WriteLine("Pedestrian Density is 4 pedestrians per {0} steps", pedestrianDensity);
        sw.WriteLine("Car Density is 3 cars per {0} steps", carDensity);
        sw.WriteLine();
        sw.WriteLine("Results:");
        int num = PlayerPrefs.GetInt("AgentNum");
        sw.WriteLine("Num of Car Collisions is {0}", CarCollisions);
        sw.WriteLine("Num of Pedestrians is {0}", num);
        sw.WriteLine("Num of Unhappy Pedestrians is {0}", numUnhappyPedestrians);

        float result = (float)numUnhappyPedestrians / num;
        string resultString = $"Proportion of Unhappy Pedestrians is {result * 100f:F2}%";

        sw.WriteLine(resultString);
        //sw.WriteLine("Saved Time is {0}", timer.message.text);
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

    // public void FSE394TimeChange(){
    //     if(Time.timeScale != 0){
    //         Time.timeScale = 0;

    //     }else{
    //         Time.timeScale = 1;

    //     }
    
    // }

    public void FSE394PedestrianDensitySlider(){
        GameObject slider = GameObject.Find("PedestrianDensity");
        foreach (SimpleSpawn spawn in spawns)
        {
            spawn.density = 1f - slider.GetComponent<UnityEngine.UI.Slider>().value;
            spawn.step = 0;
            pedestrianDensity = (int)(1000f*spawn.density);
            //print(spawn.density);
        }
    }

    public void FSE394CarDensitySlider(){
        GameObject slider = GameObject.Find("CarDensity");
        foreach (CarSpawn spawn in carspawns)
        {
            spawn.density = 1f - slider.GetComponent<UnityEngine.UI.Slider>().value;
            spawn.step = 0;
            carDensity = (int)(2000f*spawn.density);
            //print(spawn.density);
        }
    }

    public void FSE394Start(){
        SceneManager.LoadScene("Final_Project");
    }

    public void FSE394Results(){
        SceneManager.LoadScene("Final_Project_Start");
    }

    public void FSE394HomePage(){
        SceneManager.LoadScene("Final_Project_TitleScene");
    }
}
