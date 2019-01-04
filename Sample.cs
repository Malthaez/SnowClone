// Potential architecture for Mei's Snow Ball Offensive clone

class Position
{
    float _x;
    float _y;
    float _z;
}

class Rotation
{
    float _x;
    float _y;
    float _z;
}

class Transform
{
    Position _position;
    Rotation _rotation;
}

abstract class Ability
{
    bool _isOnCooldown;
    float _cooldown;
}

class Projectile
{
    Transform _transform;

    void OnCollision();
}

class Weapon
{
    Transform _muzzle;
    float _muzzleVelocity;
    bool _isLoaded;

    void Fire();
    void Reload();
}

class HeroModel
{
    float _moveSpeed;
    Ability _primaryAbility;
    Ability _secondaryAbility;
    Ability _ultimateAbility;
    Weapon _weapon;
}

class GamePad
{
    float[] _axisInputs;
    bool[] _buttonInputs;
}

class Player
{
    GamePad _gamePad;
    Transform _transform;
    bool _isAlive;
    HeroModel _hero;

    void Move();
    void Jump();
    void FireWeapon();
    void ReloadWeapon();
}

class Team
{
    Player[] _players;
}

class Timer
{
    float _time;

    void Start();
}

class Game
{
    Player[] _players;
    Team[] _teams;
    Timer _timer;

    void Main();

    Team CreateTeam(Player[] players);
}

//Testing new commit rule.
//Testing