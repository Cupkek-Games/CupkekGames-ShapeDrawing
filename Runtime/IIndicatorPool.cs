using UnityEngine;

namespace CupkekGames.ShapeDrawing
{
    public interface IIndicatorPool
    {
        Indicator ShowArcRegion(Vector3 position, Quaternion rotation, float radius, float angle, Color? color = null);
        Indicator ShowCircleRegion(Vector3 position, float radius, Color? color = null);
        Indicator ShowLineRegion(Vector3 position, Quaternion rotation, float length, float width, Color? color = null);
    }
}
