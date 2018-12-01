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
  public static List<CardData> listOfCards;

  public static void setState()
  {
    hp = 5;
    def = 1;
    atk = 2;
    lvl = 1;
    room = 1;

  }
  private void Awake()
  {
    setState();
  }

  // Update is called once per frame
  void Update()
  {

  }
}
