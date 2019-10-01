using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc4
{
	public class ClickController : MonoBehaviour
	{
		private const int ALLOCATION_SIZE = 5;

		[SF] private Camera _camera;
		[SF] private LayerMask _targetLayers;
		[SF] private CastMode _castMode;

		private ICaster Caster => GetComponent<ICaster>();
		private RaycastHit[] _allocatedHits;

		private void Awake()
		{
			if(_castMode == CastMode.NonAllocCast )
			{
				_allocatedHits = new RaycastHit[ALLOCATION_SIZE];
			}
		}

		private void Update()
		{
			if(Input.GetMouseButtonUp(0)) // Jeżeli lewy przycisk myszki został podniesiony
			{
				Ray mouseRay = _camera.ScreenPointToRay(Input.mousePosition); // Promień z pozycji myszki w głąb sceny

				if( _castMode  == CastMode.SingleCast )
				{
					SingleCast( mouseRay, _camera.farClipPlane );
				}
				else if(_castMode == CastMode.AllCast )
				{
					AllCast( mouseRay, _camera.farClipPlane );
				}
				else if(_castMode == CastMode.NonAllocCast )
				{
					NonAllocCast( mouseRay, _camera.farClipPlane );
				}
			}
		}

		private void SingleCast( Ray mouseRay, float maxDistance )
		{
			if( Caster == null )
			{
				Debug.LogWarning( "There is no ICaster for ClickController" );
				return;
			}

			if ( Caster.Cast( mouseRay, out var hitInfo, maxDistance, _targetLayers ) ) // Sprawdź czy caster w coś trafił
			{
				IClickTarget clickTarget = hitInfo.collider.gameObject.GetComponent<IClickTarget>(); // Wyciągnijmy obiekt typu IClickTarget
				if ( clickTarget != null ) //Sprawdź czy był obiekt typu IClickTarget
				{
					clickTarget.Clicked(); // Powiedź obiektowi że został kliknięty
				}
			}
		}

		private void AllCast( Ray mouseRay, float maxDistance )
		{
			if ( Caster == null )
			{
				Debug.LogWarning( "There is no ICaster for ClickController" );
				return;
			}

			var allHits = Caster.CastAll( mouseRay, maxDistance, _targetLayers );
			foreach ( var hit in allHits )
			{
				IClickTarget clickTarget = hit.collider.gameObject.GetComponent<IClickTarget>(); // Wyciągnijmy obiekt typu IClickTarget
				if ( clickTarget != null ) //Sprawdź czy był obiekt typu IClickTarget
				{
					clickTarget.Clicked(); // Powiedź obiektowi że został kliknięty
				}
			}
		}

		private void NonAllocCast( Ray mouseRay, float maxDistance )
		{
			if ( Caster == null )
			{
				Debug.LogWarning( "There is no ICaster for ClickController" );
				return;
			}

			var hitsCount = Caster.CastNonAlloc( mouseRay, _allocatedHits, maxDistance, _targetLayers );
			for(int i = 0; i < hitsCount; i++ )
			{
				IClickTarget clickTarget = _allocatedHits[i].collider.gameObject.GetComponent<IClickTarget>(); // Wyciągnijmy obiekt typu IClickTarget
				if ( clickTarget != null ) //Sprawdź czy był obiekt typu IClickTarget
				{
					clickTarget.Clicked(); // Powiedź obiektowi że został kliknięty
				}
			}
		}

		// Można (a nawet powinno się [chyba że overengineering xd]) przerobić na wzór strategii, może to zostać protraktowane jako zazdanie do Ciebie
		protected enum CastMode
		{
			SingleCast,
			AllCast,
			NonAllocCast
		}
	}
}
