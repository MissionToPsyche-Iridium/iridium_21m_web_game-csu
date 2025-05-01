using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    // List the scene names where you DO want the music
    [SerializeField]
    private string[] allowedScenes;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        bool isSceneAllowed = false;

        foreach (string allowedScene in allowedScenes)
        {
            if (scene.name == allowedScene)
            {
                isSceneAllowed = true;
                break;
            }
        }

        if (!isSceneAllowed)
        {
            Destroy(gameObject); // Stop music if the new scene doesn't allow it
        }
    }

    private void OnDestroy()
    {
        // Clean up the event to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
