
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Settings;

namespace Studio23.SS2.Settings.Accessibility.Core
{
    public class LanguageSettings : MonoBehaviour
    {
        [SerializeField] private bool _showSubtitleAtStart;
        private bool _currentSubtitleVisibility;
        [SerializeField] private GameObject _subtitleObject;
        public UnityEvent<int> LanguageChanged;
        public async UniTask Initialize()
        {
            //TODO load from save
            _currentSubtitleVisibility = !_showSubtitleAtStart;
            await UpdateLanguage(0);
            ToggleSubtitle();
        }

        public void ToggleSubtitle()
        {
            _currentSubtitleVisibility = !_currentSubtitleVisibility;
            _subtitleObject.SetActive(_currentSubtitleVisibility);
        }

        public async void ChangeLanguage(int localId)
        {
            await UpdateLanguage(localId);
        }

        private async UniTask UpdateLanguage(int localId)
        {
            await LocalizationSettings.InitializationOperation;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localId];
            await UniTask.CompletedTask;
            LanguageChanged?.Invoke(localId);
        }
    }
}
