# freecam

> 讓 gogh 的鏡頭移動自由到底。
> 不再被原本的房間邊界卡住，單人房與多人房都能自由拉遠與移動視角。

[![Latest Release](https://img.shields.io/github/v/release/TheFool77777/freecam?display_name=tag&style=flat-square)](https://github.com/TheFool77777/freecam/releases/latest)
[![Downloads](https://img.shields.io/github/downloads/TheFool77777/freecam/total?style=flat-square)](https://github.com/TheFool77777/freecam/releases)
[![License](https://img.shields.io/badge/license-MIT-6f42c1?style=flat-square)](LICENSE)

**[立即下載 ZIP](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)　·　[查看完整下載頁](https://github.com/TheFool77777/freecam/releases/latest)**

[繁體中文](README.md) · [简体中文](README.zh-CN.md) · [English](README.en.md) · [日本語](README.ja.md)

## 這是什麼？

freecam 是一個讓 **gogh: Focus with Your Avatar** 可以自由移動視角的小模組。

透過擴大房間的視角邊界範圍，讓鏡頭能突破原本的活動限制，適用於單人房間與多人房間。

安裝很簡單：裝好 MelonLoader，把 `freecam.dll` 丟進 `Mods`，再開啟遊戲。

## 安裝方式

### 第 1 步：安裝 MelonLoader

1. 開啟 [MelonLoader Installer 官方下載頁](https://github.com/LavaGang/MelonLoader.Installer/releases)。
2. 下載安裝器並開啟。
3. 在安裝器裡選擇 gogh 的 `gogh.exe`。
4. 維持預設設定，直接按下 **Install**。

### 第 2 步：啟動一次遊戲

從 Steam 開啟 gogh，看到遊戲主畫面後關閉遊戲。

這一步會自動建立 `Mods` 資料夾。

### 第 3 步：放入 DLL

1. 到 [freecam Releases](https://github.com/TheFool77777/freecam/releases/latest) 下載 `freecam.zip`。
2. 解壓縮 ZIP。
3. 把裡面的 `freecam.dll` 放進 gogh 資料夾的 `Mods`。
4. 再次開啟遊戲，完成。

遊戲資料夾通常可以從 Steam 找到：

**收藏庫 → 右鍵 gogh → 管理 → 瀏覽本機檔案**

放好之後，檔案位置會是：

```text
gogh 資料夾\Mods\freecam.dll
```

## 下載

- [下載最新 ZIP](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)
- [下載 DLL](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.dll)
- [MelonLoader Installer 官方下載](https://github.com/LavaGang/MelonLoader.Installer/releases)

## 確認成功

開啟遊戲並進入房間，等待約 2 秒後即可突破原本的鏡頭範圍自由移動視角。

也可以在 `MelonLoader\Logs` 裡搜尋：

```text
WholeRoomBoundingBox modified successfully!
```

## 常見問題

### 找不到 Mods 資料夾

先用 MelonLoader 開啟一次遊戲，看到主畫面後關閉，`Mods` 就會出現。

### 安裝後沒有作用

確認 `freecam.dll` 放在：

```text
Mods\freecam.dll
```

然後重新開啟遊戲。

### 剛進房間時好像還沒生效

模組會在進入房間場景約 2 秒後自動套用，若第一次未套用也會在 2 秒後自動重試。

## 移除

關閉遊戲，刪除這個檔案即可：

```text
Mods\freecam.dll
```

## 作者

**Yakou**

## 授權

[MIT License](LICENSE)
