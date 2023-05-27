using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    private AudioSource _audioSource;
    private float _volumeChange = 0.1f;
    private float _maxVolume = 1;
    private float _minVolume = 0;
    private bool _isThiefInHouse = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isThiefInHouse = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isThiefInHouse = false;
    }

    private void Update()
    {
        if(_audioSource.volume < _maxVolume && _isThiefInHouse)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _maxVolume, _volumeChange * Time.deltaTime);
        }
        else
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _minVolume, _volumeChange * Time.deltaTime);
        }
    }
}
