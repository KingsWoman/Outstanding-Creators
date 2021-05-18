using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using Scene = UnityEngine.SceneManagement.Scene;

public enum Theme
{
    None,
    Addition_subtraction,
    Multiplication_division,
    Fractions
}

public static class User
{
    public const double CriticalDamageChance = 0.05;
    public const double CriticalDamageCoefficient = 2;
    public const double DamageBlockCoefficient = 0.5;

    public static bool IsMusicOn = false;

    public static Stack<string> sceneHistory= new Stack<string>();

    public static Theme currentTheme = Theme.None;

    public static int _experience { get; set; }
    public static int _level => _experience / 50;
    public static int _unusedLevels = 0;

    public static uint _strength;
    public static uint _dexterity;
    public static uint _intelligence;

    public static int HealthPool() => 100 + (int)Math.Floor(_strength * 0.5);
    public static int Damage(int enemyHealth) => 5 + enemyHealth * (int)Math.Floor(_intelligence / 100.0);
    public static double DodgePercent() => Math.Round(Math.Exp(0.046 * _dexterity), 3);
    public static int DamageBlock() => (int)Math.Floor(DamageBlockCoefficient * _intelligence + _strength);
    public static int CriticalDamage(int enemyHealth) => (int)Math.Floor(CriticalDamageCoefficient * Damage(enemyHealth));

}
