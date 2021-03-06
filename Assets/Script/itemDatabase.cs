﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아이템 데이터베이스. 여기에 필요한 아이템들을 작성하여 적용한다.
public class itemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Start() {
        // 스테이지 1
        items.Add(new Item("짧은 나무 막대", "나무막대기", 1001, "나무막대기"));
        items.Add(new Item("갈고리", "갈고리", 1002, "갈고리"));
        items.Add(new Item("Key2", "긴 막대기", 2003, "무언가를 헤집을 수 있을 것 같다."));
        items.Add(new Item("망치", "망치", 2007, "창문을 깰 수 있을것 같다."));
        items.Add(new Item("Stage2Key", "열쇠", 2009, "빨리 탈출해야겟다."));

        // 스테이지 2
        // 요리재료 2개 독국뮬 요리 이상한 요리 키
        items.Add(new Item("Material1", "고기", 3001, "신선한 고기다."));
        items.Add(new Item("Material2", "버섯", 3002, "식용 버섯이다."));
        items.Add(new Item("Material3", "파프리카", 3003, "신선하다."));
        items.Add(new Item("Poison", "??", 3004, "수상한 액체"));
        items.Add(new Item("Food1", "완성된 요리", 3005, "맛있어 보이는 요리"));
        items.Add(new Item("Food2", "??? 요리", 6009, "수상한 요리"));
        items.Add(new Item("Stage2Key", "열쇠", 3007, "출구 열쇠"));

        // 스테이지 3
        // USB, 약, 키
        items.Add(new Item("수상한약", "수상한 약", 4001, "정체를 알 수 없는 약이다."));
        items.Add(new Item("USB", "USB", 4003, "USB이다. 확인을 해봐야 될 것 같다."));
        items.Add(new Item("망치", "망치", 4013, "단단한 망치이다."));
        items.Add(new Item("Stage2Key", "열쇠", 5007, "빨리 탈출하자...."));
    }
}
