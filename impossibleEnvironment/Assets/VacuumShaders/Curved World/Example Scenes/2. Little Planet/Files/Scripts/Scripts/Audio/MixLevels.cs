﻿using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

namespace VacuumShaders.CurvedWorld.Example
{

    public class MixLevels : MonoBehaviour
    {

        public AudioMixer masterMixer;

        public void SetSfxLvl(float sfxLvl)
        {
            masterMixer.SetFloat("sfxVol", sfxLvl);
        }

        public void SetMusicLvl(float musicLvl)
        {
            masterMixer.SetFloat("musicVol", musicLvl);
        }
    }
}