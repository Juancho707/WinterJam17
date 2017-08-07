using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class DropInDropOut : MonoBehaviour
{
    public GameObject[] Players;

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Start_P1"))
        {
            if (Players[0].activeInHierarchy)
            {
                Players[0].SetActive(false);
            }
            else
            {
                Players[0].SetActive(true);
            }
        }

        if (Input.GetButtonDown("Start_P2"))
        {
            if (Players[1].activeInHierarchy)
            {
                Players[1].SetActive(false);
            }
            else
            {
                Players[1].SetActive(true);
            }
        }

        if (Input.GetButtonDown("Start_P3"))
        {
            if (Players[2].activeInHierarchy)
            {
                Players[2].SetActive(false);
            }
            else
            {
                Players[2].SetActive(true);
            }
        }

        if (Input.GetButtonDown("Start_P4"))
        {
            if (Players[3].activeInHierarchy)
            {
                Players[3].SetActive(false);
            }
            else
            {
                Players[3].SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
