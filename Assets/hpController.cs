using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hpController : MonoBehaviour
{
    playerController playerController;
    public TMP_Text text;
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        int playerHP = playerController.ShowHP();
        text.text = "HP:" + playerHP.ToString();
    }
}
