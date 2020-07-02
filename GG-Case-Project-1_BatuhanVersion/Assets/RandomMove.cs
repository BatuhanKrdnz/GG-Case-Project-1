using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomMove : MonoBehaviour { 

    
    public float InvokeRate = 1f;
    public Color pickColor = Color.green;
    public GameObject[] skins;
    public GameObject currentSkin;
    public GameObject parent;
    public Sprite[] sourceImg;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ButtonPressed", 1f, InvokeRate);
        
    }

    public void ButtonPressed()
    {
        int i = 0;
        int indexNumber = Random.Range(0, skins.Length);

        for (int x = 0; x <= 5; x++)
        {
           
            while (i < 6)
            {
                currentSkin = skins[indexNumber];
                Debug.Log((skins[indexNumber].name));

                for (int n = 0; n < skins.Length; n++)
                {
                    skins[n].GetComponent<Image>().color = Color.gray;
                }

                currentSkin.GetComponent<Image>().color = pickColor;

                i++;
            }
        }

        currentSkin.transform.GetChild(indexNumber).GetComponent<Image>().sprite = sourceImg[indexNumber];
    }
       

}
