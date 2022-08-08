
# MouseClicker

ホットキーを押下すると、指定された座標でマウスクリックを実行するアプリです。
お勉強用に作成し始めたものの必要なくなってしまったため、最小限の機能を実装したところで公開して、これ以上の作業を保留としたものです。

## 機能

- あらかじめの設定に従い、ホットキーを押下すると指定された座標にマウスカーソルが移動してクリック動作を実行します。
- 設定できる項目は下記の通りです。
  - ホットキー
    - Controlキー修飾の有無
    - Shiftキー修飾の有無
    - Altキー修飾の有無
    - キー名称
  - マウスカーソルX座標
  - マウスカーソルY座標
  - クリックボタン種類(Left/Middle/Right)
  - クリック回数
  - クリック間隔(ミリ秒)
- 設定は、exeファイルと同じフォルダ上にJSON形式で保存されます。
- アイコンは、タスクバーの通知領域に配置されます。

## 開発環境

- Windows 10 Home 64bit
- Microsoft Visual Studio Comunity 2022
- .NET Framework 4.7.2

## 開発言語

- C#

## 使用ライブラリ

- [Json.NET - Newtonsoft](https://www.newtonsoft.com/json) 13.0.1を使用しています。

## 使用方法

設定ファイルがない状態でアプリを起動すると、下記のデフォルトの設定で動作を開始します。

- F1キー押下により、座標(0,0)にマウスカーソルが移動してシングルクリック発生(画面左上)
- F2キー押下により、座標(990,540)にマウスカーソルが移動してダブルクリック発生(WUXGA画面中央)

設定の変更により設定ファイルが作成されると、その設定に従って動作するようになります。

## リンク

- [おーとくりっか～｜ぴっぴproject](https://pippi-pro.com/autoclicker)
- [マウスポインタの位置を取得、変更（移動）する - .NET Tips (VB.NET,C#...)](https://dobon.net/vb/dotnet/system/cursorposition.html)
- [C#でマウスのクリック・右クリック・中央ボタンのクリックをする方法 – // もちぶろ](https://slash-mochi.net/blog/2020/04/09/post-3354/)
- [C#でグローバルホットキーを登録する - Qiita](https://qiita.com/r_nabu/items/316d63053bdd140016eb)
- [C# タスクトレイ常駐型アプリケーションの作成 – Picosy](https://picosy.jp/wp/c-sharp-make-tasktray-app/)
- [「【C#】タスクトレイ表示によるFormの表示切替制御」（1） Insider.NET － ＠IT](https://atmarkit.itmedia.co.jp/bbs/phpBB/viewtopic.php?topic=21135&forum=7)
