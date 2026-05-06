using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;
using CupkekGames.TimeSystem;

namespace CupkekGames.ShapeDrawing
{
    public abstract class Indicator : MonoBehaviour
    {
        protected IndicatorSettings _settings;
        public abstract UniTaskVoid AnimateFill(float duration, CancellationToken ct, TimeBundle timeBundle);
        protected abstract void SetFillProgress(float progress);
        protected abstract UniTask FillTween(float duration, CancellationToken ct, TimeBundle timeBundle);
        public async UniTask DelayedDisable(float delay, TimeBundle timeBundle)
        {
            await timeBundle.TimeContext.DelayAsync(delay);

            gameObject.SetActive(false);
        }
    }
}
