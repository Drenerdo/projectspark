﻿//using UnityEngine;
//
//
//[RequireComponent(typeof(Light))]
//public class DayTime : MonoBehaviour
//{
//	public float fadeTime = 1;
//	public float lerpTime = 0;
//	
//	private Light lightComponent;
//	private Light lightIntensity;
//	
//	protected void Start()
//	{
//		lightComponent = GetComponent<Light>();
//		lightIntensity = lightComponent.intensity;
//		
//		lightComponent.enabled = TOD_Sky.Instance.IsDay;
//	}	
//	
//	protected void Update()
//	{
//		int sign = (TOD_Sky.Instance.IsDay) ? +1 : -1;
//		lerpTime = Mathf.Clamp01(lerpTime + sign * Time.deltaTime / fadeTime);
//		
//		lightComponent.intensity = Mathf.Lerp(0, lightIntensity, lerpTime);
//		lightComponent.enabled = (lightComponent.intensity > 0);
//	}
//}
//
