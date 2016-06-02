using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Conversation : MonoBehaviour {

    public Text Person;
    public Text Player;
    public Text End;

	void Start ()
    {
        
        Player.canvasRenderer.SetAlpha(0.0f);
        Person.canvasRenderer.SetAlpha(0.0f);
        End.canvasRenderer.SetAlpha(0.0f);
        StartCoroutine(StartConversation());

    }
	
	IEnumerator StartConversation ()
    {
        yield return new WaitForSeconds(1);

        ChangeText(Person, "Those are some nice flowers you have there.");

        yield return new WaitForSeconds(3);

        ChangeText(Player, "Oh, thank you... They make me feel better.");

        StartCoroutine(FadeOut(Person));

        yield return new WaitForSeconds(4);

        ChangeText(Person, "What do you mean?");

        StartCoroutine(FadeOut(Player));

        yield return new WaitForSeconds(4);

        ChangeText(Player, "Just been having a couple of rough days.");

        StartCoroutine(FadeOut(Person));

        yield return new WaitForSeconds(4);

        ChangeText(Person, "I get the feeling its been more than a couple of days...");

        StartCoroutine(FadeOut(Player));

        yield return new WaitForSeconds(4);

        ChangeText(Player, "How did you know?");

        StartCoroutine(FadeOut(Person));

        yield return new WaitForSeconds(4);

        ChangeText(Person, "Intuition. Why don't you take some pills or something.");

        StartCoroutine(FadeOut(Player));

        yield return new WaitForSeconds(4);

        ChangeText(Player, "I'm sick of pills, That's all I see everywhere... \nI just need someone to talk to or something...");

        StartCoroutine(FadeOut(Person));

        yield return new WaitForSeconds(4);

        ChangeText(Person, "Well then... why haven't you told anyone?");

        StartCoroutine(FadeOut(Player));

        yield return new WaitForSeconds(4);

        ChangeText(Player, "No one asked.");

        StartCoroutine(FadeOut(Person));

        yield return new WaitForSeconds(4);

        StartCoroutine(FadeOut(Player));

        yield return new WaitForSeconds(3);

        ChangeText(Person, "Anxiety disorders are the most common mental illnesses\n in the U.S., affecting 40 million adults in\n the United States age 18 and older.");

        yield return new WaitForSeconds(3);

        ChangeText(Player, "It's not uncommon for someone with an anxiety disorder\n to also suffer from depression or vice versa.");

        StartCoroutine(FadeOut(Person));

        yield return new WaitForSeconds(4);

        ChangeText(Person, "Nearly one-half of those diagnosed with despression\n are also diagnosed with an anxiety disorder.");

        StartCoroutine(FadeOut(Player));

        yield return new WaitForSeconds(4);

        ChangeText(Player, "You can help anyone by just taking\n the time to listen to them and just be there.");

        StartCoroutine(FadeOut(Person));

        yield return new WaitForSeconds(4);

        StartCoroutine(FadeOut(Player));

        ChangeText(End, "Thank you for playing! \nThe Toll of the Stroll...");

        yield return new WaitForSeconds(4);

        StartCoroutine(FadeOut(End));

        yield return new WaitForSeconds(2);

        Application.Quit();

    }

    void ChangeText(Text gametext, string myText)
    {
        gametext.canvasRenderer.SetAlpha(0.0f);
        gametext.text = myText;
        StartCoroutine(FadeIn(gametext));
    }

    IEnumerator FadeIn(Text text)
    {
        yield return new WaitForSeconds(3);
        text.CrossFadeAlpha(1.0f, 1.0f, false);
    }

    IEnumerator FadeOut(Text text)
    {
        yield return new WaitForSeconds(3);
        text.CrossFadeAlpha(0.1f, 1.0f, false);
    }
}
