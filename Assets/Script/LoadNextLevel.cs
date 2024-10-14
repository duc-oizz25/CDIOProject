using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public float deLaySecond = 2;
    public string nameScene = "Level2";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);

            ModeSelect();
        }
    }

    public void  ModeSelect(){
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay(){
        yield return new WaitForSeconds(deLaySecond);   
        SceneManager.LoadScene(nameScene); 
    }
   
}
