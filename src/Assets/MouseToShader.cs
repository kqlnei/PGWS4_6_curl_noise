using UnityEngine;

public class MouseToShader : MonoBehaviour
{
    public Material material; // Shaderがアタッチされているマテリアル
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        // マウスクリックの検出
        if (Input.GetMouseButton(0)) // 0は左クリック
        {
            // マウスのスクリーン座標を取得
            Vector3 mousePos = Input.mousePosition;

            // マウス座標を0〜1の範囲に正規化
            Vector2 normalizedMousePos = new Vector2(mousePos.x / Screen.width, mousePos.y / Screen.height);

            // マテリアルのプロパティに送信 (例: "_MousePosition"という名前のVector2プロパティ)
            material.SetVector("_MousePosition", normalizedMousePos);
        }
    }
}
