using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

/// <summary>
/// A class that waits 3 seconds and then loads the next scene.
/// </summary>
public class SceneChanger : ITickable {

    void ITickable.Tick() {
        // Load the secondary scene after 3 seconds
        if (Time.timeSinceLevelLoad > 3) {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }
    }
}
