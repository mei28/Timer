using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
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
  void Start()
  {
    restTime = 0;
    UpDateTime(restTime);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void UpDateTime(float restTime)
  {
    uiManager.UpDateTimeText(restTime);
  }
  /// <summary>
  /// ボタンを押したときに時間をどうするか
  /// </summary>
  /// <param name="value">追加する時間</param>
  public void AddTime(int value)
  {
    restTime += value;
    restTime = Mathf.Clamp(restTime, 0, maxTime);
    UpDateTime(restTime);
  }
}
