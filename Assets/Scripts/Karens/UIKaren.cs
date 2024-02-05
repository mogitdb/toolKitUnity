using UnityEngine;

public class UIKaren : MonoBehaviour
{
    public static UIKaren Instance { get; private set; }

    [SerializeField]
    private GameObject uiBootPanel; // Assign this in the inspector

    [SerializeField]
    private GameObject popUpPanel; // Assign this in the inspector

    public void ActivatePopUp()
    {
        popUpPanel.SetActive(true);
    }

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

    // Call this method when the double click event is detected on your button
    public void ActivateUIBoot()
    {
        uiBootPanel.SetActive(true);
    }
}
