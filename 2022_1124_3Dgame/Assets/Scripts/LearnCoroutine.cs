using UnityEngine;
using System.Collections;

namespace YIZU
{
    /// <summary>
    /// ��P�{�ǡA²�٨�{ coroutine
    /// �ت� : ���{�����d�F�쵥�ݪ��ĪG
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        /// ��{�ϥΥ|�ӱ���
        /// 1.�ޥΩR�W�Ŷ� System.Collections
        /// 2.�w�q�@�ӶǦ^ IEnumerator ����k
        /// 3.��k�������ϥ� yield return (����)
        /// 4.�ϥ� StartCoroutine �Ұ�

        /// �r�� string �� char �}�C
        private string testDialogue = "�o�̦n���ơA�ڷQ���}...";

        private void Awake()
        {
            StartCoroutine(Test());

            print("���o���չ�ܪ��Ĥ@�Ӧr:" + testDialogue[0]);
            
            StartCoroutine(ShowDialogue());
        }

        private IEnumerator Test()
        {
            print("<color=#33ff33>�Ĥ@��{��</color>");
            yield return new WaitForSeconds(1);
            print("<color=#ff3333>�ĤG��{��</color>");
            yield return new WaitForSeconds(2);
            print("<color=#3333ff>�ĤG��{��</color>");
            yield return new WaitForSeconds(3);
        }

        private IEnumerator ShowDialogue()
        {
            print("<color=#33ff33>�Ĥ@��{��</color>");
            yield return new WaitForSeconds(0.1f);
            print("<color=#ff3333>�ĤG��{��</color>");
            yield return new WaitForSeconds(0.1f);
            print("<color=#3333ff>�ĤG��{��</color>");
            yield return new WaitForSeconds(0.1f);
        }
    }
}