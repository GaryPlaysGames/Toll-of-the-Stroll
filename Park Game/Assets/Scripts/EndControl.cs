using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class EndControl : MonoBehaviour {

    public FirstPersonController script;
    public GameObject endPanel;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player") && script.flowersNeeded < 5)
        {
            Application.LoadLevel(2);
        }

        else
        {
            StartCoroutine(ShowPrompt());
        }
    }

    IEnumerator ShowPrompt()
    {

        endPanel.SetActive(true);
        yield return new WaitForSeconds(3);

        endPanel.GetComponent<Image>().CrossFadeAlpha(0.1f, 2.0f, false);
        yield return new WaitForSeconds(2);

        endPanel.SetActive(false);
    }
}
