using Microsoft.Identity.Client;

class Client
{
    void Operation()
    {
        Character character = new Character();
        Character clone = character.Clone();
        character = new MainCharacter();
        clone = character.Clone();
    }
}

abstract class Character
{
   public int HP { get; set; }
   public int charisma { get; set; }
    public int intelligence { get; set; }
    public int strength { get; set; }
    public int agility { get; set; }
    public int luck { get; set; }

    public Weapon Weapon { get; set; }
    public Armor Armor { get; set; }
    public Skill Skill { get; set; }

    public Character(int HP, int charisma, int intelligence, int strength, int agility, int luck, Weapon weapon, Armor armor, Skill skill)
    {
      this.HP = HP;
      this.charisma = charisma;
      this.intelligence = intelligence;
      this.strength = strength;
      this.agility = agility;
      this.luck = luck;
      this.Weapon = weapon;
      this.Armor = armor;
      this.Skill = skill;
    }
    public abstract Character Clone();
}

class MainCharacter : Character
{
    public MainCharacter(int HP, int charisma, int intelligence, int strength, int agility, int luck, Weapon weapon, Armor armor, Skill skill) : base(HP, charisma, intelligence, strength, agility, luck, weapon, armor, skill)
    {
    }
    public override MainCharacter Clone()
    {
        return new MainCharacter(this.HP, this.charisma, this.intelligence, this.strength, this.agility, this.luck, this.Weapon, this.Armor, this.Skill);
    }
}

abstract class Weapon
{
    public int Damage { get; set; }
    public int Range { get; set; }

    public Weapon(int damage, int range)
    {
        this.Damage = damage;
        this.Range = range;
    }
    public abstract Weapon Clone();
}

class Sword : Weapon
{
    public Sword(int damage, int range) : base(damage, range)
    {
    }
    public override Sword Clone()
    {
        return new Sword(this.Damage, this.Range);
    }
}

abstract class Armor
{
    public int Resistance { get; set; }
    public Armor(int resistance)
    {
        this.Resistance = resistance;
    }
public abstract Armor Clone();
}

class Helmet : Armor
{
    public Helmet(int resistance) : base(resistance)
    {
    }
    public override Helmet Clone()
    {
        return new Helmet(this.Resistance);
    }
}

abstract class Skill
{
    public int Damage { get; set; }
    public int Range { get; set; }
    public string Type { get; set; }
    public Skill(int damage, int range, string type)
    {
        this.Damage = damage;
        this.Range = range;
        this.Type = type;
    }

public abstract Skill Clone();
}

class Fireball : Skill
{
    public Fireball(int damage, int range, string type) : base(damage, range, type)
    {
    }
    public override Fireball Clone()
    {
        return new Fireball(this.Damage, this.Range, this.Type);
    }
}