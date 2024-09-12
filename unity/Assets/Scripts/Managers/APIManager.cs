using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class APIManager : MonoBehaviour
{
    private string apiUrl = "http://j11e101.p.ssafy.io:5000/api";

    // �α��� ��û�� ������ �Լ�
    public IEnumerator Login(string userId, string password, System.Action<User> onSuccess, System.Action<string> onError)
    {
        // �ּ� ó���� ���� ��û �κ� ����
        // ������ ���� ������ ����
        // WWWForm form = new WWWForm();
        // form.AddField("userId", userId);
        // form.AddField("password", password);

        // POST ��û�� ���� UnityWebRequest ��ü ����
        // using (UnityWebRequest request = UnityWebRequest.Post(apiUrl, form))
        // {
        //     // ��û ���� �� ���� ���
        //     yield return request.SendWebRequest();

        //     // ���� ó��
        //     if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        //     {
        //         Debug.LogError("Error: " + request.error);
        //         onError?.Invoke(request.error);
        //         yield break; // ���� �߻� �� �޼ҵ� ����
        //     }

        //     // ���� ���� ó��
        //     string responseData = request.downloadHandler.text;
        //     Debug.Log("Response Data: " + responseData);

        //     // ���� �����͸� User ��ü�� ��ȯ
        //     User user = ParseUserFromResponse(responseData);
        //     onSuccess?.Invoke(user);
        // }

        // ��¥ �����ͷ� �׽�Ʈ
        yield return new WaitForSeconds(0.2f); // ���� ���� ��� �ùķ��̼�

        // ��¥ User ��ü ����
        User user = ParseUserFromResponse();
        onSuccess?.Invoke(user);

        // ���� ó�� �׽�Ʈ��
         //onError?.Invoke("��¥ ���� �޽���"); // �ּ� ���� �� ���� ó�� �׽�Ʈ ����

        yield return null;
    }

    // ���� �����Ϳ��� User ��ü�� �����ϴ� �Լ�
    private User ParseUserFromResponse()
    {
        // ���� ���� ������ �Ľ� ���� ���� (��: JSON �Ľ�)
        // ���⼭�� ������ ��¥ �����͸� ��ȯ�ϵ��� ����
        User user = new User();
        user.title = "����� ���";  // ���� �Ľ̵� �����ͷ� ����
        user.name = "������";
        user.userId = "zxader";
        return user;
    }

    public IEnumerator Join(string name, string userId, string pwd, Image imgNO, System.Action<string> onSuccess, System.Action<string> onError)
    {
        // ������ ���� ������ ����
        // WWWForm form = new WWWForm();
        //form.AddField("name", name);
        //form.AddField("userId", userId);
        //form.AddField("pwd", pwd);
        //form.AddField("imgNO", imgNO);

        // POST ��û�� ���� UnityWebRequest ��ü ����
        //using (UnityWebRequest request = UnityWebRequest.Post(apiUrl, form))
        //{
        //    // ��û ���� �� ���� ���
        //    yield return request.SendWebRequest();

        //    // ���� ó��
        //    if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        //    {
        //        Debug.LogError("Error: " + request.error);
        //        onError?.Invoke(request.error);
        //        yield break; // ���� �߻� �� �޼ҵ� ����
        //    }

        //}

        // ��¥ �����ͷ� �׽�Ʈ
        yield return new WaitForSeconds(0.2f); // ���� ���� ��� �ùķ��̼�

    // ��¥ User ��ü ����
    onSuccess?.Invoke("ȸ������ ����");

    // ���� ó�� �׽�Ʈ��
    //onError?.Invoke("��¥ ���� �޽���"); // �ּ� ���� �� ���� ó�� �׽�Ʈ ����

    yield return null;
    }
}
