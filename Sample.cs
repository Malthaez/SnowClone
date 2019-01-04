// Potential architecture for Mei's Snow Ball Offensive clone

class Position
{
    float x;
    float y;
    float z;
}

class Rotation
{
    float x;
    float y;
    float z;
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
    Ability _primaryAbility;
    Ability _secondaryAbility;
    Ability _ultimateAbility;
    Weapon _weapon;
}

class Player
{
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

    void StartTimer();
}

class Game
{
    Player[] _players;
    Team[] _teams;
    Timer _timer;

    void Main();

    Team CreateTeam(Player[] players);
}