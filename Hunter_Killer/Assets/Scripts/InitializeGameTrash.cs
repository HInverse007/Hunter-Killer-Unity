using UnityEngine;

// Places Animals randomly around the playing field
public class InitializeGameTrash : MonoBehaviour {
    private float secondsToWait = 5f;
    private float startTime = 0;

    public GameObject[] variousTrashPrefabs;

	void Start () {
		startTime = Time.time;
		for (int i = 0; i < 100; i++) {
			RandomTrash ();	
		}
	}

	void RandomTrash(){
		Vector3 randomVector = new Vector3 (
									 Random.Range (-50, 200), 10, Random.Range (-50, 200)
		                       );
		randomVector.y = Terrain.activeTerrain.SampleHeight (randomVector) + 0.5f;
		int randomIndex = Random.Range(0,variousTrashPrefabs.Length);
		Instantiate(variousTrashPrefabs[randomIndex], new Vector3() + randomVector, Quaternion.AngleAxis(90, Vector3.left));
	}

}
