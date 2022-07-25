using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SteveJstone
{
    [ExecuteAlways]
    public class HealthBar : MonoBehaviour
    {
        [Range(0,1)]
        [SerializeField] private float _healthAmount = 1f;

        [Title("References")]
        [SerializeField] private Image _fillImage;

        public float HealthAmount { get => _healthAmount; set => _healthAmount = value; }

        private Canvas _canvas;

        public void Awake()
        {
            _canvas = GetComponent<Canvas>();
        }

        public void Update()
        {
            var width = ((RectTransform)_canvas.transform).sizeDelta.x;
            _fillImage.rectTransform.sizeDelta = new Vector2(width * _healthAmount, _fillImage.rectTransform.sizeDelta.y);
        }
    }
}
