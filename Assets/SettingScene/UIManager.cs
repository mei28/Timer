﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
  /// <summary>
  /// 設定用のタイマー表示
  /// </summary>
  [SerializeField] private Text timerText;
  /// <summary>
  /// スタートボタン
  /// </summary>
  [SerializeField] private Text StartBotton;
  /// <summary>
  /// 設定用のボタン群
  /// </summary>
  /// <returns></returns>
  [SerializeField] private GameObject timerSettingButtons;

  /// <summary>
  /// タイマーのテキストの更新
  /// </summary>
  /// <param name="time">変更する時間</param>
  public void UpDateTimeText(float time)
  {
    timerText.text = string.Format("{0:00}:{1:00}", (int)(time / 60), time % 60);
  }
}
