using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PractiseArrays : MonoBehaviour
{
    public int[] array1 = new int[4];
    public int[] array2 = new int[] { 21, 22, 23, 24 };
    public int[] array3 = { 31, 32, 33, 34, 35, 36, 37 };
    public string[] array4 = new string[10];
    public GameObject[] arrayColoredImagesRed;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        Debug.Log("Element 0 von array1 hat den Wert: " + array1[0]);
        Debug.Log("Element 0 von array2 hat den Wert: " + array2[0]);
        Debug.Log("Element 0 von array3 hat den Wert: " + array3[0]);
        Debug.Log("Element 0 von array4 hat den Wert: " + array4[0]);
        Debug.Log("Element 0 von arrayColoredImagesRed hat den Wert:" + arrayColoredImagesRed[0].name);

        Debug.Log("Das letzte Element von array1 hat den Wert: " + array1[array1.Length-1]);
        Debug.Log("Das letzte Element von array2 hat den Wert: " + array2[array2.Length - 1]);
        Debug.Log("Das letzte Element von array3 hat den Wert: " + array3[array3.Length - 1]);
        Debug.Log("Das letzte Element von array4 hat den Wert: " + array4[array4.Length - 1]);
        Debug.Log("Das letzte Element von arrayColoredImagesRed hat den Wert:" + arrayColoredImagesRed[arrayColoredImagesRed.Length - 1].name);

        PrintElements(array4);

        foreach(GameObject elem in arrayColoredImagesRed)
        {
            Debug.Log(elem.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintElements(string[] stringArray)
    {
        for (int i = 0; i < stringArray.Length; i++)
        {
            Debug.Log("Element Nummer " + i + "hat den Wert: " + stringArray[i]);
        }
    }

}
