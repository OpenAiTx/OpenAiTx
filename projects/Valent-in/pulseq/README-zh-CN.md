# PulseQueue

极简主义电子音乐创作网页应用，使用数字合成器。  
最初设计为草图工具，但也可用于制作完整曲目 :musical_note::notes:

**[:link: 浏览器运行 :link:](https://valent-in.github.io/pulseq)**

- 简单易用  
- 适合移动设备  
- 纯客户端（无服务器数据处理）

- 减法合成器及多种效果  
- 谐波振荡器与基础调频  
- 多层步进音序器  
- 可导出合成器预设  
- WAV音频导出  
- MIDI导出

## 音乐示例（YouTube）  
- [Cosmix - 第一部分](https://www.youtube.com/watch?v=KkLsClq37w4)  
- [Cosmix - 第二部分](https://www.youtube.com/watch?v=8_aYqIMCa2k)  
- [Clean Steps](https://www.youtube.com/watch?v=2IaCb21nIZU)

## 快速开始  
开始时可以尝试内置曲目。启动菜单点击“Demo”按钮，选择示范曲目。重新加载页面可返回此菜单。

**程序标签：**  
ARRANGE :cd:  
将模式组合成完整音乐曲目。

PATTERN :musical_keyboard:  
在此处放置音符。合成引擎为单声道（单音），可通过模式层添加更多声部。

SYNTH :control_knobs:  
选中乐器的配置面板。预设可从三点菜单中获取。

LIST :level_slider::level_slider:  
包含合成器列表及混音器。

## 参考卡片
![overview card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-overview.png)
![controls card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-controls.png)
![routing card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-synth.png)

## 性能说明
- 一些效果对 CPU 资源消耗较大（尤其是混响和相位器）。在移动设备上使用时应考虑这一点。  
- 在移动浏览器上，WAV 导出时长可能被限制在约 10 分钟。

---
使用 Web Audio API 和 [Tone.js](https://github.com/Tonejs/Tone.js)  
文件导出来源：  
[bufferToWave](https://github.com/rwgood18/javascript-audio-file-dynamics-compressor)，  
[midi-writer](https://github.com/carter-thaxton/midi-file)。

本程序是自由软件：您可以根据 GNU 通用公共许可证第 3 版的条款重新分发和/或修改本程序。  
本程序按“原样”发布，不提供任何保证。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---