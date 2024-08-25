---
title: "Unity 講習会 2024 発展編"
date: "2024-08-28"
author: "sugawa197203"
---

* [環境構築編](https://tuatmcc.com/blog/UnityLec2024Step0/)
* [入門編](https://tuatmcc.com/blog/UnityLec2024Step1/)
* [応用編](https://tuatmcc.com/blog/UnityLec2024Step2/)
* 発展編 ← 今ここ

# 1. はじめに

* この記事は Unity 講習会 2024 発展編の資料です
* Unity Hub と Unity 2022.3.38f1 をインストール済み(※ 2022.3.38f1 はあくまで例)
* 任意の IDE がある(Visual studio, Rider など)
* Unity ちょっと触ったことがある人

## 1.1. 題材

Unityちゃんアドベンチャーゲーム

## 1.2. 学ぶこと

* Decal
* Zenject
* UniTask, R3
* DoTween

# 2. Unity ちゃんにアニメーションを追加する

ここでは Unity ちゃんにジャンプのアニメーションを追加します。

## 2.1. ジャンプアニメーションの追加

/Assets/UnityChan/Animations/ の中にある `UnityChanAnimatorController` に /Assets/UnityChan の中にある `JUMP00B` をドラッグアンドドロップしてください。**`JUMP00` ではなく、`JUMP00B` です！**

![alt text](./img/2.addjump.webp)

次に、 `+` を押してパラメーターに `Jump` を追加してください。種類は `Trigger` です。

![alt text](./img/2.addparm.webp)

続いて、ジャンプのアニメーションステートに `Move` と `Idle` から遷移する矢印を追加してください。

![alt text](./img/2.addtrans.webp)

# MCC Unity講習会

* [環境構築編](https://tuatmcc.com/blog/UnityLec2024Step0/)
* [入門編](https://tuatmcc.com/blog/UnityLec2024Step1/)
* [応用編](https://tuatmcc.com/blog/UnityLec2024Step2/)
* 発展編 ← 今ここ
