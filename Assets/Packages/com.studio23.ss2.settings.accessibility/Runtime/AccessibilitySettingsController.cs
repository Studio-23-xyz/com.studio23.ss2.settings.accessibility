
using Studio23.SS2.Settings.Accessibility.Core;
using UnityEngine;

public class AccessibilitySettingsController : MonoBehaviour
{
    public static AccessibilitySettingsController Instance;

    public CameraSettings CameraSettings;
    public LanguageSettings LanguageSettings;


    void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    void Start()
    {
        Initialize();
    }

    public async void Initialize()
    {
        CameraSettings.Initialize();
        await LanguageSettings.Initialize();
    }
}
