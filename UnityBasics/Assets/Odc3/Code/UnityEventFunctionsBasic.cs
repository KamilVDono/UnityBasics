using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Odc3.Odc3_Utils;

namespace Odc3
{
	public class UnityEventFunctionsBasic : MonoBehaviour
	{
		#region Common
		// Tutaj inicjalizacja obiektu w obrębie tego skryptu (ustawianie początkowych wartości, konstrukcja słownika z zapisanych list ipt)
		private void Awake()
		{
			Log();
		}

		// Tutaj logika związana z włączaniem skryptu (włączenie zachowań itp) 
		private void OnEnable()
		{
			Log();
		}

		// Tutaj inicjalizacja związana ze środowiskiem zewnętrznym (pobranie referencji, komunikacja z innymi obiektami itp)
		private void Start()
		{
			Log();
		}

		// Tutaj stała logika związana z fizyką (przesuwanie obiektów fizycznych, obliczenia mające wpływ na fizykę itp)
		private void FixedUpdate()
		{
			Log();
		}

		// Tutaj logika która nie oddziaływuje na ciała fizyczne (wydawanie poleceń jednostkom, wyznaczanie zachowania itp)
		private void Update()
		{
			Log();
		}

		// Tutaj logika która nie oddziaływuje na ciała fizyczne, ale ma się wykonać po Update (poruszanie kamery za graczem itp)
		private void LateUpdate()
		{
			Log();
		}
		#endregion Common

		#region Disabling
		// Kiedy aplikacja jest pauzowana (na IOS i Androidzie sprawdzaj czy użytkownik wysłał/przywrócił grę z tła)
		private void OnApplicationPause( bool pause )
		{
			Log( $"{nameof( pause)}:{pause}" );
		}

		// Kiedy okno aplikacji dostaje / traci focus(skupienie?? nie wiem jak to przetłumaczyć poprawnie) 
		private void OnApplicationFocus( bool focus )
		{
			Log( $"{nameof( focus )}:{focus}" );
		}

		// Tutaj wyłączaj zachowania (odepnij się od słuchania zdarzeń itp)
		private void OnDisable()
		{
			Log();
		}

		// Tutaj posprzątaj po sobie (zakończ relacjia, połączenia itp)
		private void OnDestroy()
		{
			Log();
		}

		// Zamknięcie aplikacji (zapisz szybciusio stan itp) [na systemach mobilnych nie można ufać]
		private void OnApplicationQuit()
		{
			Log();
		}
		#endregion Disabling

		#region Rendering
		// Tutaj rysowanie GUI w trybie IMGUI
		private void OnGUI()
		{
			Log( );
		}
		#endregion Rendering
	}
}
