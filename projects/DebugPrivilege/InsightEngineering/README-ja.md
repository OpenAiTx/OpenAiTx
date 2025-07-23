
# はじめに

このGitHubリポジトリは、Windows上での複雑な問題のデバッグとトラブルシューティングを理解するために重要だと考える基本的な概念に深く踏み込んでいます。ここで扱うのは、ADレプリケーションやプリンターの不具合のような問題ではなく、クラッシュダンプ、ハング、パフォーマンス問題、メモリーリークなどに関連する問題です。

私は当初、このトピックについて学び始めた（そして今も学んでいる）際の個人的なリファレンスとしてこの資料を作成しました。時間が経つにつれて、これらのリソースをまとめて公開し、このトピックに興味を持ち、より深く学びたい方の助けになればと思うようになりました。このコンテンツの対象読者は、これから始めようとしているITプロフェッショナルの方々です。このGitHubリポジトリは将来的なコンテンツの前提条件となるかもしれません。

内容は複数のセクションに分かれており、それぞれできるだけ実践的になるよう設計されています。私は練習が習得への鍵だと信じています。したがって、各セクションは理論だけでなく、Visual Studio、Process Explorer、WinDbgなどのツールを使った実例を重視しています。始めるには**「Debugging 101」**をクリックしてください。

もし私のコンテンツを気に入っていただけたら、コーヒーで応援してください：

<a href="https://www.buymeacoffee.com/debugprivilege" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

# トピック

以下のトピックを扱います：

**Debugging 101**

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
**コーディングの基本**

C言語:


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
C++ コード言語：


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
**カーネルフォレンジクス**


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