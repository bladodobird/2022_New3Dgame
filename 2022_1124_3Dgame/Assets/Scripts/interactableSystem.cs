using UnityEngine;
using UnityEngine.Events;

namespace YIZU
{
    /// <summary>
    /// 互動系統:偵測玩家的進入並執行
    /// </summary>
    public class interactableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;  //增加unity事件

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }

        // 3D物件適用
        // 兩個碰撞物其中一個必須勾選 is trigger
        // 碰撞開始
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                print(other.name);
                dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
            }

        }

        // 碰撞結束
        private void OnTriggerExit(Collider other)
        {

        }

        // 碰撞持續
        private void OnTriggerStay(Collider other)
        {

        }

        /// <summary>
        /// 隱藏物件
        /// </summary>
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    }
}