﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fading : MonoBehaviour {

    //public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private Texture2D fadeOutTexture;
    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;


    private void OnGUI() {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != "Scene 1") {
            fadeOutTexture = Texture2D.whiteTexture;
            alpha += fadeDir * fadeSpeed * Time.deltaTime;
            alpha = Mathf.Clamp01(alpha);

            GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
            GUI.depth = drawDepth;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
        }
    }

    public float BeginFade(int direction) {
        fadeDir = direction;
        return (fadeSpeed);
    }
    public void OnSceneLoaded() {
        BeginFade(-1);
    }
}
