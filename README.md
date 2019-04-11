ConsoleApp9
====

## Overview

tick-tack-toe http://nabetani.sakura.ne.jp/hena/1/

## Description

三目並べ( tick-tack-toe )の手を入力とし、勝敗を出力する。

先攻がo、後攻がx
すでに打ってある場所に打った場合、反則負け
x が反則をした場合、「Foul : o won.」と出力
縦横斜めのいずれかで一列揃ったら、揃えた方の勝ち
x が揃えた場合、「x won.」と出力
9マス埋まっても揃わなかったら引き分け
「Draw game.」と出力
勝敗が決した後の手は無視する
入力文字列は、先攻から順に打った位置を示す。盤上の位置と数の対応は下表を参照。
入力文字列が「91593」の場合、「oが9の位置、xが1の位置、oが5の位置、xが9の位置→xの反則負け(最後の3は無視)」となる。
以下の様なケースは考慮しなくてよい
入力が 1～9 以外の文字を含んでいる
入力が不足していて、ゲームの勝敗が決まらない

## Requirement

.NET Framework 4.5.2

## Licence

[MIT](https://github.com/twinbird827/ConsoleApp9/blob/master/LICENSE)

## Author

[twinbird827](https://github.com/twinbird827)