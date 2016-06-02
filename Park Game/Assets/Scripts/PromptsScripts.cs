using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PromptsScripts : MonoBehaviour {

    public GameObject promptPanel;

    void Start()
    {
        StartCoroutine(ShowPrompt());
    }

	IEnumerator ShowPrompt()
    {
        yield return new WaitForSeconds(3);
        promptPanel.SetActive(true);

        yield return new WaitForSeconds(3);
        promptPanel.GetComponent<Image>().CrossFadeAlpha(0.1f, 2.0f, false);
        yield return new WaitForSeconds(2);
        promptPanel.SetActive(false);
    }
}
