using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeSceneOnClick : MonoBehaviour {
    public string scene;

    private void OnMouseDown()
    {
        ChangeLevel();
    }

   /* bool changeScene;
    private void Awake() {
        changeScene = false;
    }
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            // Check if the mouse was clicked over a UI element
            if (EventSystem.current.IsPointerOverGameObject()) {
                changeScene = true;
            }
        }
    }
    */
    private void ChangeLevel() {
        //float fadeTime = GameObject.Find("FadeInAndOut").GetComponent<Fading>().BeginFade(1);

        //yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(scene);

    }

}
