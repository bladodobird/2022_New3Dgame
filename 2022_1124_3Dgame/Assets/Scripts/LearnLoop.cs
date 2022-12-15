using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 認識迴圈 : 重複執行程式
    /// for while dowhile foreach
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            // for迴圈語法:
            // for(初始值; 布林值 條件; 迴圈結束執行區域) {程式區塊}
            for (int i = 0; i < 10; i++)
            {
                print("for 迴圈內容 : " + i);
            }

            for (int number = 0; number < 5; number++)
            {
                print("迴圈 : " + number);
            }

            if (true)
            {
                print("判斷式");
            }

            int count = 0;

            while (count < 5)
            {
                print("() 內的布林值是true就會 持續 執行");
                print("while 迴圈數字 : " + count);
                count++;
            }
        }
    }
}