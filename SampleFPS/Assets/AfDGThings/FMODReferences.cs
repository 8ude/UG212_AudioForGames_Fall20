using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Audio", fileName = "FMODReferences")]
public class FMODReferences : ScriptableObject
{
	[FMODUnity.EventRef]
	public string StartGame = "event:/UISounds/StartGame";

	[FMODUnity.EventRef]
	public string LowHealth = "event:/UISounds/LowHealth";

	[FMODUnity.EventRef]
	public string SelectOption = "event:/UISounds/SelectOption";

	[FMODUnity.EventRef]
	public string WinGame = "event:/UISounds/WinGame";

    [FMODUnity.EventRef]
    public string WinGameScreen = "event:/UISounds/WinGameScreen";

    [FMODUnity.EventRef]
	public string LoseGameScreen = "event:/UISounds/LoseGameScreen";

	[FMODUnity.EventRef]
	public string MainMenu = "event:/Ambience/MainMenu";

	[FMODUnity.EventRef]
	public string LavaAmbience = "event:/Ambience/LavaAmbience";

	[FMODUnity.EventRef]
	public string BuildingAmbience = "event:/Ambience/BuildingAmbience";

	[FMODUnity.EventRef]
	public string Footstep = "event:/PlayerMovement/Footstep";

	[FMODUnity.EventRef]
	public string Jump = "event:/PlayerMovement/Jump";

	[FMODUnity.EventRef]
	public string Land = "event:/PlayerMovement/Land";

	[FMODUnity.EventRef]
	public string FallDamage = "event:/PlayerMovement/FallDamage";

	[FMODUnity.EventRef]
	public string UseJetpack = "event:/PlayerMovement/UseJetpack";

	[FMODUnity.EventRef]
	public string ShootPistol = "event:/PlayerCombat/ShootPistol";

	[FMODUnity.EventRef]
	public string ReloadPistol = "event:/PlayerCombat/ReloadPistol";

	[FMODUnity.EventRef]
	public string ShootLauncher = "event:/PlayerCombat/ShootLauncher";

	[FMODUnity.EventRef]
	public string LauncherImpact = "event:/PlayerCombat/LauncherImpact";

	[FMODUnity.EventRef]
	public string ReloadLauncher = "event:/PlayerCombat/ReloadLauncher";

	[FMODUnity.EventRef]
	public string PlayerTakeDamage = "event:/PlayerCombat/PlayerTakeDamage";

    [FMODUnity.EventRef]
    public string PlayerLose = "event:/PlayerCombat/PlayerTakeDamage";

    [FMODUnity.EventRef]
	public string PickupLauncher = "event:/PlayerPowerups/PickupLauncher";

	[FMODUnity.EventRef]
	public string PickupJetpack = "event:/PlayerPowerups/PickupJetpack";

	[FMODUnity.EventRef]
	public string PickupHealth = "event:/PlayerPowerups/PickupHealth";

	[FMODUnity.EventRef]
	public string HealthAmbient = "event:/PlayerPowerups/HealthAmbient";

	[FMODUnity.EventRef]
	public string PowerupAmbient = "event:/PlayerPowerups/PowerupAmbient";

	[FMODUnity.EventRef]
	public string EnemyAlert = "event:/EnemySFX/EnemyAlert";

    [FMODUnity.EventRef]
    public string EnemyMove = "event:/EnemySFX/EnemyMove";

    [FMODUnity.EventRef]
	public string DestroyEnemy = "event:/EnemySFX/DestroyEnemy";

	[FMODUnity.EventRef]
	public string RobotShot = "event:/EnemySFX/RobotShot";

	[FMODUnity.EventRef]
	public string BossShot = "event:/EnemySFX/BossShot";

	[FMODUnity.EventRef]
	public string EnemyTakeDamage = "event:/EnemySFX/EnemyTakeDamage";

}