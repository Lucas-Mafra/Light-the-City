using UnityEngine;

public class LevelChanger : MonoBehaviour {

	public Animator animator;
	
	// Update is called once per frame
	void Update () {
	}
	public void FadeToLevel (int LevelIndex){
		animator.SetTrigger("FadeOut");
	}
}
