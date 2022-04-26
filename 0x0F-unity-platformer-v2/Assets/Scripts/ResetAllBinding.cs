using UnityEngine;
using UnityEngine.InputSystem;

public class ResetAllBinding : MonoBehaviour
{
    [SerializeField]
    private InputActionAsset inputActions;

    [SerializeField]
    private GameObject OptionsCanvas;

    [SerializeField]
    private GameObject KeyBindingCanvas;

    public void ResetActions()
    {
        foreach (InputActionMap map in inputActions.actionMaps)
        {
            map.RemoveAllBindingOverrides();
        }
        PlayerPrefs.DeleteKey("rebinds");

        KeyBindingCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
    }

    public void ConfirmedButton()
    {
        KeyBindingCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
    }
}
