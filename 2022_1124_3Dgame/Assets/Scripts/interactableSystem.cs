using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 互動系統:偵測玩家的進入並執行
    /// </summary>
    public class interactableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData GetDialogue;

        private string nameTarget = "PlayerCapsule";

        // 3D物件適用
        // 兩個碰撞物其中一個必須勾選 is trigger
        // 碰撞開始
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
        }

        // 碰撞結束
        private void OnTriggerExit(Collider other)
        {

        }

        // 碰撞持續
        private void OnTriggerStay(Collider other)
        {
            
        }
    }
}