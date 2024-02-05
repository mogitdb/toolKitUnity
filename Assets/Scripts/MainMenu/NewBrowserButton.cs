using UnityEngine;

public class NewBrowserButton : MonoBehaviour
{
    // This method will be called when the "New Browser" button is clicked
    public void OnClick_NewBrowser()
    {
        // Call SceneKaren to swap to the BrowserHome scene
        SceneKaren.Instance.SceneSwap("BrowserHome");
    }
}
