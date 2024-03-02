using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door2")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door2")
        {
            instructions.SetActive(false);
        }
    }
}