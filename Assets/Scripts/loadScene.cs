using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void loadChallange1(){
        SceneManager.LoadScene("challange1");
    }
    public void loadChallange2(){
        SceneManager.LoadScene("challange2");
    }
    public void loadChallange3(){
        SceneManager.LoadScene("challange3");
    }
    public void loadMenu(){
        SceneManager.LoadScene("menu");
    }
}
