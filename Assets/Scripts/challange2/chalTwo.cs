using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using two;
public class chalTwo : MonoBehaviour
{

    [SerializeField]
    TMP_InputField input;

    [SerializeField]
    TMP_Text output;

    [SerializeField]
    string sum;

    public void calculate(){
        
        sum = input.text;
        var c = new calc();
        Debug.Log(c.Evaluate(sum));
        output.text = c.Evaluate(sum).ToString();
    }
}
