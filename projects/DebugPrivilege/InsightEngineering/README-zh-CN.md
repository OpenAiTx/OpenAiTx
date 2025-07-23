
# 介绍

本GitHub仓库深入探讨了我认为对理解Windows上复杂问题调试和故障排除非常重要的基本概念。我这里不是指诸如AD复制或打印机故障之类的问题，而是与崩溃转储、死机、性能问题和内存泄漏等相关的问题。

我最初创建此仓库是作为个人参考，当时（现在依然）在学习这个主题。随着时间推移，我决定整合这些资源并公开发布，希望能帮助那些渴望探索该主题并深入学习的人。该内容的受众应是希望入门的人，可能来自IT专业背景。该GitHub仓库可能是未来内容的先决条件。

内容被组织成多个章节，每个章节尽可能强调实操。我认为实践是掌握的关键。因此，每个章节不仅涉及理论，还强调使用Visual Studio、Process Explorer和WinDbg等工具的实际示例。点击 **‘Debugging 101’** 开始学习。

如果你喜欢我的内容并想支持我喝杯咖啡：

<a href="https://www.buymeacoffee.com/debugprivilege" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

# 主题

将涵盖以下主题：

**调试101**

```
- Section 0: How to get started?
- Section 1: Introduction to MEX Extension
- Section 2: Enable Postmortem Debugging
- Section 3: Access Violation
- Section 4: Setup and Create First Driver
- Section 5: Code Defect
- Section 6: Handles
- Section 7: Debug Diag
- Section 8: Introduction to Windows Performance Toolkit
- Section 9: Triaging a Crash Dump
```
**编码基础**

C 代码语言：


```
- Section 1: Variables
- Section 2: Operators
- Section 3: Control Flow
- Section 4: Pointers, Arrays and Strings
- Section 5: Structures
- Section 6: Input & Output
- Section 7: Command Line Arguments
- Section 8: Memory Allocation
- Section 9: Linked List
```
C++ 代码语言：


```
- Section 1: Classes
- Section 2: Initializer Lists
- Section 3: Function Overloading and Templates
- Section 4: Copy and Move Constructors
- Section 5: Inheritance
- Section 6: Smart Pointers
- Section 7: Standard Libraries
```
**Windows API**


```
- Section 1: Threads
- Section 2: Critical Section
- Section 3: Conditional Variables
- Section 4: Interlocked Functions
- Section 5: Wait Functions and Signaling
- Section 6: Event Signaling
- Section 7: Mutex
- Section 8: Semaphore
- Section 9: Slim Reader/Writer Locks
```
**内核取证**


```
- Section 1: Kernel Pool Memory
- Section 2: ERESOURCE
- Section 3: KMUTEX
- Section 4: Fast Mutex
- Section 5: Interrupt Request Levels (IRQL)
- Section 6: Guarded Mutex
- Section 7: Event Signaling
- Section 8: Semaphore
- Section 9: Pushlock
- Section 10: Spinlock
- Section 11: Kernel Callbacks
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---