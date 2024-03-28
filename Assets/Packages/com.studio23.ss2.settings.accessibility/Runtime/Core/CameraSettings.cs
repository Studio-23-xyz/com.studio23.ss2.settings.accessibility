using Cinemachine;
using Studio23.SS2.Settings.Accessibility.Data;
using UnityEngine;

namespace Studio23.SS2.Settings.Accessibility.Core
{
    public class CameraSettings : MonoBehaviour
    {
        private CinemachineVirtualCamera _vCam;
        private bool _currentShakeState;
        [SerializeField]private CameraSettingsConfiguration _cameraSettingsConfiguration;

        public void Initialize()
        {
            //TODO has to load from save
            
            _currentShakeState = !_cameraSettingsConfiguration.CameraShakeAtStart;
            UpdateVirtualCamera();
            ToggleCameraShake();
            ChangeCameraFov(_cameraSettingsConfiguration.StartingCameraFOV);
            
        }

        public void ChangeCameraFov(float targetFov)
        {
            _vCam.m_Lens.FieldOfView = targetFov;
        }

        public void ToggleCameraShake()
        {
            _currentShakeState = !_currentShakeState;
            _vCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile = _currentShakeState
                ? _cameraSettingsConfiguration.ShakeNoiseAsset
                : _cameraSettingsConfiguration.EmptyNoiseAsset;
        }

        private void UpdateVirtualCamera()
        {
            //TODO has to fire this event when active camera switches
            _vCam = CinemachineCore.Instance.GetActiveBrain(0).ActiveVirtualCamera.VirtualCameraGameObject
                .GetComponent<CinemachineVirtualCamera>();
        }

        public float ReturnMaximumFov => _cameraSettingsConfiguration.MaximumCameraFOV;
        public float ReturnMinimumFov => _cameraSettingsConfiguration.MaximumCameraFOV;
        public float ReturnStartingFov => _cameraSettingsConfiguration.StartingCameraFOV;

    }
}
