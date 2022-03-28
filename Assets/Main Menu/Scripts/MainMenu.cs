using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string firstLevel;

    [SerializeField] private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene(firstLevel);
    }
    public void StartGame()
    {
        anim.SetTrigger("startGame");
        StartCoroutine(ExecuteAfterTime(3));

    }

    public void OpenOptions()
    {

    }

    public void ClosedOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
