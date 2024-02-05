using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneKaren : MonoBehaviour
{
    public static SceneKaren Instance { get; private set; }

    [SerializeField]
    private List<string> sceneNames; // Populate in Inspector with your scene names
    [SerializeField]
    private float delaySeconds = 5f; // Time to wait before auto-loading the next scene
    private float timeElapsed;
    private bool isSceneLoadingInitiated = false; // To prevent multiple loading calls

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        // Only run this logic if we haven't started loading the scene yet
        if (!isSceneLoadingInitiated)
        {
            // Increment the timer
            timeElapsed += Time.deltaTime;

            // If the timer exceeds the delay, or if the Spacebar is pressed, load the main menu
            if (timeElapsed > delaySeconds || Input.GetKeyDown(KeyCode.Space))
            {
                isSceneLoadingInitiated = true; // Set this to prevent re-entry into this block
                SceneSwap("MainMenu"); // Change this to the index or name as per your list
            }
        }
    }

    public void SceneSwap(string sceneName)
    {
        // Check if the scene name is valid before loading
        if (sceneNames.Contains(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError($"SceneSwap called with invalid scene name: {sceneName}");
        }
    }

    public void SceneSwap(int sceneIndex)
    {
        // Check if the scene index is valid before loading
        if (sceneIndex >= 0 && sceneIndex < sceneNames.Count)
        {
            SceneManager.LoadScene(sceneNames[sceneIndex]);
        }
        else
        {
            Debug.LogError($"SceneSwap called with invalid scene index: {sceneIndex}");
        }
    }

    // tbc
}
