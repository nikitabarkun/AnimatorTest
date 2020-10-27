using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private readonly int SCALE = Animator.StringToHash("Scale");
    private readonly int LEFT_ROTATION = Animator.StringToHash("LeftRotation");
    private readonly int RIGHT_ROTATION = Animator.StringToHash("RightRotation");
    private readonly int COLOR_R = Animator.StringToHash("ColorR");
    private readonly int COLOR_G = Animator.StringToHash("ColorG");
    private readonly int COLOR_B = Animator.StringToHash("ColorB");

    private const float ZERO = 0f;
    private const float ONE = 1f;
    
    [SerializeField] private Animator animator;
    
    private Color _colorR = Color.white;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnClick()
    {
        SetAnimatorFloat(SCALE);
        
        SetAnimatorFloat(LEFT_ROTATION);
        SetAnimatorFloat(RIGHT_ROTATION);
        
        SetAnimatorFloat(COLOR_R);
        SetAnimatorFloat(COLOR_G);
        SetAnimatorFloat(COLOR_B);
    }

    private void SetAnimatorFloat(int parameter)
    {
        animator.SetFloat(parameter, Random.Range(ZERO, ONE));
    }
}
