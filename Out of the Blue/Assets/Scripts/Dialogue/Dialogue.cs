using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dialogue : MonoBehaviour {
    #region Lists
    [SerializeField] private List<string> m_Hints = new List<string>();
    [SerializeField] private List<string> m_Warnings = new List<string>();
    [SerializeField] private List<string> m_Generic = new List<string>();
    #endregion
    #region Randoms
    public string GetRandomHint()
    {
        return m_Hints[Random.Range(0, m_Hints.Count)];
    }
    public string GetRandomWarning()
    {
        return m_Warnings[Random.Range(0, m_Warnings.Count)];
    }
    public string GetRandomGeneric()
    {
        return m_Generic[Random.Range(0, m_Generic.Count)];
    }
    #endregion
    #region Specific
    public string GetHint(int index)
    {
        if (index >= m_Hints.Count)
        {
            Debug.LogError("Failed to get Hint, Index is out of range");
            return "";
        }
        return m_Hints[index];
    }
    public string GetWarning(int index)
    {
        if (index >= m_Warnings.Count)
        {
            Debug.LogError("Failed to get Warning, Index is out of range");
            return "";
        }
        return m_Warnings[index];
    }
    public string GetGeneric(int index)
    {
        if (index >= m_Generic.Count)
        {
            Debug.LogError("Failed to get Generic, Index is out of range");
            return "";
        }
        return m_Generic[index];
    }
    #endregion
}
