# ECS-IAUS-sytstem
Unity 的无限轴效用系统  
该效用系统通过识别 AI 可用的选项，并根据当前环境对每个选项进行评分，从而选择最佳选项。由于多种原因，这被证明是一种极其有效的方法。

设计简单 - 效用 AI 通常可以用自然语言设计，这使得 AI 程序员与游戏设计师交流变得容易。无需讨论诸如条件、状态、序列和装饰器等深奥概念。相反，你可以用“如果 AI 正在遭受攻击，则优先寻找掩护”等术语来解释预期的 AI 行为。注意模糊术语——如“优先”——的使用，这符合人类对话的自然方式。

易于扩展 - 规则——通常称为评分器——可以轻松地添加到现有 AI 之上。与有限状态机等不同，没有重要关系需要破坏。评分器只是叠加在现有评分器之上，使得扩展 AI 功能和精度变得简单。

更高质量 - 设计的简洁性和 AI 易于扩展的特点大大减少了错误，显著提高了生产力。这反过来为在给定预算和时间内开发更复杂且表现良好的 AI 留出了更多空间，整体提升了 AI 的质量。

这是我尝试使用 DOTS 在 Unity3d 中创建 Dave Mark 的无限轴效用系统。

什么是无限轴效用系统？

简而言之，它是一个返回具有最高值的动作的系统。它基本上是一个动作列表，每个动作都有一组“轴”。Dave Mark 在几年前的 GDC 上做过相关演讲，我就是在那里了解到它的。我记得他还在同一次演讲中提到了一个猫和激光笔的游戏，这也是 Lol Cats I Can Has Lazer 最初的种子想法，尽管我们的游戏走了自己的设计路线。

以下是演讲链接：

http://intrinsicalgorithm.com/IAonAI/2013/02/both-my-gdc-lectures-on-utility-theory-free-on-gdc-vault/

https://www.gdcvault.com/play/1018040/Architecture-Tricks-Managing-Behaviors-in starts at 33 min mark

此仓库主要用于学习和记录我在 DOTS 和效用 AI 方面的探索历程。如果你正在寻找当前状态下可直接使用的资源，请查看以下链接。  
https://gitlab.com/lclemens/lightweightdotsutilityai

更新支持 Unity 6 Beta  
增加了用于状态的 GOAP 规划


Copyright 2019 - 2024 Dreamers Inc Studios Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---