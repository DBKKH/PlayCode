using System;
using System.Collections;
using System.Collections.Generic;

public class CalcDictionary
{
    //計測用のenum
    private enum EnumKey
    {
        Key1 = 0, Key2, Key3, Key4
    }

    //計測用のDict
    private Dictionary<EnumKey, int> _enumDict = new Dictionary<EnumKey, int>()
    {
        {EnumKey.Key1, 1}, {EnumKey.Key2, 2}, {EnumKey.Key3, 3}, {EnumKey.Key4, 4}
        };

    private Dictionary<int, int> _intDict = new Dictionary<int, int>(){
    {0, 1}, {1, 2}, {2, 3}, {3, 4}
  };

    /// <summary>
    /// 計測を行う
    /// </summary>
    public void Measure()
    {
        int loopCount = 1000000;

        CalcTime.MeasureTime(EnumAction, loopCount, true);
        CalcTime.MeasureTime(IntAction, loopCount, true);
        CalcTime.MeasureTime(EnumToIntAction, loopCount, true);

    }

    //keyをenumにした場合の処理
    private void EnumAction()
    {
        int no = _enumDict[EnumKey.Key1];
        no = _enumDict[EnumKey.Key2];
        no = _enumDict[EnumKey.Key3];
        no = _enumDict[EnumKey.Key4];
    }

    //keyをintにした場合の処理
    private void IntAction()
    {
        int no = _intDict[0];
        no = _intDict[1];
        no = _intDict[2];
        no = _intDict[3];
    }

    //Dictのkeyはint、入力はenumをintにした場合の処理
    private void EnumToIntAction()
    {
        int no = _intDict[(int)EnumKey.Key1];
        no = _intDict[(int)EnumKey.Key2];
        no = _intDict[(int)EnumKey.Key3];
        no = _intDict[(int)EnumKey.Key4];
    }

}
