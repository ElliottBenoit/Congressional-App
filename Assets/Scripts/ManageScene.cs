using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public void NextScene()
    {
        StartCoroutine(LoadAfterAnim());
    }
    public IEnumerator LoadAfterAnim()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Home()
    {
        SceneManager.LoadScene("Home");
    }

    public void Search()
    {
        SceneManager.LoadScene("Search");
    }

    public void Calander()
    {
        SceneManager.LoadScene("Calander");
    }
}