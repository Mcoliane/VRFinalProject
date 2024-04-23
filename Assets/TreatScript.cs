using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Michael

public class TreatScript : MonoBehaviour
{
    public GameObject Treat;
    public TextManager textManager;
    public ScoreManager scoreManager;
    void OnCollisionEnter(Collision collision)
    {
        if
            (collision.gameObject.name == "Dog_001")
        {

            Destroy(gameObject);
            textManager.SetText("Bark Bark");
            scoreManager.IncrementScore();

        }

    }
}
