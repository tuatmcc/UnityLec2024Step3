using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class DogImage : MonoBehaviour, Interactable
{
    [Serializable]
    private class JsonResponse
    {
        public string message;
        public string status;
    }
    
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void Interact()
    {
        GetDogImage().Forget();
    }

    private async UniTask GetDogImage()
    {
        UnityWebRequest jsonrequest = UnityWebRequest.Get("https://dog.ceo/api/breeds/image/random");
        await jsonrequest.SendWebRequest();
        string json = jsonrequest.downloadHandler.text;
        
        JsonResponse response = JsonUtility.FromJson<JsonResponse>(json);
        UnityWebRequest imagerequest = UnityWebRequestTexture.GetTexture(response.message);
        await imagerequest.SendWebRequest();
        Texture2D texture = DownloadHandlerTexture.GetContent(imagerequest);
        spriteRenderer.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }
}
