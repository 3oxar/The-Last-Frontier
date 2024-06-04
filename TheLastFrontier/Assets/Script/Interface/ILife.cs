interface ILife 
{
    int HP { get; set; }
    bool IsAlive { get; set; }

    void Damage(int hpLost);
}
