using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingManager : MonoBehaviour {
  /// <summary>
  /// タイマーの状態
  /// </summary>
  private bool isRunning = false;
  /// <summary>
  /// タイマーを変更させるもの
  /// </summary>
  [SerializeField] private UIManager uiManager;
  /// <summary>
  /// 残り時間
  /// </summary>
  private float restTime;
  /// <summary>
  /// タイマーの最大値
  /// </summary>
  private int maxTime = 5999;
  // Start is called before the first frame update
  void Start () {
    restTime = 0;
    uiManager = GetComponent<UIManager> ();
    UpDateTime ();
  }

  // Update is called once per frame
  void Update () {
    if (isRunning) {
      restTime -= Time.deltaTime;

      if (restTime < 0) {
        Debug.Log ("Finish!");
        restTime = 0;
        isRunning = false;

      }
      UpDateTime ();
    }
  }

  void UpDateTime () {
    uiManager.UpDateTimeText (restTime);
  }
  /// <summary>
  /// ボタンを押したときに時間をどうするか
  /// </summary>
  /// <param name="value">追加する時間</param>
  public void AddTime (int value) {
    restTime += value;
    restTime = Mathf.Clamp (restTime, 0, maxTime);
    UpDateTime ();
  }
  /// <summary>
  /// スタートボタンを押したとき
  /// </summary>
  public void OnStartButton () {
    isRunning = true;
    uiManager.StartTimer ();
  }
  /// <summary>
  /// ストップボタンを押したとき
  /// </summary>
  public void OnStopButton () {
    isRunning = false;
    uiManager.StopTimer ();
  }

  public void OnButton () {
    if (isRunning)
      OnStopButton ();
    else
      OnStartButton ();
  }
}