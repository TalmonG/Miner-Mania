using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlay : MonoBehaviour
{
	

	public Slider volumeSlider;
	public GameObject ObjectMusic;

	//Value from the slider, and it converts to volume leve;
	private float MusicVolume = 0f;
	private AudioSource AudioSource;

	private void Start()
	{
		ObjectMusic = GameObject.FindWithTag("GameMusic");
		AudioSource = ObjectMusic.GetComponent<AudioSource>();

		MusicVolume = PlayerPrefs.GetFloat("volume");
		AudioSource.volume = MusicVolume;
		volumeSlider.value = MusicVolume;
	}

	private void Update()
	{
		AudioSource.volume = MusicVolume;
		PlayerPrefs.SetFloat("volume", MusicVolume);
	}

	public void volumeUpdater(float volume)
	{
		MusicVolume = volume;
	}
}
