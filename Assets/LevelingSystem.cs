using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem : MonoBehaviour
{
    //Primary Experience Functions
    public int level;
    public float experience;
    private float experienceRequired;
   
    //Stat Functions
    public float hp = 100; //Stats will scale up with the level
    public int damage = 10;
    public int armour = 0;
    public int speed = 300;
                     
    //Base stats at the start of the game
    void Start()
    {
        level = 1;
        hp = 100;
        experience = 0;
        experienceRequired = 100;
    }
   
    void Update()
    {
        Exp();
        //Enemy Kill choices
        if (Input.GetKeyDown("f")) //Press F to kill a Minion
        {
            experience += 20;
            print("You killed a Minion");
        }

        if (Input.GetKeyDown("g")) //Press g to kill a Mage
        {
            experience += 50;
            print("You killed a Mage");
        }

        if (Input.GetKeyDown("h")) //Press h to kill a Warlock
        {
            experience += 100;
            print("You killed a Warlock");
        }
    }

    void LevelUp()
    {
        level += 1; //Level Increases by 1 each time the LevelUp Script is used
        experience = 0;

        switch (level) // Each time your expeience is equal to the Case value's experienceRequired then you level up and gain stat increases
        {
            case 2:
                hp = 150;
                damage = 15;
                armour = 10;
                speed = 320;
                experienceRequired = 100;
                print("You are now Level 2!");
                break;

            case 3:
                hp = 200;
                damage = 20;
                armour = 20;
                speed = 340;
                experienceRequired = 200;
                print("You are now Level 3!");
                break;

            case 4:
                hp = 250;
                damage = 25;
                armour = 30;
                speed = 360;
                experienceRequired = 300;
                print("You are now Level 4!");
                break;

            case 5: //Mystery box opening gives a random ammount extra for your stats, I wanted it to pick a random stat however I dont know how to make a list yet.
                hp = 300;
                damage = 30;
                armour = 40 + Random.Range(1, 20); //Does a Random increase to armour stat anywhere from 0-20
                speed = 380;
                experienceRequired = 400;
                print("You are now Level 5!");
                print("You opened a Mystery Box and gained some bonus armour!");
                break;

            case 6:
                hp = 350;
                damage = 35;
                armour = 50;
                speed = 400;
                experienceRequired = 500;
                print("You are now Level 6!");
                break;

            case 7:
                hp = 400;
                damage = 40;
                armour = 60;
                speed = 420;
                experienceRequired = 600;
                print("You are now Level 7!");
                break;

            case 8:
                hp = 450;
                damage = 45;
                armour = 70;
                speed = 440;
                experienceRequired = 700;
                print("You are now Level 8!");
                break;

            case 9:
                hp = 500;
                damage = 50;
                armour = 80;
                speed = 460;
                experienceRequired = 800;
                print("You are now Level 9!");
                break;

            case 10:
                hp = 550;
                damage = 55;
                armour = 90;
                speed = 480;
                experienceRequired = 900;
                print("You are now Level 10!");
                break;
        }
           
    }

    void Exp()
    {
        if (experience >= experienceRequired)
            LevelUp();
        //If experience equals the required amount then activate the Level Up script
    }
}
