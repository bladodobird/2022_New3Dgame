using UnityEngine;
using TMPro;

namespace YIZU
{
    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        #region 資料區
        [SerializeField, Header("對話間隔"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField, Header("開頭動畫")]
        private DialogueData dialogueOpening;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);

        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;
        #endregion

        #region 事件
        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話者台詞").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("對話結束圖示");
            goTriangle.SetActive(false);
        } 
        #endregion
    }
}