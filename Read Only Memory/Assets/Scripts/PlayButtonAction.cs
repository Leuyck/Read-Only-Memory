using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButtonAction : MonoBehaviour {
    

   /* private void OnMouseDown() {
        ChangeLevel();
    }*/

    public void PlayTheGame() {

        SceneManager.LoadScene("Scene 1");

    }
}
