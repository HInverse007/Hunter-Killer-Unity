using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
	//public GameObject bloodSplat;
	public Text healthKeeper;
	public static int Health=50;

    void Start()
    {
		healthKeeper=GameObject.Find("health").GetComponent<Text>();
    }

    void OnCollisionEnter (Collision col)
	{
		Debug.Log(col.gameObject);
		if(col.gameObject.tag=="animal")
		{
			Debug.Log(Health);
			//Instantiate(bloodSplat,col.transform.position,col.transform.rotation);
			Health-=3;
			healthKeeper.text="Health: "+ Health +" " ;
			if(Health<=0)
			{
				showFail();
			}
		}

	}
	void showFail(){
		ApplicationModel.Score=0;
		SceneManager.UnloadSceneAsync("HuntingGameScene");
		SceneManager.LoadScene ("MainMenuScene");
	}
}
