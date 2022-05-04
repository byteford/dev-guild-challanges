using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Three;
using TMPro;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    [SerializeField]
    int[] lexArr;
    [SerializeField]
    int startNum, endNum = 0;
    [SerializeField]
    string lang = "en";
    [SerializeField]
    TMP_InputField inputa, inputb;

    [SerializeField]
    TMP_Text numOutput, langOutput;
    [SerializeField]
    TMP_Dropdown langFeild;
    [SerializeField]
    Slider langPage;
    Numbers nums;
    // Start is called before the first frame update
    void Start()
    {
        inputa.text = startNum.ToString();
        inputb.text = endNum.ToString();
        loadDropdown();
        loadLang(); 
        
    }
    void loadDropdown(){
        langFeild.options.Clear();
        foreach(string lang in Numbers.options){
            langFeild.options.Add(new TMP_Dropdown.OptionData(){text=lang});
        }
        langFeild.RefreshShownValue();
    }
    // Update is called once per frame
    void Update()
    {
        langPage.maxValue = langOutput.textInfo.pageCount;
    }
    public void loadLang(){
        nums = new Numbers(lang);
        Debug.Log(nums);
        langOutput.text = nums.ToString();
        
    }

    public void compute(){
        startNum = int.Parse(inputa.text);
        endNum = int.Parse(inputb.text);

        lexArr = lexi.load(startNum,endNum);
        Debug.Log(lexi.ToString(lexArr, nums));
        lexArr = lexi.sort(lexArr, nums);
        Debug.Log(lexi.ToString(lexArr, nums));
        numOutput.text = lexi.ToString(lexArr, nums);
    }
    public void LangPageValChange(){
        langOutput.pageToDisplay = ((int)langPage.value);
    }
    public void langChange(){
        lang = Numbers.options[langFeild.value];
        loadLang();
    }
}
