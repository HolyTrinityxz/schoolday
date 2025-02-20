using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _input;
    private bool _isMoving;
    private CharacterAnimations _animations;
    [SerializeField] private SpriteRenderer _characterSprite;
    private void Start()
    {
        _animations = GetComponentInChildren<CharacterAnimations>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _input = new Vector2(Input.GetAxis("Horizontal" ), 0);
        transform.position += _input * _speed * Time.deltaTime;
        _isMoving = _input.x != 0 ? true : false;

        if (_isMoving) 
        {
            _characterSprite.flipX = _input.x > 0 ? false : true;
        }

        _animations.IsMoving = _isMoving;


    }

}
