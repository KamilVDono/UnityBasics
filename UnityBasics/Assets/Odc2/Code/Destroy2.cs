using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc2
{
	public class Destroy2 : MonoBehaviour, IClickTarget
	{
		[SF][Range(0f, 15f)] private float _timeToDestory = 1f;

		public void Clicked()
		{
			MeshRenderer meshRenderer = GetComponent<MeshRenderer>(); // Spróbuj pobrać komponent MeshRenderer
			if ( meshRenderer != null )
			{
				meshRenderer.material.color = RandomColor; // Zmień kolor na losowy
			}
			Destroy( this, _timeToDestory ); // Zniszcz KOMPONENT po czasie _timeToDestory
		}

		private Color RandomColor => new Color( Random.Range( 0f, 1f ), Random.Range( 0f, 1f ), Random.Range( 0f, 1f ) );
	}
}

