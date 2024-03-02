using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(2);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            instructions.SetActive(false);
        }
    }
}