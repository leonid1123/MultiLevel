using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    int HP = 10;
    float move;
    Rigidbody2D rb;

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
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
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
        if (Input.GetKeyUp(KeyCode.Z))
        {
            HP--;
            Debug.Log(HP);

        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            HP++;
            Debug.Log(HP);

        }
        move = Input.GetAxis("Horizontal");
    }
    void Movement(float _move)
    {
        rb.velocity = new Vector2(_move, rb.velocity.y);
    }
    private void FixedUpdate()
    {
        Movement(move);
    }
}
