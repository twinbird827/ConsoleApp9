using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    /*
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
        入力が 1〜9 以外の文字を含んでいる
        入力が不足していて、ゲームの勝敗が決まらない
     */
    class Program
    {
        static string[] Wins => new[]
        {
            "123", "456", "789", "147", "258", "369", "159", "357"
        };

        static void Main(string[] args)
        {
            Test("79538246");
            Test("35497162193");
            Test("61978543");
            Test("254961323121");
            Test("6134278187");
            Test("4319581");
            Test("9625663381");
            Test("7975662");
            Test("2368799597");
            Test("18652368566");
            Test("965715");
            Test("38745796");
            Test("371929");
            Test("758698769");
            Test("42683953");
            Test("618843927");
            Test("36535224");
            Test("882973");
            Test("653675681");
            Test("9729934662");
            Test("972651483927");
            Test("5439126787");
            Test("142583697");
            Test("42198637563");
            Test("657391482");
            Console.ReadLine();
        }

        static void Test(string target)
        {
            Console.WriteLine($"{target.PadRight(2 * 5 + 5)}:{Judge(target)}");
        }

        static string Judge(string s)
        {
            for (int i = 1; i < s.Length && i < 9; i++)
            {
                // 先手/後手の判定用
                var first = i % 2;
                // index位置までの手→後手なら1手目を除外→1つ飛ばしで取得することで打った手を取得
                var target = s.Take(i + 1).Skip(first).Where((tmp, index) => index % 2 == 0);
                // 結果表示用
                var me = first == 0 ? "o" : "x";
                var yu = first == 0 ? "x" : "o";

                if (s.Take(i).Any(c => c == s[i]))
                    // これまで打った手と同じ位置に打ったら反則負け
                    return $"Foul : {yu} won.";
                else if (Wins.Any(win => win.All(w => target.Contains(w))))
                    // 勝ち手順のうちいずれかを打ったら勝ち
                    return $"{me} won.";
            }
            // 対象文字全て走査するか、9手分走査したら引き分け
            return "Draw game.";
        }
    }
}
