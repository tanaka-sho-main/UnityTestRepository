using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ChangeScene : MonoBehaviour
{
    //�{�^�����N���b�N���ꂽ��Ă΂��֐�
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ChangeTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
