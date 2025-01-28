using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public SpawnerStone spawner;
        public float delay = 0.5f;
        private float m_lastSpawnedTime = 0;

        private void Start()
        {
            m_lastSpawnedTime = Time.time;
            Stone.onCollisionStone += GameOver;
        }

        private void OnEnable()
        {
            Stone.onCollisionStone += GameOver;
        }

        public void OnDisable()
        {
            Stone.onCollisionStone -= GameOver;
        }

        private void GameOver()
        {
            Debug.Log("GameOver!!!");
            enabled = false;
        }

        private void Update()
        {

           if(Time.time >= m_lastSpawnedTime + delay)
            {
                spawner.Spawn();
                m_lastSpawnedTime = Time.time;
            }
        }
    }
}