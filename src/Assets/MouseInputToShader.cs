using UnityEngine;

public class MouseInputToShader : MonoBehaviour
{
    public Material targetMaterial; // �V�F�[�_�[���A�^�b�`����Ă���}�e���A��

    void Update()
    {
        if (Input.GetMouseButton(0)) // �}�E�X���N���b�N����Ă���Ƃ�
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane; // �}�E�X��Z����ݒ�i�J�����Ɋ�Â��j
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            // �}�E�X�ʒu���V�F�[�_�[�ɓn��
            targetMaterial.SetVector("_MousePosition", worldPos);

            // �}�E�X�̈ʒu���R���\�[���ɏo�͂��Ċm�F
            Debug.Log("Mouse Position: " + worldPos);
        }
    }
}
