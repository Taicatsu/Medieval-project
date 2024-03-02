using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorP2 : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "DoorP2")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(3);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "DoorP2")
        {
            instructions.SetActive(false);
        }
    }
}