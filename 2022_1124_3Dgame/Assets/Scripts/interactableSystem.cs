using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// ���ʨt��:�������a���i�J�ð���
    /// </summary>
    public class interactableSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܸ��")]
        private DialogueData GetDialogue;

        private string nameTarget = "PlayerCapsule";

        // 3D����A��
        // ��ӸI�����䤤�@�ӥ����Ŀ� is trigger
        // �I���}�l
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
        }

        // �I������
        private void OnTriggerExit(Collider other)
        {

        }

        // �I������
        private void OnTriggerStay(Collider other)
        {
            
        }
    }
}