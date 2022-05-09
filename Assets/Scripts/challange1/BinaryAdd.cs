using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BinaryAdd : MonoBehaviour
{
    [SerializeField]
    TMP_InputField aInput;

    [SerializeField]
    TMP_InputField bInput;
    [SerializeField]
    TMP_Text output;
    [SerializeField]
    string a;
    [SerializeField]
    string b;
    [SerializeField]
    string answer;
    
    public void compute(){
        a = aInput.text;
        b = bInput.text;
        answer = three.calc.compute(a,b);
        output.text = answer;
    }
}
