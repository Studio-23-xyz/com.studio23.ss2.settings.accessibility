using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Studio23.SS2.UIKit.Components
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI LabelText;
        [SerializeField] private TextMeshProUGUI DisplayText;
        [SerializeField] private Button _leftButton;
        [SerializeField] private Button _rightButton;

        public int SelectedIndex { get; private set; }

        private IList _data;


        private void Start()
        {
            _leftButton.onClick.AddListener(Left);
            _rightButton.onClick.AddListener(Right);
        }

        public void InitializeData(string label, IList data , int selectIndex = 0)
        {
            LabelText.text=label;
            SelectedIndex = selectIndex;
            _data = data;
            ShowText();
        }


        private void ShowText()
        {
            DisplayText.text = _data[SelectedIndex].ToString();
        }

        public void Right()
        {
            if (SelectedIndex < _data.Count - 1)
            {
                SelectedIndex++;
            }
            else
            {
                SelectedIndex = 0;
            }

            ShowText();
        }


        public void Left()
        {
            if (SelectedIndex > 0)
            {
                SelectedIndex--;
            }
            else
            {
                SelectedIndex = _data.Count - 1;
            }
            ShowText();
        }
    }

}
