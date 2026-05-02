using System;
using UnityEngine;

namespace CupkekGames.ShapeDrawing
{
    [Serializable]
    public class IndicatorSettings
    {
        [SerializeField] public float OpacityBgInner = 0.05f;
        [SerializeField] public float OpacityBgOuter = 0f;
        [SerializeField] public float OpacityFillInner = 0.15f;
        [SerializeField] public float OpacityFillOuter = 0.05f;
        [SerializeField] public float OpacityStroke = 0.2f;
    }
}