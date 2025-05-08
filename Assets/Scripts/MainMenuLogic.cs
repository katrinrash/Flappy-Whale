using System.Collections;
using System.Transactions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public GameObject transitionManager;

    public void PlayGame()
    { 
       transitionManager.GetComponent<Transition>().FadeIn();
       StartCoroutine(AfterTransition());
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Finished"); 
    }

    public IEnumerator AfterTransition()
    {
        yield return new WaitForSeconds(transitionManager.GetComponent<Transition>().FadeDuration);
        SceneManager.LoadScene(1);
    }
}
