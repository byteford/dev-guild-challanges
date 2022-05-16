using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class UI
{

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator DoesSceneLoad()
    {
        string sceneName = "challange3";
        SceneManager.LoadScene(sceneName);
        yield return null;
        var scene = SceneManager.GetActiveScene();
        Assert.AreEqual(sceneName, scene.name);
    }

    [UnityTest]
    public IEnumerator DoesTextFill(){
        string sceneName = "challange3";
        SceneManager.LoadScene(sceneName);
        yield return null;
        GameObject outputGO = GameObject.Find("langList");
        TMP_Text outputcomp = outputGO.GetComponent<TMP_Text>();
        string outputstr = (outputcomp as TMP_Text).text;
        string[] outputlst = outputstr.Split("\n");
        Assert.AreEqual(101, outputlst.Length);
    }
    [UnityTest]
    public IEnumerator Calc0to5(){
        string sceneName = "challange3";
        SceneManager.LoadScene(sceneName);
        yield return null;
        GameObject InputAGO = GameObject.Find("a");
        GameObject InputBGO = GameObject.Find("b");
        GameObject OutputGO = GameObject.Find("output sorted");
        TMP_Text Output = OutputGO.GetComponentInChildren<TMP_Text>();

        TMP_InputField InputAComp = InputAGO.GetComponent<TMP_InputField>();
        TMP_InputField InputBComp = InputBGO.GetComponent<TMP_InputField>();
        InputAComp.text = "0";
        InputBComp.text = "5";
        Button calc = GameObject.Find("Submit").GetComponent<Button>();
        calc.onClick.Invoke();
        Assert.AreEqual("5: five\n4: four\n1: one\n3: three\n2: two\n0: zero\n", Output.text);
    }
}
