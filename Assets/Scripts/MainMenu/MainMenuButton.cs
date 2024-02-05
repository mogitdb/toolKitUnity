using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    private DoubleClickButton doubleClickButton;

    private void Start()
    {
        doubleClickButton = GetComponent<DoubleClickButton>();
        if (doubleClickButton != null)
        {
            doubleClickButton.OnDoubleClick += UIKaren.Instance.ActivatePopUp;
        }
    }

    private void OnDestroy()
    {
        if (doubleClickButton != null)
        {
            doubleClickButton.OnDoubleClick -= UIKaren.Instance.ActivatePopUp;
        }
    }
}
