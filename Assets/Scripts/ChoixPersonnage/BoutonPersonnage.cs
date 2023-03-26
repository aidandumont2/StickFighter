using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoutonPersonnage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject box = other.gameObject;

        if (other.gameObject.CompareTag("EventSystem"))
        {
            Debug.Log("Event");
            var colors1 = box.GetComponent<Button>().colors;
            colors1.normalColor = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("EventSystem"))
        {
            GameObject box = other.gameObject;
            box.GetComponent<Image>().color = Color.white;
        }
    }
}
