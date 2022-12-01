using TMPro;
using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// ��ܨt��
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܶ��j"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;

        private WaitForSeconds dialogueInterval;
        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;
    }
}