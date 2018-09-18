using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class cargarEscena : MonoBehaviour {

	// Use this for initialization
	public void loadScene(int scene){
		SceneManager.LoadScene (scene);
	}

}
