using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEntrence : MonoBehaviour
{

    [SerializeField] private GameObject playerObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("in cave");
            SceneManager.LoadScene(0);
        }
    }
}
