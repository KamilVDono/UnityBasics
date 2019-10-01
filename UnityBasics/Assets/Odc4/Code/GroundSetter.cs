using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc4
{
	[ExecuteInEditMode]
	public class GroundSetter : MonoBehaviour
	{
		[SF] private LayerMask _groundLayer;

		private void Awake()
		{
			// Chcemy wykonywać skrypt tylko w edytorze
			if ( Application.isPlaying )
			{
				Destroy( this );
			}
		}

		private void Update()
		{
			// Sprawdzamy czy już czasem nie stoimy na ziemi
			if(Physics.CheckSphere(transform.position, 0.02f, _groundLayer ) )
			{
				return;
			}

			// Puszczamy promień w dół modelu
			if(Physics.Raycast(transform.position, -transform.up, out var groundHit, 100f, _groundLayer ) )
			{
				transform.position = groundHit.point;
			}
		}
	}
}
