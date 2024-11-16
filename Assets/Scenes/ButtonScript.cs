using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public static ButtonScript Instance { get; private set; }

    public int sceneIndex = 0;
    public int sceneCount = 0;


    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        sceneCount = SceneManager.sceneCount;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndex);
        sceneIndex += 1;
        if (sceneIndex > SceneManager.sceneCount)
        {
            sceneIndex = 0;
        }
    }

    public void TestButton()
    {
        Debug.Log($"Button clicked on scene: Scene {sceneIndex + 1}");
    }
}
