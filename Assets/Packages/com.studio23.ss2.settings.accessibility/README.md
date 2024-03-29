
# Accessibility Settings for Unity

This is accessibility setting for unity. Used for in-game accessibility settings like camera shake, camera ...

## Table of Contents

1. [Installation](#installation)
2. [Getting Started](#getting-started)
3. [Use case](#How-to-use)


## Installation


### Install via Git URL
You can also use the "Install from Git URL" option from Unity Package Manager to install the package.
```
https://github.com/Studio-23-xyz/com.studio23.ss2.settings.accessibility#upm
```

## Getting Started

### Initialization

Create Camera Settings Configuration from Create->Studio-23-xyz -> Settings -> Accessibility - > CameraSettingsConfig

Create empty GameObject and assign camera setting and language setting MonoBehaviour to them.

Assign Camera Settings Configuration to camera setting script

Create An Empty GameObject and attach the AccessibilitySettingsController MonoBehaviour to it. And assign the input action asset you want to modify.





## Use case

### How To Use

You have to initialize AccessibilitySettingsController once from any other script.

Use your preferred class from where you initialized the AccessibilitySettingsController or use button on click event to invoke 
camera setting and language setting various function of this package.

```csharp
using studio23.ss2.Settings.Accessibility.Core;

public class YourAccessibilitySettingsController : MonoBehaviour
{
    private void ToggleSubtitle()
    {
        AccessibilitySettingsController.Instance.ToggleSubtitle();
    }
}
```

That's it! You now have the basic information you need to use the **Studio23.SS2.settings.accessibility** library in your Unity project. Explore the library's features and customize it according to your game's needs.