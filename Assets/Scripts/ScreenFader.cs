using UnityEngine;
using System.Collections;

public class ScreenFader : MonoBehaviour {

	//Call variables
	Animator anim;
	bool isFading = false;

	// Use this for initialization
	void Start () {
		//Call animator object
		anim = GetComponent<Animator> ();
	}

	//When fading is true, trigger FadeIn animation
	public IEnumerator FadeToClear() {
		isFading = true;
		anim.SetTrigger("FadeIn");

		while (isFading)
			yield return null;
	}

	//When fading is true, trigger fade out animation
	public IEnumerator FadeToBlack() {
		isFading = true;
		anim.SetTrigger("FadeOut");

		while (isFading)
			yield return null;
	}

	//Set isFading to false when animation completes
	void AnimationComplete ()  {
		isFading = false;
	}

}
