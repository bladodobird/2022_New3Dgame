using System.Collections;
using UnityEngine;

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
        
        private IEnumerator Test()
        {
            print("<color=#33ff33>�Ĥ@��{��</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>�ĤG��{��</color>");
        }

    }
}