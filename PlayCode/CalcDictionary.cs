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
    private Dictionary<EnumKey, int> enumDict 
        = new Dictionary<EnumKey, int>() {
        {EnumKey.Key1, 1}, {EnumKey.Key2, 2}, {EnumKey.Key3, 3}, {EnumKey.Key4, 4}
        };

    private Dictionary<int, int> intDict
        = new Dictionary<int, int>(){ {0, 1}, {1, 2}, {2, 3}, {3, 4} };

    /// <summary>
    /// 計測を行う
    /// </summary>
    public void Measure()
    {
        int loopCount = 10;

        CalcTime.MeasureTime(EnumAction, loopCount, true);
        CalcTime.MeasureTime(IntAction, loopCount, true);
        CalcTime.MeasureTime(EnumToIntAction, loopCount, true);
    }

    //keyをenumにした場合
    private void EnumAction()
    {
        int no = enumDict[EnumKey.Key1];
        no = enumDict[EnumKey.Key2];
        no = enumDict[EnumKey.Key3];
        no = enumDict[EnumKey.Key4];
    }

    //keyをintにした場合
    private void IntAction()
    {
        int no = intDict[0];
        no = intDict[1];
        no = intDict[2];
        no = intDict[3];
    }

    //Dictのkeyはint、入力はenumをintにした場合
    private void EnumToIntAction()
    {
        int no = intDict[(int)EnumKey.Key1];
        no = intDict[(int)EnumKey.Key2];
        no = intDict[(int)EnumKey.Key3];
        no = intDict[(int)EnumKey.Key4];
    }
}
