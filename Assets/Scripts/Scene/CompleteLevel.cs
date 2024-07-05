using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    SceneManage sceneManage;
    [SerializeField] GameObject[] enemies;

    private void Awake()
    {
        sceneManage = FindObjectOfType<SceneManage>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        LeoMovement leo = other.GetComponent<LeoMovement>();
        if (leo != null)
        {
            foreach (GameObject enemy in enemies)
            {
                if (enemy != null) return;
            }
            if (sceneManage.CurrentScene == "Level 1")
            {
                sceneManage.ChangeScene("Level 2");
            }
            else if (sceneManage.CurrentScene == "Level 2")
            {
                sceneManage.ChangeScene("Level 3");
            }
            else if (sceneManage.CurrentScene == "Level 3")
            {
                FinishLevel(); // En caso de que todos los enemigos esten muertos
            }


        }
    }

    private void FinishLevel()
    {


        sceneManage.ChangeScene("Win");

    }
}
