using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ScaleMan
{
    public class MoveSceneButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private string nextScene;

        private void Awake()
        {
            button.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(nextScene);
            });
        }
    }
}