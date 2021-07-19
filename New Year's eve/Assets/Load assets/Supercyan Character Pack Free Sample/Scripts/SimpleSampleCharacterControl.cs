using System.Collections.Generic;
using UnityEngine;

public class SimpleSampleCharacterControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.5f;

    [SerializeField] private Animator m_animator = null;
    [SerializeField] private Rigidbody m_rigidBody = null;

    private bool m_isGrounded = true;

    private void Awake()
    {
        if (!m_animator) { gameObject.GetComponent<Animator>(); }
        if (!m_rigidBody) { gameObject.GetComponent<Animator>(); }
    }

    private void FixedUpdate()
    {
        m_rigidBody.velocity = new Vector3(-1, 0, 0) * moveSpeed;
        m_animator.SetBool("Grounded", m_isGrounded);
        m_animator.SetFloat("MoveSpeed", moveSpeed);
    }
}
