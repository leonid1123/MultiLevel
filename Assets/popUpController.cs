using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpController : MonoBehaviour
{
    MeshRenderer m_MeshRenderer;
    public SpriteRenderer m_SpriteRenderer;
    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();
        m_MeshRenderer.enabled = false;
        m_SpriteRenderer.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Player"))
        {
            m_MeshRenderer.enabled = true;
            m_SpriteRenderer.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals("Player"))
        {
            m_MeshRenderer.enabled = false;
            m_SpriteRenderer.enabled = false;
        }
    }
}
