using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.GetComponent<Ball>();

        if (b != null)
        {
            if (b.Point == 0)
            {
                GameManager.instance.ShowString($"White ball drop\n You loes!");
                Time.timeScale = 0;
            }
            else
            {
                GameManager.instance.ShowScoreText(b.Point);
            }
         
           
            GameManager.instance.ShowScoreText(b.Point);
            Destroy(b.gameObject );
        }

    }
}
