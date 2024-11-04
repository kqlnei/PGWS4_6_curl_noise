using UnityEngine;
using UnityEngine.UI;

public class RippleEffect : MonoBehaviour
{
    public Material rippleMaterial; // シェーダーのマテリアルを割り当て
    private Vector2 uvClickPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                transform as RectTransform,
                Input.mousePosition,
                null,
                out Vector2 localPoint);

            Rect rect = (transform as RectTransform).rect;
            uvClickPosition = new Vector2(
                (localPoint.x - rect.x) / rect.width,
                (localPoint.y - rect.y) / rect.height);

            rippleMaterial.SetVector("_ClickPosition", uvClickPosition);
        }
    }
}
