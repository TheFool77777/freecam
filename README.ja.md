# freecam

> gogh でカメラを自由に動かそう。
> 部屋の境界制限を広げて、ソロルームでもマルチルームでも自由に視点を動かせます。

[![Latest Release](https://img.shields.io/github/v/release/TheFool77777/freecam?display_name=tag&style=flat-square)](https://github.com/TheFool77777/freecam/releases/latest)
[![Downloads](https://img.shields.io/github/downloads/TheFool77777/freecam/total?style=flat-square)](https://github.com/TheFool77777/freecam/releases)
[![License](https://img.shields.io/badge/license-MIT-6f42c1?style=flat-square)](LICENSE)

**[ZIPをダウンロード](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)　·　[すべてのリリースを見る](https://github.com/TheFool77777/freecam/releases/latest)**

[繁體中文](README.md) · [简体中文](README.zh-CN.md) · [English](README.en.md) · [日本語](README.ja.md)

## これは何？

freecam は **gogh: Focus with Your Avatar** 用のフリーカメラ mod です。

部屋の境界ボックスを拡張することで、ソロルーム・マルチルームのどちらでも本来の範囲を超えて自由に視点を動かせるようになります。

MelonLoader をインストールし、`freecam.dll` を `Mods` に入れてゲームを起動するだけで使えます。

## インストール方法

### Step 1：MelonLoader をインストール

1. [MelonLoader 公式インストーラーのダウンロードページ](https://github.com/LavaGang/MelonLoader.Installer/releases)を開きます。
2. インストーラーをダウンロードして起動します。
3. gogh の `gogh.exe` を選択します。
4. デフォルト設定のまま **Install** をクリックします。

### Step 2：ゲームを一度起動

Steam から gogh を起動し、ゲームのメイン画面が表示されたら終了します。

これで `Mods` フォルダーが自動的に作成されます。

### Step 3：DLL を入れる

1. [freecam Releases](https://github.com/TheFool77777/freecam/releases/latest) から `freecam.zip` をダウンロードします。
2. ZIP を解凍します。
3. 中にある `freecam.dll` を gogh の `Mods` フォルダーに入れます。
4. もう一度ゲームを起動すれば完了です。

ゲームフォルダーは Steam から開けます：

**ライブラリ → gogh を右クリック → 管理 → ローカルファイルを閲覧**

ファイルの場所は次のようになります：

```text
gogh フォルダー\Mods\freecam.dll
```

## ダウンロード

- [最新 ZIP をダウンロード](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)
- [DLL をダウンロード](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.dll)
- [MelonLoader インストーラー](https://github.com/LavaGang/MelonLoader.Installer/releases)

## 動作確認

ゲームを起動してルームに入り、約 2 秒待つと本来の範囲を超えてカメラを自由に動かせるようになります。

`MelonLoader\Logs` を開き、次の行を検索しても確認できます：

```text
WholeRoomBoundingBox modified successfully!
```

## よくある質問

### Mods フォルダーが見つかりません

MelonLoader を入れた状態でゲームを一度起動し、メイン画面まで進んで終了してください。自動的に作成されます。

### インストールしたのに動きません

次の場所に DLL があるか確認してください：

```text
Mods\freecam.dll
```

確認後、ゲームをもう一度起動してください。

### ルームに入った直後は効いていないようです

ルーム読み込みから約 2 秒後に自動適用され、失敗した場合も 2 秒後に自動で再試行します。

## アンインストール

ゲームを終了して、次のファイルを削除してください：

```text
Mods\freecam.dll
```

## 作者

**thefool**

## ライセンス

[MIT License](LICENSE)
