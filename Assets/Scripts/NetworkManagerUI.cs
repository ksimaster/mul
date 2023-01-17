using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;

    private void Awake()
    {
        hostButton.onClick.AddListener(call: (() =>
        {
            NetworkManager.Singleton.StartHost();
        }));

        clientButton.onClick.AddListener(call: (() =>
        {
            NetworkManager.Singleton.StartClient();
        }));
    }
}
