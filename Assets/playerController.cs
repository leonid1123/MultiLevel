using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    int HP = 10;

    public int ShowHP()
    {
        return HP;
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            int y = SceneManager.GetActiveScene().buildIndex;
            if (y == 0)
            {
                SceneManager.LoadScene(y+1, LoadSceneMode.Single);
            } else
            {
                SceneManager.LoadScene(y-1, LoadSceneMode.Single);
            }
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            HP--;
            Debug.Log(HP);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            HP++;
            Debug.Log(HP);

        }
    }
}
