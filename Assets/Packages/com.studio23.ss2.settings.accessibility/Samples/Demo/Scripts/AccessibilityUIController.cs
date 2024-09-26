using System.Collections;
using System.Collections.Generic;
using Studio23.SS2.UIKit.Components;
using UnityEngine;

public class AccessibilityUIController : MonoBehaviour
{
    [SerializeField] private LabeledSlider _cameraFov;
    [SerializeField] private Rotator _cameraShake;
    [SerializeField] private Rotator _changeLanguage;
    [SerializeField] private Rotator _toggleSubtitle;
    private AccessibilitySettingsController _settingsController;

    void Start()
    {
        _settingsController = AccessibilitySettingsController.Instance;
        Initialize();
    }

    public void Initialize()
    {
        _settingsController.Initialize();
        _cameraFov.InitializeData("Camera FOV", _settingsController.CameraSettings.ReturnMinimumFov, _settingsController.CameraSettings.ReturnMaximumFov,
            _settingsController.CameraSettings.ReturnStartingFov);
        _cameraShake.InitializeData("Camera Shake", new List<string>{"On","Off"},0);
        _changeLanguage.InitializeData("Change Language", new List<string> { "English", "Japan", "Russia" }, 0);
        _toggleSubtitle.InitializeData("Show Subtitle", new List<string> { "On", "Off" }, 0);
    }

}
