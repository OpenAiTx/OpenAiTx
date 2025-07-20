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


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

经典2048游戏的增强版，现在拥有更多有趣功能！这是我业余时间完成的一个小项目——希望能给你带来一些快乐！

## 🎯 游戏简介

2048是一款简单却令人上瘾的数字合并游戏。在4x4的棋盘上，向上、下、左、右滑动，将相同数字的方块合并。目标？合成2048（当然，你也可以继续挑战更高分数）！

**玩法说明：**
- 使用方向键或WASD来移动方块。
- 当两个相同数字的方块碰撞时，它们会合并成一个。
- 每次移动后，会有一个新的2或4随机出现在空格上。
- 当没有可移动的方块时，游戏结束。

## ✨ 特别功能

### 1. 撤销功能
- 操作失误？别担心！
- 点击“撤销”按钮即可回退一步。
- 你可以无限次撤销，一直退回到游戏开始。
- 再也不用担心手滑毁掉一局好棋！

### 2. 神秘作弊模式
- 输入神秘指令：←←→→ →→←←（左、左、右、右、右、右、左、左）
- 所有方块都会神奇地变成128！
- 这是一个彩蛋，纯属娱乐。
- 小提示：偶尔作弊很有趣，但可不要玩过头哦！😉

## 🎯 演示

🎯 在线游玩：[2048.765431.xyz](https://2048.765431.xyz/)
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
- `index.html`：将所有内容整合在一起的主页。

## 🚀 快速开始

**方法一：下载发布版本**
1. 下载最新发布版本。
2. 确保已安装 Python 3.x。
3. 安装依赖：`pip install flask`
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

想让它变成你自己的风格吗？修改 `styles.css` 以获得新外观，或者深入 `script.js` 来更改游戏玩法。所有代码都有详细注释，便于你随意修改！

## 📝 许可证

GPL-2.0 许可证

## 🤝 贡献

仍在持续更新中！欢迎提出 Issue 和 Pull Request——让我们一起让这个游戏变得更棒！


## 🙏 鸣谢

感谢以下赞助商对本项目的支持：
- [IDC.REST](https://idc.rest/) 提供服务器
- [Serv00](https://www.serv00.com/) 提供服务器

---
_最后更新：2025年6月_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---