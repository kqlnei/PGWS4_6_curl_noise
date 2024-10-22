using UnityEngine;

public class MouseInputToShader : MonoBehaviour
{
    public Material targetMaterial; // シェーダーがアタッチされているマテリアル

    void Update()
    {
        if (Input.GetMouseButton(0)) // マウスがクリックされているとき
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane; // マウスのZ軸を設定（カメラに基づく）
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            // マウス位置をシェーダーに渡す
            targetMaterial.SetVector("_MousePosition", worldPos);

            // マウスの位置をコンソールに出力して確認
            Debug.Log("Mouse Position: " + worldPos);
        }
    }
}
