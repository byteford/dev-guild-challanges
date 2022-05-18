using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
namespace Three{
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
    

        public string RunCalc(string a, string b){
            GameObject InputAGO = GameObject.Find("a");
            GameObject InputBGO = GameObject.Find("b");
            GameObject OutputGO = GameObject.Find("output sorted");
            TMP_Text Output = OutputGO.GetComponentInChildren<TMP_Text>();

            TMP_InputField InputAComp = InputAGO.GetComponent<TMP_InputField>();
            TMP_InputField InputBComp = InputBGO.GetComponent<TMP_InputField>();
            InputAComp.text = a;
            InputBComp.text = b;
            Button calc = GameObject.Find("Submit").GetComponent<Button>();
            calc.onClick.Invoke();
            return Output.text;
        }

        [UnityTest]
        public IEnumerator Calc0to5(){
            string sceneName = "challange3";
            SceneManager.LoadScene(sceneName);
            yield return null;
            string result = RunCalc("0","5");
            Assert.AreEqual("5: five\n4: four\n1: one\n3: three\n2: two\n0: zero\n", result);
        }
        [UnityTest]
        public IEnumerator Calcminus5to10(){
            string sceneName = "challange3";
            SceneManager.LoadScene(sceneName);
            yield return null;
            string result = RunCalc("-5","10");
            Assert.AreEqual("8: eight\n5: five\n4: four\n-5: minus five\n-4: minus four\n-1: minus one\n-3: minus three\n-2: minus two\n9: nine\n1: one\n7: seven\n6: six\n10: ten\n3: three\n2: two\n0: zero\n",
            result);
        }

        [UnityTest]
        public IEnumerator Calc7to12(){
            string sceneName = "challange3";
            SceneManager.LoadScene(sceneName);
            yield return null;
            string result = RunCalc("7","12");
            Assert.AreEqual("8: eight\n11: eleven\n9: nine\n7: seven\n10: ten\n12: twelve\n",
            result);
        }

        [UnityTest]
        public IEnumerator Calc75to84(){
            string sceneName = "challange3";
            SceneManager.LoadScene(sceneName);
            yield return null;
            string result = RunCalc("75","84");
            Assert.AreEqual("80: eighty\n84: eighty four\n81: eighty one\n83: eighty three\n82: eighty two\n78: seventy eight\n75: seventy five\n79: seventy nine\n77: seventy seven\n76: seventy six\n",
            result);
        }
    }
}