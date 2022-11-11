using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   public ScoreManager scoreManager;

   public int scoreToGive;

   public AudioSource m_explodingSound;

   

   void Start()
   {
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
      m_explodingSound = GetComponent<AudioSource>();
   }
   void OnTriggerEnter(Collider other)
   {
    scoreManager.IncreaseScore(scoreToGive);
    Destroy(gameObject); //Destroy this gameobject
    Destroy(other.gameObject); //Destroy the other game object
   }

   void OntriggerEnter(Collider collision)
   {
      if (collision.transform.tag == "UFO")
      {
         m_explodingSound.Play();
      }
   }
}
