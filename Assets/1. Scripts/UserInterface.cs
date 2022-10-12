using UnityEngine;
using TMPro;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private TMP_InputField[] _setPanels;

    public void OnUpdateSpeedMove(string valueSpeed)
    {
        if (valueSpeed.Length == 0) return;
        _setPanels[0].text = $"�������� ������������ = {valueSpeed}";
        EventManager.OnUpdateSpeedMove(valueSpeed);
    }

    public void OnUpdateLifeDistanse(string valueDistanse)
    {
        if (valueDistanse.Length == 0) return;
        _setPanels[1].text = $"��������� �� ����������� = {valueDistanse}";
        EventManager.OnUpdateDistanseLife(valueDistanse);
    }

    public void OnUpdateSpeedRespawn(string valueTime)
    {
        if (valueTime.Length == 0) return;
        _setPanels[2].text = $"�������� ����������� = {valueTime}";
        EventManager.OnUpdateSpeedRespawn(valueTime);
    }
}
