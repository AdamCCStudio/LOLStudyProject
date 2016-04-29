using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour
{

    #region 登陆面板部分
    [SerializeField]
    private InputField inputAccount;
    [SerializeField]
    private InputField inputPassword;
    #endregion

    [SerializeField]
    private Button btnLogin;
    [SerializeField]
    private GameObject regPanel;

    #region 注册面板部分
    [SerializeField]
    private InputField regAccountInput;
    [SerializeField]
    private InputField regPwInput;
    [SerializeField]
    private InputField regPwRepeateInput;
    #endregion

    public void loginOnClick()
    {
        if (inputAccount.text.Length == 0 || inputAccount.text.Length > 6)
        {
            Debug.Log("帐号不合法");
            return;
        }

        if (inputPassword.text.Length == 0 || inputPassword.text.Length > 15)
        {
            Debug.Log("密码不合法");
            return;
        }

        //验证通过，申请登录
        //btnLogin.enabled = false;
        btnLogin.interactable = false;
    }

    public void regOnClick()
    {
        regPanel.SetActive(true);
    }

    public void regCloseOnClick()
    {
        regPanel.SetActive(false);
    }

    public void regPanelRegOnClick()
    {
        if (regAccountInput.text.Length == 0 || regAccountInput.text.Length > 6)
        {
            Debug.Log("帐号不合法");
            return;
        }

        if (regPwInput.text.Length == 0 || regPwInput.text.Length > 15)
        {
            Debug.Log("密码不合法");
            return;
        }
        if (!regPwInput.text.Equals(regPwRepeateInput.text))
        {
            Debug.Log("两次输入密码不一致");
            return;
        }

        // 验证通过，申请注册，并关闭注册面板
        regPanel.SetActive(false);
    }
}
