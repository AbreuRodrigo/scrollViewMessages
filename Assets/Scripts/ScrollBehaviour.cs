using System.Collections;
using UnityEngine;

public class ScrollBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject messagePrefab;
    [SerializeField] private RectTransform content;
    [SerializeField] private int totalMessages;

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    private void CreateFakeMessage()
    {
        Instantiate(messagePrefab, content);
    }

    public IEnumerator Coroutine()
    {
        for (int i = 0; i < totalMessages; ++i)
        {
            CreateFakeMessage();
            yield return new WaitForSeconds(2);
        }

        yield return null;
    }
}
