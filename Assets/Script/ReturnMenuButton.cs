﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnMenuButton : MonoBehaviour {
    public void OnClickExit() {
        GameManager.stageLevel = 0;
        SceneManager.LoadScene("0");
    }

}
