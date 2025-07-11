# 手势琶音器

手势控制的琶音器、鼓机和音频反应可视化工具。举起你的双手，让音乐嗨起来！

这是一个用 threejs、mediapipe 计算机视觉、rosebud AI 和 tone.js 构建的交互式网页应用。

- 手 #1 控制琶音（举高手提高音高，捏合手势调节音量）
- 手 #2 控制鼓组（举起不同手指切换节奏模式）

[视频](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [在线演示](https://collidingscopes.github.io/arpeggiator/) | [更多代码与教程](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## 系统要求

- 支持 WebGL 的现代网页浏览器
- 开启摄像头权限以实现手部追踪

## 技术栈

- **MediaPipe** 用于手部追踪和手势识别
- **Three.js** 用于音频响应的可视化渲染
- **Tone.js** 用于合成器音效
- **HTML5 Canvas** 用于可视化反馈
- **JavaScript** 用于实时交互
## 开发环境设置

```bash
# 克隆此仓库
git clone https://github.com/collidingScopes/arpeggiator

# 进入项目目录
cd arpeggiator

# 使用你喜欢的方法进行本地服务（以下为 Python 示例）
python -m http.server
```

然后在浏览器中访问 `http://localhost:8000`。

## 许可证

MIT 许可证

## 致谢
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## 相关项目

我已经在这里发布了几个计算机视觉项目（包含代码和教程）：
[玩转计算机视觉](https://www.funwithcomputervision.com/)

您可以购买终身访问权限，获取完整的项目文件和教程。我会定期添加更多内容 🪬

您可能还会喜欢我的其他一些开源项目：

- [3D模型游乐场](https://collidingScopes.github.io/3d-model-playground) - 通过语音和手势控制3D模型
- [Threejs手部追踪教程](https://collidingScopes.github.io/threejs-handtracking-101) - 使用threejs和MediaPipe计算机视觉进行基础手部追踪设置
- [粒子漂流](https://collidingScopes.github.io/particular-drift) - 将照片变成流动的粒子动画
- [视频转ASCII](https://collidingScopes.github.io/ascii) - 将视频转换为ASCII像素艺术
## 联系方式

- Instagram: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X: [@measure_plan](https://x.com/measure_plan)
- 邮箱: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## 捐赠

如果你觉得这个工具有用，欢迎请我喝杯咖啡。

我叫 Alan，我喜欢为计算机视觉、游戏等领域开发开源软件。在深夜编程时，这将是对我的极大支持！

[![请我喝咖啡](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---