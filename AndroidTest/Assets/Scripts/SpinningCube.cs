using UnityEngine;
using System.Collections;

public class SpinningCube : MonoBehaviour 
{
	public float m_Speed = 20f;
    public float movspeed = 5f;

	private Vector3 m_RotationDirection = Vector3.up;
    private Vector3 m_MovementDirection = Vector3.up;

	public void ToggleRotationDirection()
	{
		Debug.Log ("Toggling rotation direction");

		if (m_RotationDirection == Vector3.up) 
		{
			m_RotationDirection = Vector3.down;
		}
		else 
		{
			m_RotationDirection = Vector3.up;
		}
	}

    
    

	void Update() 
	{
		//transform.Rotate(m_RotationDirection * Time.deltaTime * m_Speed);

        //Vector3 pos = transform.position;
        //Vector3 velocity = new Vector3(0, movspeed * Time.deltaTime, 0);
        //pos += transform.rotation * velocity;

        //transform.position = pos;
	}
}
