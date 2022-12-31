using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearProdactFinder : MonoBehaviour
{
    // Start is called before the first frame update
    DeCoder deCoder;
    public GameObject data;
    public GameObject[] prod;
    public int autoset;
    
    // private float[] dist;
    void Awake()
    {
        deCoder = data.GetComponent<DeCoder>();
    }

    // Update is called once per frame
    void Update()
    {
        float[] dis = new float[prod.Length];
        if (deCoder.ThisFingersisup(1) && deCoder.ThisFingersisdown(0,2,3,4))
        {
            float mindis = 10;
            for (int i = 0; i < prod.Length; i++)
            {
                dis[i] = Vector3.Distance(prod[i].transform.position, transform.position);
                print("what the fuck");
                if(dis[i] < mindis){
                    mindis = dis[i]; 
                }
            }
            if (mindis == 0.000)
            {
                print("what the fuck");
                autoset = 0;
            }else
            {
                autoset = 1;
            }
            
        }
    }
}
