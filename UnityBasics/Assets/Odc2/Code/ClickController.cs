using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc2
{
	public class ClickController : MonoBehaviour
	{
		[SF] private Camera _camera;

		private void Update()
		{
			if(Input.GetMouseButtonUp(0)) // Jeżeli lewy przycisk myszki został podniesiony
			{
				Ray mouseRay = _camera.ScreenPointToRay(Input.mousePosition); // Promień z pozycji myszki w głąb sceny
				if(Physics.Raycast(mouseRay, out var hitInfo ) ) // Sprawdź czy promień w coś trafił
				{
					IClickTarget clickTarget = hitInfo.collider.gameObject.GetComponent<IClickTarget>(); // Wyciągnijmy obiekt typu IClickTarget
					if ( clickTarget != null ) //Sprawdź czy był obiekt typu IClickTarget
					{
						clickTarget.Clicked(); // Powiedź obiektowi że został kliknięty
					}
				}
			}
		}
	}
}
