using UnityEngine;
using UnityEngine.SceneManagement;

public class Fading : MonoBehaviour
{

    public Texture2D fadeOutTexture;
    public float fadeSpeed;

    private int drawDepth;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    private void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    void OnLoadCallback(Scene scene, LoadSceneMode sceneMode)
    {
        BeginFade(-2);
        SceneManager.sceneLoaded += this.OnLoadCallback;
    }
}
