using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{

  // Use this for initialization
  public static int hp;
  public static int def;
  public static int atk;
  public static int lvl;
  public static int room;

  public static int playerCardIDs;
  public static List<CardData> listOfCards;

  public static int opponentHP;
  public static int opponentDEF;
  public static int opponentATK;

  public static int []opponentCardIDs;

  public static void setState()
  {
    hp = 6;
    def = 1;
    atk = 2;
    lvl = 1;
    room = 1;
    opponentATK = 1;
    opponentDEF = 2;
    opponentHP = 1;
  }
  
  public static void ADD_ONE_LEVEL() {
    lvl = lvl + 1;
  }
  
  public static void ADD_ONE_ROOM() {
    room = room + 1;
  }
  
  public static void RESET_ROOM() {
    room = 0;
  }
  
  public static void RESET_LEVEL() {
    lvl = 0;
  }
  private void Awake()
  {
    if(lvl==0)
    setState();
  }

  // Update is called once per frame
  void Update()
  {

  }
}
