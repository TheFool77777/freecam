# freecam

> 让 gogh 的镜头移动自由到底。
> 不再被原本的房间边界卡住，单人房与多人房都能自由拉远与移动视角。

[![Latest Release](https://img.shields.io/github/v/release/TheFool77777/freecam?display_name=tag&style=flat-square)](https://github.com/TheFool77777/freecam/releases/latest)
[![Downloads](https://img.shields.io/github/downloads/TheFool77777/freecam/total?style=flat-square)](https://github.com/TheFool77777/freecam/releases)
[![License](https://img.shields.io/badge/license-MIT-6f42c1?style=flat-square)](LICENSE)

**[立即下载 ZIP](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)　·　[查看完整下载页](https://github.com/TheFool77777/freecam/releases/latest)**

[繁體中文](README.md) · [简体中文](README.zh-CN.md) · [English](README.en.md) · [日本語](README.ja.md)

## 这是什么？

freecam 是一个让 **gogh: Focus with Your Avatar** 可以自由移动视角的小模组。

通过扩大房间的视角边界范围，让镜头能突破原本的活动限制，适用于单人房间与多人房间。

安装很简单：装好 MelonLoader，把 `freecam.dll` 放进 `Mods`，然后启动游戏。

## 安装方法

### 第 1 步：安装 MelonLoader

1. 打开 [MelonLoader Installer 官方下载页](https://github.com/LavaGang/MelonLoader.Installer/releases)。
2. 下载并打开安装器。
3. 在安装器中选择 gogh 的 `gogh.exe`。
4. 保持默认设置，直接点击 **Install**。

### 第 2 步：启动一次游戏

从 Steam 启动 gogh，看到游戏主画面后关闭游戏。

这一步会自动建立 `Mods` 文件夹。

### 第 3 步：放入 DLL

1. 到 [freecam Releases](https://github.com/TheFool77777/freecam/releases/latest) 下载 `freecam.zip`。
2. 解压 ZIP。
3. 把里面的 `freecam.dll` 放进 gogh 文件夹的 `Mods`。
4. 再次启动游戏，完成。

游戏文件夹可以从 Steam 找到：

**库 → 右键 gogh → 管理 → 浏览本地文件**

放好后，文件位置是：

```text
gogh 文件夹\Mods\freecam.dll
```

## 下载

- [下载最新 ZIP](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)
- [下载 DLL](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.dll)
- [MelonLoader Installer 官方下载](https://github.com/LavaGang/MelonLoader.Installer/releases)

## 确认成功

启动游戏并进入房间，等待约 2 秒后即可突破原本的镜头范围自由移动视角。

也可以在 `MelonLoader\Logs` 中搜索：

```text
WholeRoomBoundingBox modified successfully!
```

## 常见问题

### 找不到 Mods 文件夹

先用 MelonLoader 启动一次游戏，看到主画面后关闭，`Mods` 就会出现。

### 安装后没有效果

确认 `freecam.dll` 放在：

```text
Mods\freecam.dll
```

然后重新启动游戏。

### 刚进房间时好像还没生效

模组会在进入房间场景约 2 秒后自动生效，如果第一次未成功也会在 2 秒后自动重试。

## 卸载

关闭游戏，删除这个文件即可：

```text
Mods\freecam.dll
```

## 作者

**Yakou**

## 许可证

[MIT License](LICENSE)
