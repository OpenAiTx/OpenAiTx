[![Star History Chart](https://api.star-history.com/svg?repos=labuladong/fucking-algorithm&type=Date)](https://star-history.com/#labuladong/fucking-algorithm&Date)

เวอร์ชันภาษาอังกฤษอยู่ที่ [labuladong.online](https://labuladong.online/algo/en/) เช่นกัน ขอให้สนุกกับการเรียนรู้ :)

# labuladong บันทึกอัลกอริทึม

คลังนี้มีบทความต้นฉบับมากกว่า 60 บทความ ทั้งหมดอ้างอิงจากโจทย์ LeetCode ครอบคลุมทุกประเภทของโจทย์และเทคนิค และต้องเน้น **การประยุกต์ใช้ต่อยอด เข้าใจง่าย** ไม่ใช่แค่เพียงการกองโค้ดง่าย ๆ ด้านล่างนี้มีสารบัญ

ขอพูดระบายหน่อย **การฝึกทำโจทย์คือการฝึกคิด วิธีคิดเชิงอัลกอริทึมคือเป้าหมายของคลังนี้** ถ้าผมจะเขียนแค่คลังโค้ด LeetCode อย่างเดียว มันจะมีประโยชน์อะไร? ถ้าไม่มีอธิบายแนวคิด ไม่มีกรอบความคิด มีแค่เวลาซับซ้อน (Time Complexity) ซึ่งมองปราดเดียวก็รู้แล้ว

ถ้าแค่อยากได้เฉลย ก็หาได้ง่ายมาก ในคอมเมนต์โจทย์มีหลากหลายวิธี แถมบางทีก็โชว์ว่า Python แก้ได้ในบรรทัดเดียว มีคนกดไลก์มากมาย แต่คุณทำโจทย์อัลกอริทึมเพื่อเรียนรู้เทคนิคแปลกใหม่ของภาษาโปรแกรมหรือเพื่อพัฒนาความคิดเชิงอัลกอริทึมกันแน่? ความสุขของคุณมาจากการคัดลอกโค้ดคนอื่นผ่านเทสต์ +1 หรือมาจากการใช้เหตุผลและกรอบอัลกอริทึมคิดหาแนวทางเอง?

ในเน็ตมักมีคนมาแซะว่าผมเขียนพื้นฐานเกินไป หรือบอกว่าเรียนอัลกอริทึมต้องไม่ยึดกรอบความคิด ผมบอกได้แค่ว่า พวกเราทำอัลกอริทึมเพื่อหางาน ไม่ใช่แข่งโอลิมปิก ผมเองก็ฝ่าฟันมาเหมือนกัน สิ่งที่ต้องการคือความเข้าใจที่ชัดเจน ไม่ใช่ปิดบังหรือซับซ้อนโดยไม่จำเป็น

ถ้าไม่พยายามทำให้เข้าใจง่าย ต้องเริ่มจากอวย "Introduction to Algorithms" ก่อน แล้วค่อยไล่ให้คนออกเพราะกลัวเกินไปหรือ?

**ทำอะไรมาก ๆ จะเจอรูปแบบ ผมสรุปกรอบรูปแบบอัลกอริทึมไว้ หวังว่าจะช่วยให้คนอื่นไม่ต้องเดินอ้อม** ผมเป็นเด็กที่เรียนเอง ใช้เวลาหนึ่งปีฝึกทำโจทย์และสรุป จนเขียนเป็น "สูตรลัด" อัลกอริทึม มีสารบัญอยู่ด้านล่าง ไม่พูดมากแล้ว

## ก่อนเริ่มเรียน

**1. กด Star ให้คลังนี้ก่อน สนองความอยากดังของผม** คุณภาพบทความคุ้มค่าแน่นอน ผมยังคงเขียนต่อไป ให้กำลังใจผมด้วย ขอบคุณครับ

**2. แนะนำให้บันทึกเว็บไซต์ออนไลน์ของผมไว้ ทุกบทความมีลิงก์ไปยังโจทย์ LeetCode ที่เกี่ยวข้อง สามารถอ่านบทความไปทำโจทย์ไปได้ รวมแล้วจะพาคุณทำถึง 500 โจทย์**

ที่อยู่ล่าสุดปี 2024: https://labuladong.online/algo/

~~ที่อยู่ GitHub Pages: https://labuladong.online/algo/~~

~~ที่อยู่ Gitee Pages: https://labuladong.gitee.io/algo/~~

## labuladong ชุดอัลกอริทึม All-in-one

### 1. แผงควบคุมการแสดงผลอัลกอริทึม

เว็บไซต์ของผมและปลั๊กอินทั้งหมดได้รวมเครื่องมือช่วยแสดงผลอัลกอริทึมแบบ Visualization สามารถแสดงผลโครงสร้างข้อมูลและขั้นตอนการเรียกซ้ำ ช่วยลดความยากในการเข้าใจอัลกอริทึม โค้ดคำตอบเกือบทุกโจทย์มีแผง Visualization ที่เกี่ยวข้อง ดูรายละเอียดด้านล่าง

### 2. เว็บไซต์เรียนรู้

เนื้อหาหลักคือบทเรียนอัลกอริทึมของผม เผยแพร่ที่ [labuladong.online](https://labuladong.online/algo/) เชื่อว่าคุณจะใช้เวลาศึกษาที่นี่มากมาย ไม่ใช่แค่บันทึกไว้เฉย ๆ

![](https://labuladong.github.io/pictures/简介/web_intro1.jpg)

### 3. ปลั๊กอิน Chrome

**ฟังก์ชันหลัก**: ปลั๊กอิน Chrome สามารถดู "คำอธิบายโจทย์" หรือ "แนวคิด" ของผมได้อย่างรวดเร็วบน LeetCode ภาษาจีนหรืออังกฤษ และเพิ่มความสัมพันธ์ระหว่างโจทย์กับเทคนิคอัลกอริทึม สามารถเชื่อมโยงกับเว็บไซต์/Official Account/คอร์สของผม มอบประสบการณ์ทำโจทย์ที่ลื่นไหลที่สุด คู่มือการติดตั้งอยู่ด้านล่าง

![](https://labuladong.github.io/pictures/简介/chrome_intro.jpg)

### 4. ปลั๊กอิน vscode

**ฟังก์ชันหลัก**: ฟังก์ชันเหมือนกับปลั๊กอิน Chrome สำหรับผู้อ่านที่ชอบทำโจทย์บน vscode สามารถใช้ปลั๊กอินนี้ได้ คู่มือการติดตั้งอยู่ด้านล่าง

![](https://labuladong.github.io/pictures/简介/vs_intro.jpg)

### 5. ปลั๊กอิน Jetbrains

**ฟังก์ชันหลัก**: ฟังก์ชันเหมือนกับปลั๊กอิน Chrome สำหรับผู้อ่านที่ชอบทำโจทย์บน IDE ของ Jetbrains (PyCharm/Intellij/Goland ฯลฯ) สามารถใช้ปลั๊กอินนี้ได้ คู่มือการติดตั้งอยู่ด้านล่าง

![](https://labuladong.github.io/pictures/简介/jb_intro.jpg)

ขอให้ทุกคนสนุกกับการเรียนรู้ ท่องไปในมหาสมุทรโจทย์อย่างมีความสุข!

# สารบัญบทความ

<!-- table start -->

### [แนะนำเว็บไซต์](https://labuladong.online/algo/home/)

### [ปลั๊กอินเสริมและการแสดงผลอัลกอริทึม](https://labuladong.online/algo/menu/tools/)
  * [ปลั๊กอิน Chrome เสริมการทำโจทย์](https://labuladong.online/algo/intro/chrome/)
  * [ปลั๊กอิน vscode เสริมการทำโจทย์](https://labuladong.online/algo/intro/vscode/)
  * [ปลั๊กอิน JetBrains เสริมการทำโจทย์](https://labuladong.online/algo/intro/jetbrains/)
  * [คู่มือการใช้แผง Visualization](https://labuladong.online/algo/intro/visualize/)
  * [สมาชิกเสียเงินของเว็บไซต์](https://labuladong.online/algo/intro/site-vip/)

### [แผนการเรียนสำหรับผู้เริ่มต้นและเรียนแบบเร่งรัด](https://labuladong.online/algo/menu/plan/)
  * [จุดสำคัญและกับดักของการฝึกทำโจทย์อัลกอริทึม](https://labuladong.online/algo/intro/how-to-learn-algorithms/)
  * [แผนการเรียนสำหรับผู้เริ่มต้น](https://labuladong.online/algo/intro/beginner-learning-plan/)
  * [แผนการเรียนแบบเร่งรัด](https://labuladong.online/algo/intro/quick-learning-plan/)
  * [วิธีฝึก/ทบทวนบทฝึกหัดแต่ละบท](https://labuladong.online/algo/intro/how-to-practice/)
  * [หน้าสรุปเทคนิค Visualization](https://labuladong.online/algo/intro/visualize-catalog/)

### [เริ่มต้น: พื้นฐานภาษาโปรแกรมและการฝึก](https://labuladong.online/algo/menu/)
  * [คำนำบทนี้](https://labuladong.online/algo/intro/programming-language-basic/)
  * [พื้นฐานภาษา C++](https://labuladong.online/algo/programming-language-basic/cpp/)
  * [พื้นฐานภาษา Java](https://labuladong.online/algo/programming-language-basic/java/)
  * [พื้นฐานภาษา Golang](https://labuladong.online/algo/programming-language-basic/golang/)
  * [พื้นฐานภาษา Python](https://labuladong.online/algo/programming-language-basic/python/)
  * [พื้นฐานภาษา JavaScript](https://labuladong.online/algo/intro/js/)
  * [ข้อควรรู้สำหรับการทำโจทย์ LeetCode](https://labuladong.online/algo/intro/leetcode/)
  * [การฝึกทำโจทย์โดยใช้ภาษาโปรแกรม](https://labuladong.online/algo/programming-language-basic/lc-practice/)

### [พื้นฐาน: โครงสร้างข้อมูลและการเรียงลำดับเชิงลึก](https://labuladong.online/algo/menu/quick-start/)
  * [คำนำบทนี้](https://labuladong.online/algo/intro/data-structure-basic/)
  * [แนะนำ Time/Space Complexity](https://labuladong.online/algo/intro/complexity-basic/)

  * [สอนทำ Dynamic Array ทีละขั้น](https://labuladong.online/algo/menu/dynamic-array/)
    * [หลักการของ Array (การจัดเก็บแบบลำดับ)](https://labuladong.online/algo/data-structure-basic/array-basic/)
    * [โค้ดการทำ Dynamic Array](https://labuladong.online/algo/data-structure-basic/array-implement/)

  * [สอนทำ Single/Double Linked List ทีละขั้น](https://labuladong.online/algo/menu/linked-list/)
    * [หลักการของ Linked List (การจัดเก็บแบบโซ่)](https://labuladong.online/algo/data-structure-basic/linkedlist-basic/)
    * [โค้ดการทำ Linked List](https://labuladong.online/algo/data-structure-basic/linkedlist-implement/)

  * [สอนทำ Queue/Stack ทีละขั้น](https://labuladong.online/algo/menu/queue-stack/)
    * [หลักการของ Queue/Stack](https://labuladong.online/algo/data-structure-basic/queue-stack-basic/)
    * [ใช้ Linked List ทำ Queue/Stack](https://labuladong.online/algo/data-structure-basic/linked-queue-stack/)
    * [เทคนิค Circular Array](https://labuladong.online/algo/data-structure-basic/cycle-array/)
    * [ใช้ Array ทำ Queue/Stack](https://labuladong.online/algo/data-structure-basic/array-queue-stack/)
    * [หลักการและโค้ด Deque (Double-ended Queue)](https://labuladong.online/algo/data-structure-basic/deque-implement/)

  * [หลักการและการทำ Hash Table](https://labuladong.online/algo/menu/)
    * [หลักการสำคัญของ Hash Table](https://labuladong.online/algo/data-structure-basic/hashmap-basic/)
    * [ทำ Hash Table แบบ Chaining](https://labuladong.online/algo/data-structure-basic/hashtable-chaining/)
    * [สองจุดยากของ Linear Probing](https://labuladong.online/algo/data-structure-basic/linear-probing-key-point/)
    * [โค้ด Linear Probing สองแบบ](https://labuladong.online/algo/data-structure-basic/linear-probing-code/)
    * [หลักการและโค้ด Hash Set](https://labuladong.online/algo/data-structure-basic/hash-set/)

  * [การเปลี่ยนแปลงโครงสร้าง Hash Table](https://labuladong.online/algo/menu/)
    * [เสริม Hash Table ด้วย Linked List (LinkedHashMap)](https://labuladong.online/algo/data-structure-basic/hashtable-with-linked-list/)
    * [เสริม Hash Table ด้วย Array (ArrayHashMap)](https://labuladong.online/algo/data-structure-basic/hashtable-with-array/)

  * [โครงสร้างและการเดินโค้ด Binary Tree](https://labuladong.online/algo/menu/binary-tree/)
    * [พื้นฐานและประเภท Binary Tree](https://labuladong.online/algo/data-structure-basic/binary-tree-basic/)
    * [Binary Tree Traversal แบบ Recursive/Level Order](https://labuladong.online/algo/data-structure-basic/binary-tree-traverse-basic/)
    * [Traversal ของ N-ary Tree แบบ Recursive/Level Order](https://labuladong.online/algo/data-structure-basic/n-ary-tree-traverse-basic/)

  * [การเปลี่ยนแปลงโครงสร้าง Binary Tree](https://labuladong.online/algo/menu/binary-tree/)
    * [การใช้งานและ Visualization ของ BST](https://labuladong.online/algo/data-structure-basic/tree-map-basic/)
    * [สมดุลสมบูรณ์ของ Red-Black Tree และ Visualization](https://labuladong.online/algo/data-structure-basic/rbtree-basic/)
    * [หลักการและ Visualization ของ Trie/Prefix Tree](https://labuladong.online/algo/data-structure-basic/trie-map-basic/)
    * [หลักการและ Visualization ของ Binary Heap](https://labuladong.online/algo/data-structure-basic/binary-heap-basic/)
    * [โค้ด Binary Heap/Priority Queue](https://labuladong.online/algo/data-structure-basic/binary-heap-implement/)
    * [หลักการและ Visualization ของ Segment Tree](https://labuladong.online/algo/data-structure-basic/segment-tree-basic/)
    * [กำลังอัปเดต ing](https://labuladong.online/algo/intro/updating/)

  * [โครงสร้างและ Traversal ของกราฟ](https://labuladong.online/algo/menu/graph-theory/)
    * [พื้นฐานโครงสร้างกราฟและโค้ดมาตรฐาน](https://labuladong.online/algo/data-structure-basic/graph-basic/)
    * [DFS/BFS Traversal ของกราฟ](https://labuladong.online/algo/data-structure-basic/graph-traverse-basic/)
    * [หลักการ Union Find](https://labuladong.online/algo/data-structure-basic/union-find-basic/)
    * [กำลังอัปเดต ing](https://labuladong.online/algo/intro/updating/)

  * [10 อัลกอริทึมการเรียงลำดับและ Visualization](https://labuladong.online/algo/menu/sorting/)
    * [คำนำบทนี้](https://labuladong.online/algo/intro/sorting/)
    * [ตัวชี้วัดสำคัญของอัลกอริทึมเรียงลำดับ](https://labuladong.online/algo/data-structure-basic/sort-basic/)
    * [ปัญหาของ Selection Sort](https://labuladong.online/algo/data-structure-basic/select-sort/)
    * [Bubble Sort ที่เสถียร](https://labuladong.online/algo/data-structure-basic/bubble-sort/)
    * [Insertion Sort แบบคิดย้อน](https://labuladong.online/algo/data-structure-basic/insertion-sort/)
    * [Shell Sort ที่เร็วกว่า O(N^2)](https://labuladong.online/algo/data-structure-basic/shell-sort/)
    * [Quick Sort ใช้โครงสร้าง Binary Tree Preorder](https://labuladong.online/algo/data-structure-basic/quick-sort/)
    * [Merge Sort ใช้ Binary Tree Postorder](https://labuladong.online/algo/data-structure-basic/merge-sort/)
    * [Heap Sort ใช้โครงสร้าง Binary Heap](https://labuladong.online/algo/data-structure-basic/heap-sort/)
    * [Counting Sort หลักการใหม่](https://labuladong.online/algo/data-structure-basic/counting-sort/)
    * [Bucket Sort รวมข้อดีทุกอย่าง](https://labuladong.online/algo/data-structure-basic/bucket-sort/)
    * [Radix Sort](https://labuladong.online/algo/data-structure-basic/radix-sort/)

  * [กำลังอัปเดต ing](https://labuladong.online/algo/intro/updating/)

### [บทที่ 0 สรุปกรอบแนวคิดการทำโจทย์หลัก](https://labuladong.online/algo/menu/core/)
  * [คำนำบทนี้](https://labuladong.online/algo/intro/core-intro/)
  * [กรอบการเรียนข้อมูลโครงสร้างและอัลกอริทึม](https://labuladong.online/algo/essential-technique/algorithm-summary/)
  * [เทคนิค Two Pointers พิชิต 7 โจทย์ Linked List](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
  * [เทคนิค Two Pointers พิชิต 7 โจทย์ Array](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
  * [โค้ดแม่แบบ Sliding Window Algorithm](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
  * [โค้ดแม่แบบ Binary Search Algorithm](https://labuladong.online/algo/essential-technique/binary-search-framework/)
  * [กรอบการแก้โจทย์ Dynamic Programming](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
  * [กรอบการแก้โจทย์ Backtracking](https://labuladong.online/algo/essential-technique/backtrack-framework/)
  * [กรอบการแก้โจทย์ BFS](https://labuladong.online/algo/essential-technique/bfs-framework/)
  * [แนวทางหลักของอัลกอริทึม Binary Tree](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
  * [Backtracking พิชิตทุกโจทย์ Permutation/Combination/Subset](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
  * [กรอบการแก้โจทย์ Greedy Algorithm](https://labuladong.online/algo/essential-technique/greedy/)
  * [กรอบการแก้โจทย์ Divide and Conquer](https://labuladong.online/algo/essential-technique/divide-and-conquer/)
  * [คู่มือวิเคราะห์ Complexity อย่างมืออาชีพ](https://labuladong.online/algo/essential-technique/complexity-analysis/)

### [บทที่ 1 อัลกอริทึมโครงสร้างข้อมูลคลาสสิก](https://labuladong.online/algo/menu/ds/)
  * [ฝึก Linked List ทีละขั้น](https://labuladong.online/algo/menu/linked-list/)
    * [เทคนิค Two Pointers พิชิต 7 โจทย์ Linked List](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
    * [**ฝึกเสริม** โจทย์คลาสสิก Double Pointer บน Linked List](https://labuladong.online/algo/problem-set/linkedlist-two-pointers/)
    * [สรุปวิธี Reverse Linked List หลายแบบ](https://labuladong.online/algo/data-structure/reverse-linked-list-recursion/)
    * [วิธีตรวจสอบ Palindrome Linked List](https://labuladong.online/algo/data-structure/palindrome-linked-list/)

  * [ฝึก Array ทีละขั้น](https://labuladong.online/algo/menu/array/)
    * [เทคนิค Two Pointers พิชิต 7 โจทย์ Array](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
    * [เทคนิค Traversal Array 2 มิติแบบต่าง ๆ](https://labuladong.online/algo/practice-in-action/2d-array-traversal-summary/)
    * [วิธีพิชิต nSum ปัญหาทั้งหมด](https://labuladong.online/algo/practice-in-action/nsum/)
    * [**ฝึกเสริม** โจทย์คลาสสิก Double Pointer บน Array](https://labuladong.online/algo/problem-set/array-two-pointers/)
    * [เทคนิค Prefix Sum Array](https://labuladong.online/algo/data-structure/prefix-sum/)
    * [**ฝึกเสริม** โจทย์คลาสสิก Prefix Sum](https://labuladong.online/algo/problem-set/perfix-sum/)
    * [เทคนิค Difference Array](https://labuladong.online/algo/data-structure/diff-array/)
    * [โค้ดแม่แบบ Sliding Window Algorithm](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
    * [**ฝึกเสริม** โจทย์คลาสสิก Sliding Window](https://labuladong.online/algo/problem-set/sliding-window/)
    * [ขยาย Sliding Window: Rabin Karp String Matching](https://labuladong.online/algo/practice-in-action/rabinkarp/)
    * [โค้ดแม่แบบ Binary Search Algorithm](https://labuladong.online/algo/essential-technique/binary-search-framework/)
    * [กรอบคิดเมื่อใช้ Binary Search ในงานจริง](https://labuladong.online/algo/frequency-interview/binary-search-in-action/)
    * [**ฝึกเสริม** โจทย์คลาสสิก Binary Search](https://labuladong.online/algo/problem-set/binary-search/)
    * [อัลกอริทึมสุ่มเลือกตามน้ำหนัก (Random Pick With Weight)](https://labuladong.online/algo/frequency-interview/random-pick-with-weight/)
    * [กลยุทธ์ Algorithm ใน "เทียนจี้แข่งม้า"] (https://labuladong.online/algo/practice-in-action/advantage-shuffle/)

  * [ฝึก Binary Tree ทีละขั้น](https://labuladong.online/algo/menu/binary-tree/)
    * [แนวทางหลักของอัลกอริทึม Binary Tree](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
    * [Binary Tree Mentality (แนวคิด)](https://labuladong.online/algo/data-structure/binary-tree-part1/)
    * [Binary Tree Mentality (สร้าง)](https://labuladong.online/algo/data-structure/binary-tree-part2/)
    * [Binary Tree Mentality (Postorder)](https://labuladong.online/algo/data-structure/binary-tree-part3/)
    * [Binary Tree Mentality (Serialization)](https://labuladong.online/algo/data-structure/serialize-and-deserialize-binary-tree/)
    * [BST Mentality (Properties)](https://labuladong.online/algo/data-structure/bst-part1/)
    * [BST Mentality (Basic Operations)](https://labuladong.online/algo/data-structure/bst-part2/)
    * [BST Mentality (Construction)](https://labuladong.online/algo/data-structure/bst-part3/)
    * [BST Mentality (Postorder)](https://labuladong.online/algo/data-structure/bst-part4/)

  * [ใช้แม่แบบพิชิต 100 โจทย์ Binary Tree](https://labuladong.online/algo/menu/100-bt/)
    * [คำนำบทนี้](https://labuladong.online/algo/intro/binary-tree-practice/)
    * [**ฝึกเสริม** โจทย์ Traversal Binary Tree I](https://labuladong.online/algo/problem-set/binary-tree-traverse-i/)
    * [**ฝึกเสริม** โจทย์ Traversal Binary Tree II](https://labuladong.online/algo/problem-set/binary-tree-traverse-ii/)
    * [**ฝึกเสริม** โจทย์ Traversal Binary Tree III](https://labuladong.online/algo/problem-set/binary-tree-traverse-iii/)
    * [**ฝึกเสริม** โจทย์ Divide and Conquer Binary Tree I](https://labuladong.online/algo/problem-set/binary-tree-divide-i/)
    * [**ฝึกเสริม** โจทย์ Divide and Conquer Binary Tree II](https://labuladong.online/algo/problem-set/binary-tree-divide-ii/)
    * [**ฝึกเสริม** ใช้สองแนวคิดผสมกันแก้โจทย์](https://labuladong.online/algo/problem-set/binary-tree-combine-two-view/)
    * [**ฝึกเสริม** โจทย์ Postorder Binary Tree I](https://labuladong.online/algo/problem-set/binary-tree-post-order-i/)
    * [**ฝึกเสริม** โจทย์ Postorder Binary Tree II](https://labuladong.online/algo/problem-set/binary-tree-post-order-ii/)
    * [**ฝึกเสริม** โจทย์ Postorder Binary Tree III](https://labuladong.online/algo/problem-set/binary-tree-post-order-iii/)
    * [**ฝึกเสริม** โจทย์ Level Order Binary Tree I](https://labuladong.online/algo/problem-set/binary-tree-level-i/)
    * [**ฝึกเสริม** โจทย์ Level Order Binary Tree II](https://labuladong.online/algo/problem-set/binary-tree-level-ii/)
    * [**ฝึกเสริม** โจทย์คลาสสิก BST I](https://labuladong.online/algo/problem-set/bst1/)
    * [**ฝึกเสริม** โจทย์คลาสสิก BST II](https://labuladong.online/algo/problem-set/bst2/)

  * [ขยาย Binary Tree](https://labuladong.online/algo/menu/more-bt/)
    * [ขยาย: กรอบการแก้โจทย์ LCA](https://labuladong.online/algo/practice-in-action/lowest-common-ancestor-summary/)
    * [ขยาย: วิธีนับจำนวน Node ของ Complete Binary Tree](https://labuladong.online/algo/data-structure/count-complete-tree-nodes/)
    * [ขยาย: Flatten N-ary Tree แบบ Lazy](https://labuladong.online/algo/data-structure/flatten-nested-list-iterator/)
    * [ขยาย: อธิบายและใช้ Merge Sort](https://labuladong.online/algo/practice-in-action/merge-sort/)
    * [ขยาย: อธิบายและใช้ Quick Sort](https://labuladong.online/algo/practice-in-action/quick-sort/)
    * [ขยาย: ใช้ Stack จำลอง Iterative Traversal Binary Tree](https://labuladong.online/algo/data-structure/iterative-traversal-binary-tree/)

  * [ออกแบบโครงสร้างข้อมูลด้วยตัวเอง](https://labuladong.online/algo/menu/design/)
    * [Queue ทำ Stack และ Stack ทำ Queue](https://labuladong.online/algo/data-structure/stack-queue/)
    * [**ฝึกเสริม** โจทย์ Stack คลาสสิก](https://labuladong.online/algo/problem-set/stack/)
    * [**ฝึกเสริม** โจทย์เกี่ยวกับวงเล็บ](https://labuladong.online/algo/problem-set/parentheses/)
    * [**ฝึกเสริม** โจทย์ Queue คลาสสิก](https://labuladong.online/algo/problem-set/queue/)
    * [แม่แบบ Monotonic Stack แก้ 3 โจทย์คลาสสิก](https://labuladong.online/algo/data-structure/monotonic-stack/)
    * [**ฝึกเสริม** Monotonic Stack แบบต่าง ๆ และโจทย์คลาสสิก](https://labuladong.online/algo/problem-set/monotonic-stack/)
    * [Monotonic Queue แก้ปัญหา Sliding Window](https://labuladong.online/algo/data-structure/monotonic-queue/)
    * [**ฝึกเสริม** Monotonic Queue โค้ดทั่วไปและโจทย์คลาสสิก](https://labuladong.online/algo/problem-set/monotonic-queue/)
    * [เหมือนต่อ Lego: เขียน LRU Algorithm ด้วยตัวเอง](https://labuladong.online/algo/data-structure/lru-cache/)
    * [เหมือนต่อ Lego: เขียน LFU Algorithm ด้วยตัวเอง](https://labuladong.online/algo/frequency-interview/lfu/)
    * [ลบ/ค้นหาองค์ประกอบ Array ใด ๆ ใน O(1)](https://labuladong.online/algo/data-structure/random-set/)
    * [**ฝึกเสริม** โจทย์ Hash Table เพิ่มเติม](https://labuladong.online/algo/problem-set/hash-table/)
    * [**ฝึกเสริม** โจทย์ Priority Queue คลาสสิก](https://labuladong.online/algo/problem-set/binary-heap/)
    * [TreeMap/TreeSet โค้ด Implementation](https://labuladong.online/algo/data-structure-basic/tree-map-implement/)
    * [SegmentTree โค้ด Implementation](https://labuladong.online/algo/data-structure/segment-tree-implement/)
    * [Trie/Prefix Tree โค้ด Implementation](https://labuladong.online/algo/data-structure/trie-implement/)
    * [**ฝึกเสริม** โจทย์ Trie Tree](https://labuladong.online/algo/problem-set/trie/)
    * [ออกแบบ Timeline ของ Social Network](https://labuladong.online/algo/data-structure/design-twitter/)
    * [ออกแบบอัลกอริทึมแบ่งที่นั่งห้องสอบ](https://labuladong.online/algo/frequency-interview/exam-room/)
    * [**ฝึกเสริม** โจทย์ Design คลาสสิก](https://labuladong.online/algo/problem-set/ds-design/)
    * [ขยาย: วิธีทำ Calculator](https://labuladong.online/algo/data-structure/implement-calculator/)
    * [ขยาย: ใช้ 2 Binary Heap หา Median](https://labuladong.online/algo/practice-in-action/find-median-from-data-stream/)
    * [ขยาย: ปัญหาลบ Array ซ้ำ (แบบยาก)](https://labuladong.online/algo/frequency-interview/remove-duplicate-letters/)

  * [ฝึกกราฟทีละขั้น](https://labuladong.online/algo/menu/graph/)
    * [การตรวจ Loop และ Topological Sort](https://labuladong.online/algo/data-structure/topological-sort/)
    * [โจทย์ "หาเซเลบ" (Find Celebrity)](https://labuladong.online/algo/frequency-interview/find-celebrity/)
    * [การตรวจสอบ Bipartite Graph](https://labuladong.online/algo/data-structure/bipartite-graph/)
    * [Union-Find Algorithm](https://labuladong.online/algo/data-structure/union-find/)
    * [**ฝึกเสริม** โจทย์ Union-Find คลาสสิก](https://labuladong.online/algo/problem-set/union-find/)
    * [Kruskal Minimum Spanning Tree Algorithm](https://labuladong.online/algo/data-structure/kruskal/)
    * [Prim Minimum Spanning Tree Algorithm](https://labuladong.online/algo/data-structure/prim/)
    * [Dijkstra Algorithm Template & Application](https://labuladong.online/algo/data-structure/dijkstra/)
    * [**ฝึกเสริม** โจทย์ Dijkstra คลาสสิก](https://labuladong.online/algo/problem-set/dijkstra/)

### [บทที่ 2 อัลกอริทึม Brute-force Search คลาสสิก](https://labuladong.online/algo/menu/braute-force-search/)
  * [DFS/Backtracking](https://labuladong.online/algo/menu/dfs/)
    * [กรอบการแก้โจทย์ Backtracking](https://labuladong.online/algo/essential-technique/backtrack-framework/)
    * [ฝึก Backtracking: Sudoku และ N-Queens](https://labuladong.online/algo/practice-in-action/sudoku-nqueue/)
    * [Backtracking พิชิตทุกโจทย์ Permutation/Combination/Subset](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
    * [โมเดลกล่องบอล: สองมุมมองของการ Enumerate Backtracking](https://labuladong.online/algo/practice-in-action/two-views-of-backtrack/)
    * [ตอบข้อสงสัย DFS/Backtracking](https://labuladong.online/algo/essential-technique/backtrack-vs-dfs/)
    * [เคลียร์ทุกปัญหา Island DFS](https://labuladong.online/algo/frequency-interview/island-dfs-summary/)
    * [ฝึก Backtracking: Generate Parentheses](https://labuladong.online/algo/practice-in-action/generate-parentheses/)
    * [ฝึก Backtracking: Partition to K Equal Sum Subsets](https://labuladong.online/algo/practice-in-action/partition-to-k-equal-sum-subsets/)
    * [**ฝึกเสริม** โจทย์ Backtracking คลาสสิก I](https://labuladong.online/algo/problem-set/backtrack-i/)
    * [**ฝึกเสริม** โจทย์ Backtracking คลาสสิก II](https://labuladong.online/algo/problem-set/backtrack-ii/)
    * [**ฝึกเสริม** โจทย์ Backtracking คลาสสิก III](https://labuladong.online/algo/problem-set/backtrack-iii/)

  * [BFS Algorithm](https://labuladong.online/algo/menu/bfs/)
    * [กรอบการแก้โจทย์ BFS](https://labuladong.online/algo/essential-technique/bfs-framework/)
    * [**ฝึกเสริม** โจทย์ BFS คลาสสิก I](https://labuladong.online/algo/problem-set/bfs/)
    * [**ฝึกเสริม** โจทย์ BFS คลาสสิก II](https://labuladong.online/algo/problem-set/bfs-ii/)
    * [กำลังอัปเดต ing](https://labuladong.online/algo/intro/updating/)

### [บทที่ 3 อัลกอริทึม Dynamic Programming คลาสสิก](https://labuladong.online/algo/menu/dp/)
  * [เทคนิคพื้นฐาน DP](https://labuladong.online/algo/menu/dp-basic/)
    * [กรอบการแก้โจทย์ DP](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
    * [ออกแบบ DP: Longest Increasing Subsequence](https://labuladong.online/algo/dynamic-programming/longest-increasing-subsequence/)
    * [กำหนด Base Case และ Memoization ยังไง?](https://labuladong.online/algo/dynamic-programming/memo-fundamental/)
    * [สองมุมมองของการ Enumerate DP](https://labuladong.online/algo/dynamic-programming/two-views-of-dp/)
    * [การเปลี่ยนวิธีคิด DP vs Backtracking](https://labuladong.online/algo/dynamic-programming/word-break/)
    * [ลดมิติ DP](https://labuladong.online/algo/dynamic-programming/space-optimization/)
    * [หลักการ Substructure และทิศทาง Traversal ของ dp array](https://labuladong.online/algo/dynamic-programming/faq-summary/)

  * [ปัญหา Subsequence](https://labuladong.online/algo/menu/subsequence/)
    * [DP คลาสสิก: Edit Distance](https://labuladong.online/algo/dynamic-programming/edit-distance/)
    * [ออกแบบ DP: Maximum Subarray](https://labuladong.online/algo/dynamic-programming/maximum-subarray/)
    * [DP คลาสสิก: Longest Common Subsequence](https://labuladong.online/algo/dynamic-programming/longest-common-subsequence/)
    * [Template การแก้โจทย์ DP Subsequence](https://labuladong.online/algo/dynamic-programming/subsequence-problem/)

  * [ปัญหา Knapsack](https://labuladong.online/algo/menu/knapsack/)
    * [DP คลาสสิก: 0-1 Knapsack](https://labuladong.online/algo/dynamic-programming/knapsack1/)
    * [DP คลาสสิก: Subset Knapsack](https://labuladong.online/algo/dynamic-programming/knapsack2/)
    * [DP คลาสสิก: Complete Knapsack](https://labuladong.online/algo/dynamic-programming/knapsack3/)
    * [Knapsack Variation: Target Sum](https://labuladong.online/algo/dynamic-programming/target-sum/)

  * [เล่นเกมด้วย DP](https://labuladong.online/algo/menu/dp-game/)
    * [DP: Minimum Path Sum](https://labuladong.online/algo/dynamic-programming/minimum-path-sum/)
    * [DP ช่วยผ่านด่าน "Magic Tower"](https://labuladong.online/algo/dynamic-programming/magic-tower/)
    * [DP ช่วยผ่านด่าน "Fallout 4"](https://labuladong.online/algo/dynamic-programming/freedom-trail/)
    * [ท่องเที่ยวประหยัด: Weighted Shortest Path](https://labuladong.online/algo/dynamic-programming/cheap-travel/)
    * [DP คลาสสิก: Regular Expression Matching](https://labuladong.online/algo/dynamic-programming/regular-expression-matching/)
    * [DP คลาสสิก: Egg Drop](https://labuladong.online/algo/dynamic-programming/egg-drop/)
    * [DP คลาสสิก: Burst Balloons](https://labuladong.online/algo/dynamic-programming/burst-balloons/)
    * [DP คลาสสิก: Game Theory](https://labuladong.online/algo/dynamic-programming/game-theory/)
    * [วิธีพิชิต House Robber ปัญหา LeetCode](https://labuladong.online/algo/dynamic-programming/house-robber/)
    * [วิธีพิชิตปัญหาซื้อขายหุ้นใน LeetCode](https://labuladong.online/algo/dynamic-programming/stock-problem-summary/)

  * [ปัญหา Greedy](https://labuladong.online/algo/menu/greedy/)
    * [กรอบการแก้โจทย์ Greedy Algorithm](https://labuladong.online/algo/essential-technique/greedy/)
    * [Algorithm เติมน้ำมันสำหรับนักขับ](https://labuladong.online/algo/frequency-interview/gas-station-greedy/)
    * [Greedy กับปัญหา Interval Scheduling](https://labuladong.online/algo/frequency-interview/interval-scheduling/)
    * [เทคนิค Scan Line: จัดห้องประชุม](https://labuladong.online/algo/frequency-interview/scan-line-technique/)
    * [ตัดวิดีโอด้วย Greedy Algorithm](https://labuladong.online/algo/frequency-interview/cut-video/)

### [บทที่ 4 เทคนิคอัลกอริทึมอื่น ๆ ที่พบบ่อย](https://labuladong.online/algo/menu/other/)
  * [เทคนิคคณิตศาสตร์](https://labuladong.online/algo/menu/math/)
    * [โจทย์ที่แก้ได้ด้วยโค้ดบรรทัดเดียว](https://labuladong.online/algo/frequency-interview/one-line-solutions/)
    * [Bitwise Operation ที่พบบ่อย](https://labuladong.online/algo/frequency-interview/bitwise-operation/)
    * [พูดถึง Random Algorithm ในเกม](https://labuladong.online/algo/frequency-interview/random-algorithm/)
    * [2 ปัญหา Factorial ที่พบบ่อย](https://labuladong.online/algo/frequency-interview/factorial-problems/)
    * [วิธีหา Prime Number อย่างมีประสิทธิภาพ](https://labuladong.online/algo/frequency-interview/print-prime-number/)
    * [วิธีทำ Modular Exponentiation อย่างมีประสิทธิภาพ](https://labuladong.online/algo/frequency-interview/quick-power/)
    * [วิธีหา Missing/Repeated Element พร้อมกัน](https://labuladong.online/algo/frequency-interview/mismatch-set/)
    * [ปัญหา Probability ที่ดูเหมือนขัดความรู้สึก](https://labuladong.online/algo/frequency-interview/probability-problem/)
    * [**ฝึกเสริม** โจทย์เทคนิคคณิตศาสตร์](https://labuladong.online/algo/problem-set/math-tricks/)

  * [โจทย์สัมภาษณ์คลาสสิก](https://labuladong.online/algo/menu/interview/)
    * [เทคนิค "หลอกคะแนน" ในข้อสอบอัลกอริทึม](https://labuladong.online/algo/other-skills/tips-in-exam/)
    * [วิธีแก้ปัญหา Trapping Rain Water อย่างมีประสิทธิภาพ](https://labuladong.online/algo/frequency-interview/trapping-rain-water/)
    * [สรุปทุกปัญหา Ugly Number](https://labuladong.online/algo/frequency-interview/ugly-number-summary/)
    * [วิธีเดียวแก้ 3 ปัญหา Interval](https://labuladong.online/algo/practice-in-action/interval-problem-summary/)
    * [ใครจะคิดว่าเล่น "โดดเดี่ยว" ก็มีอัลกอริทึม](https://labuladong.online/algo/practice-in-action/split-array-into-consecutive-subsequences/)
    * [Pancake Sorting Algorithm](https://labuladong.online/algo/frequency-interview/pancake-sorting/)
    * [Multiplying Strings Algorithm](https://labuladong.online/algo/practice-in-action/multiply-strings/)
    * [วิธีตรวจสอบ Perfect Rectangle](https://labuladong.online/algo/frequency-interview/perfect-rectangle/)

### [ภาคผนวก](https://labuladong.online/algo/menu/appendix/)
  * [changelog ของ labuladong.online](https://labuladong.online/algo/changelog/website/)
  * [changelog ของแผง Visualization](https://labuladong.online/algo/changelog/visualize/)
  * [changelog ของปลั๊กอิน Chrome](https://labuladong.online/algo/changelog/chrome/)
  * [changelog ของปลั๊กอิน vscode](https://labuladong.online/algo/changelog/vscode/)
  * [changelog ของปลั๊กอิน Jetbrain](https://labuladong.online/algo/changelog/jetbrain/)
  * [รายงานปัญหาเว็บไซต์/ปลั๊กอิน](https://labuladong.online/algo/intro/bug-report/)

<!-- table end -->

# ขอบคุณผู้ร่วมแปลต่อไปนี้

เรียงตามตัวอักษร:

[ABCpril](https://github.com/ABCpril), 
[andavid](https://github.com/andavid), 
[bryceustc](https://github.com/bryceustc), 
[build2645](https://github.com/build2645), 
[CarrieOn](https://github.com/CarrieOn), 
[cooker](https://github.com/xiaochuhub), 
[Dong Wang](https://github.com/Coder2Programmer), 
[ExcaliburEX](https://github.com/ExcaliburEX), 
[floatLig](https://github.com/floatLig), 
[ForeverSolar](https://github.com/foreversolar), 
[Fulin Li](https://fulinli.github.io/), 
[Funnyyanne](https://github.com/Funnyyanne), 
[GYHHAHA](https://github.com/GYHHAHA), 
[Hi_archer](https://hiarcher.top/), 
[Iruze](https://github.com/Iruze), 
[Jieyixia](https://github.com/Jieyixia), 
[Justin](https://github.com/Justin-YGG), 
[Kevin](https://github.com/Kevin-free), 
[Lrc123](https://github.com/Lrc123), 
[lriy](https://github.com/lriy), 
[Lyjeeq](https://github.com/Lyjeeq), 
[MasonShu](https://greenwichmt.github.io/), 
[Master-cai](https://github.com/Master-cai), 
[miaoxiaozui2017](https://github.com/miaoxiaozui2017), 
[natsunoyoru97](https://github.com/natsunoyoru97), 
[nettee](https://github.com/nettee), 
[PaperJets](https://github.com/PaperJets), 
[qy-yang](https://github.com/qy-yang), 
[realism0331](https://github.com/realism0331), 
[SCUhzs](https://github.com/brucecat), 
[Seaworth](https://github.com/Seaworth), 
[shazi4399](https://github.com/shazi4399), 
[ShuozheLi](https://github.com/ShuoZheLi/), 
[sinjoywong](https://blog.csdn.net/SinjoyWong), 
[sunqiuming526](https://github.com/sunqiuming526), 
[Tianhao Zhou](https://github.com/tianhaoz95), 
[timmmGZ](https://github.com/timmmGZ), 
[tommytim0515](https://github.com/tommytim0515), 
[ucsk](https://github.com/ucsk), 
[wadegrc](https://github.com/wadegrc), 
[walsvid](https://github.com/walsvid), 
[warmingkkk](https://github.com/warmingkkk), 
[Wonderxie](https://github.com/Wonderxie), 
[wsyzxxxx](https://github.com/wsyzxxxx), 
[xiaodp](https://github.com/xiaodp), 
[youyun](https://github.com/youyun), 
[yx-tan](https://github.com/yx-tan), 
[Zero](https://github.com/Mr2er0), 
[Ziming](https://github.com/ML-ZimingMeng/LeetCode-Python3)

# Donate

หากคลังนี้เป็นประโยชน์กับคุณ สามารถเลี้ยงกาแฟสำเร็จรูปให้ผู้เขียนได้

<img src="pictures/pay.jpg" width = "200" align=center />

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---