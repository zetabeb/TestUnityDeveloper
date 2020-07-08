using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        [Tooltip("What is the name of the scene we want to load when clicking the button?")]
        public string SceneName;

        public void LoadTargetScene() 
        {
            SceneManager.LoadSceneAsync(SceneName);
        }

        public void SetSceneName(string SceneName)
        {
            this.SceneName = SceneName;
            PlayerPrefs.SetString("SceneActual", SceneName);
        }

        public void LoadSceneActual()
        {
            SceneManager.LoadSceneAsync(PlayerPrefs.GetString("SceneActual"));
        }
    }
}
