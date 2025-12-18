    using UnityEngine;

    public class EnemyBallMovement : MonoBehaviour
    {
        public float speed = 5f;
        private Vector3 targetPosition;

        void Start()
        {
            SetNewTargetPosition();
        }

        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                SetNewTargetPosition();
            }
        }

        void SetNewTargetPosition()
        {
            // Example: Random movement within a range
            float x = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            targetPosition = new Vector3(x, transform.position.y, z);
        }
    }

        

