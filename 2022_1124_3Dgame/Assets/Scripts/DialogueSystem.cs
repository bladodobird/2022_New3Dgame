using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.Events;

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
        [SerializeField, Header("對話按鍵")]
        private KeyCode dialogueKey = KeyCode.Space;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);

        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;
        #endregion

        private UnityEvent onDialogueFinish;
        private PlayerInput playerInput; //輸入玩家元件 (處理看完對話玩家才能移動部分)

        #region 事件
        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話者台詞").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("對話結束圖示");
            goTriangle.SetActive(false);

            playerInput = GameObject.Find("PlayerCapsule").GetComponent<PlayerInput>();

            StartDialogue(dialogueOpening);
        }
        #endregion

        public void StartDialogue(DialogueData data, UnityEvent _onDialogueFinish = null)
        {
            playerInput.enabled = false;  // 關閉 玩家輸入元件
            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect(data));
            onDialogueFinish = _onDialogueFinish;
        }
        /// <summary>
        /// 淡入淡出
        /// </summary>
        private IEnumerator FadeGroup(bool fadeIn = true)
        {
            // 三元運算子 ?
            // 語法
            // 布林值?範例 1:10, true ? 是1 ,false ? 是10

            float increase = fadeIn ? +0.1f : -0.1f;

            for (int i = 0; i < 10; i++)
            {
                groupDialogue.alpha += increase;
                yield return new WaitForSeconds(0.04f);
            }
        }

        /// <summary>
        /// 打字效果
        /// </summary>
        /// <returns></returns>
        private IEnumerator TypeEffect(DialogueData data)
        {
            textName.text = data.dialogueName;

            for (int j = 0; j < data.dialogueContents.Length; j++)
            {
                textContent.text = "";
                goTriangle.SetActive(false);

                string dialogue = data.dialogueContents[j];


                for (int i = 0; i < dialogue.Length; i++)
                {
                    textContent.text += dialogue[i];
                    yield return dialogueInterval;
                }

                goTriangle.SetActive(true);

                // 如果玩家 還沒(!)按下 指定按鈕 就等待
                while (!Input.GetKeyDown(dialogueKey))
                {
                    yield return null;
                }

                print("<color=#993300>玩家按下按鍵!</color>");
            }

            StartCoroutine(FadeGroup(false));

            playerInput.enabled = true; // 開啟 玩家輸入元件
            onDialogueFinish.Invoke(); // 對話結束事件,呼叫()
        }

    }
}