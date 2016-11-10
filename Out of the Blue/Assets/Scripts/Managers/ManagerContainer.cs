using UnityEngine;
using System.Collections;

public class ManagerContainer : MonoBehaviour {

    #region Singleton
    private static ManagerContainer m_instance;
    public static ManagerContainer Instance { get { return m_instance; }}

    void Awake()
    {
        m_instance = null;
        m_instance = FindObjectOfType<ManagerContainer>();
        if(m_instance == null)
        {
            Debug.LogError("Failed to find ManagerContainer... Why? Just fucking why?");
        }
    }
    #endregion

    [SerializeField] private Dialogue m_Dialogue;
    public Dialogue Dialogue { get { return m_Dialogue; } }

}
