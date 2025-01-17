﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class CollectableKey : MonoBehaviour {
    [SerializeField] private AudioClip ding;

    private void OnTriggerEnter(Collider c)
    {
        //.TriggerEvent<BombBounceEvent, Vector3>(c.transform.position);

        if (c.attachedRigidbody && c.attachedRigidbody.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            KeyCollector bc = c.attachedRigidbody.gameObject.GetComponent<KeyCollector>();
            bc.ReceiveKey();
            AudioSource ding = GetComponent<AudioSource>();
            ding.Play();
            GameObject.Find("KeyIcon").GetComponent<Image>().enabled = true;
            Destroy(this.gameObject, .5f);
        }
    }
}
