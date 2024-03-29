using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Studio23.SS2.UIKit.Components
{
    public class LabeledSlider : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI LabelText;
        [SerializeField] private TextMeshProUGUI DisplayText;
     
        [SerializeField] Slider _slider;


        public float Value => _slider.value;

        void Start()
        {
            _slider.onValueChanged.AddListener(UpdateText);
        }

        public void InitializeData(string label, float minValue=0, float maxValue=1, float value = 0)
        {
            LabelText.text=label;
            _slider.value=value;
            _slider.minValue=minValue;
            _slider.maxValue=maxValue;
            UpdateText(value);
        }


        

        private void UpdateText(float value)
        {
            DisplayText.text = value.ToString("P0");
        }
    }

}
