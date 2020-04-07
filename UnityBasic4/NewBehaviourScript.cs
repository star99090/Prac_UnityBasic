﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int level = 5;
    int health = 30;
    int mana = 15;
    float strength = 15.5f;
    int exp = 1500;
    string title = "전설의";
    string playerName = "나검사";
    bool isFullLevel = false;

    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.변수

        /*
         * Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);
        */

        //2.그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        //3.연산자

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);

        /*
        Debug.Log("용사의 이름은?");
        Debug.Log(title+" "+playerName);
        */
        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level > 10;

        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";

        //4.키워드
        //int float string bool new List

        //5.조건문
        if(condition == "나쁨")
        {
            //Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            //Debug.Log("플레이어의 상태가 좋습니다.");
        }

        if(isBadCondition&&items[0] =="생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
        }
        else if(isBadCondition && items[0]=="마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
        }

        string monsterAlarm;
        switch(monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                //Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                //Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                //Debug.Log("대형 몬스터가 출현!");
                break;
            default:
                //Debug.Log("??? 몬스터가 출현!");
                break;
        }

        //6. 반복문
        while (health > 0)
        {
            health--;

            if (health == 10)
                break;
        }

        for (int count = 0; count < 10; count++)
                health++;
        
        foreach (string monster in monsters)
        {
                //Debug.Log("이 지역에 있는 몬스터 : " + monster);
            }

        //7.함수(메소드)
        Heal();

        for(int i=0; i<monsters.Length; i++)
        {
           // Debug.Log("용사는" + monsters[i] + "에게 " +
           //     Battle(monsterLevel[i]));
        }

        //8.클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.move());
    }

    void Heal()
    {
        health += 10;
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

        return result;
    }
}
