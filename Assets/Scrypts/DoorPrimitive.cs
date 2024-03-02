using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorP : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "DoorP")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(4);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "DoorP")
        {
            instructions.SetActive(false);
        }
    }
}