<div align="right">
  <details>
    <summary >🌐 其他语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

经典 2048 游戏的增强版，现已加入更多有趣功能！这是我业余时间做的一个小项目——希望它能为你带来快乐！

## 🎯 游戏简介

2048 是一款简单却令人上瘾的数字合并游戏。在 4x4 的方格中，向上、下、左、右滑动来合并相同数字的方块。目标？达到 2048（不过你可以继续挑战更高分数）！

**玩法说明：**
- 使用方向键或 WASD 键移动方块。
- 当两个具有相同数字的方块碰撞时，它们会合并为一个方块。
- 每次移动后，一个新的2或4会随机出现在空位置。
- 当没有更多可移动步数时，游戏结束。

## ✨ 特殊功能

### 1. 撤销功能
- 走错一步？别担心！
- 只需点击“撤销”按钮即可回到上一步。
- 你可以无限次撤销，一直回到游戏开始。
- 再也不用担心手滑毁了你的游戏！

### 2. 神秘作弊模式
- 输入神奇序列：←←→→ →→←←（左、左、右、右、右、右、左、左）
- 所有方块都会神奇地变成128！
- 这是一个彩蛋，仅供娱乐。
- 专业提示：作弊很有趣，但不要过度哦！😉

## 🎯 演示

🎯 : [点击这里试玩](http://34.150.49.127:5000/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 项目结构
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**文件说明：**
- `2048.py`：使用 Flask 编写的后端服务器，处理游戏逻辑和 API 请求。
- `script.js`：前端游戏逻辑，包括移动、动画和特殊功能。
- `styles.css`：游戏样式，确保界面美观且响应式。
- `index.html`：整合所有内容的主页面。

## 🚀 快速开始

**方法一：下载发行版**
1. 下载最新的发行版。
2. 确保已安装 Python 3.x。
3. 安装依赖项：`pip install flask`
4. 运行：`python 2048.py`
5. 打开浏览器并访问：[http://localhost:9969](http://localhost:9969)

**方法二：从 GitHub 克隆**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 自定义

想要打造属于自己的版本？可以调整 `styles.css` 来获得新外观，或者深入 `script.js` 更改游戏玩法。所有代码均有详细注释，便于轻松修改！

## 📝 许可协议

GPL-2.0 许可证

## 🤝 贡献

仍在持续更新！欢迎提出 Issue 和 Pull Request——让我们一起让这款游戏变得更棒！


## 🙏 致谢

感谢以下赞助商对本项目的支持：
- [None](https://#/) 提供服务器
- [Serv00](https://www.serv00.com/) 提供服务器

---
_最后更新：2025年8月_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---