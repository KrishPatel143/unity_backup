using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeCoder : MonoBehaviour
{
    // Start is called before the first frame update
    public UDPReceive udpReceive;
    public UnityEvent myEvents;
    public int[] FingerData = {0,0,0,0,0,0,0,0,0,0};

    public bool resetpoint = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        string Idata = udpReceive.data;
        // string data = "[0,1,0,0,0]";
        string pdata= "";
        if (Idata != pdata){  
            string data = Idata.Remove(0, 1);
            data = data.Remove(data.Length - 1, 1);
            print(data);
            string[] points = data.Split(',');
            int[] fingers = new int[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                fingers[i] = int.Parse(points[i]);
                
            }
            if (fingers[0] == 0)
            {
                resetpoint = true;
            }
            // print(fingers);
            pdata = Idata;
            FingerData = fingers;
            if (ThisFingersisdown(1,2,3,4) && ThisFingersisup(0))
            {
                resetpoint = true;
            }
        }
        
    }   
    
    public bool ThisFingersisup(int a){
        if(FingerData[a] == 1)
            return true;
        return false;
    }
    public bool ThisFingersisup(int a, int b){
        if(FingerData[a] == 1 && ThisFingersisup(b))
            return true;
        return false;
    }
    public bool ThisFingersisup(int a, int b , int c){
        if(FingerData[a] == 1 && ThisFingersisup(b ,c))
            return true;
        return false;
    }
    public bool ThisFingersisup(int a,int b , int c ,int d){
        if(FingerData[a] == 1 && ThisFingersisup(b ,c, d))
            return true;
        return false;
    }
    public bool ThisFingersisup(int a,int b,int c,int d,int e){
        if(FingerData[a] == 1 && ThisFingersisup(b,c,d,e))
            return true;
        return false;
    }
    public bool AllFingersisup(int a){
        if(ThisFingersisup(a,a+1,a+2,a+3,a+4))
            return true;
        return false;
    }
    public bool ThisFingersisdown(int a){
        if(FingerData[a] == 0)
            return true;
        return false;
    }
    public bool ThisFingersisdown(int a, int b){
        if(FingerData[a] == 0 && ThisFingersisdown(b))
            return true;
        return false;
    }
    public bool ThisFingersisdown(int a, int b , int c){
        if(FingerData[a] == 0 && ThisFingersisdown(b ,c))
            return true;
        return false;
    }
    public bool ThisFingersisdown(int a,int b , int c ,int d){
        if(FingerData[a] == 0 && ThisFingersisdown(b ,c, d))
            return true;
        return false;
    }
    public bool ThisFingersisdown(int a,int b,int c,int d,int e){
        if(FingerData[a] == 0 && ThisFingersisdown(b,c,d,e))
            return true;
        return false;
    }

}
