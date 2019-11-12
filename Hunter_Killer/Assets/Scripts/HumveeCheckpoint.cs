using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HumveeCheckpoint : MonoBehaviour {
	public Text InfoText;

    void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "FPSController") {
			InfoText.text = "Press E to leave the Fighting zone...";
		}
	}

	void OnTriggerStay(Collider col){
		if (col.gameObject.name == "FPSController" && Input.GetButtonDown ("e")) {
			ApplicationModel.Score = Projectile.currentScore;
			SceneManager.UnloadSceneAsync("HuntingGameScene");
			if (ApplicationModel.Score >= 1000)
			{
				SceneManager.LoadScene("End_scene");
			}
			else
			{
				SceneManager.LoadScene ("MainMenuScene");
			}
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.name == "FPSController"){
			InfoText.text = "";	
		}
	}

}
