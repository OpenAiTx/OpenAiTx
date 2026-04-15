ZenCad
======
正義の禅プログラマーのためのCADシステム  

それは何か？
-----------
ZenCad - openscadのスクリプトスタイルでジオメトリコアを使用するシステムです。
つまり、openscadのアイデア、Python言語、opencascadeの力を一つにまとめたものです。  

マニュアルと情報
----------------------
- マニュアル: [こちら](https://mirmik.github.io/zencad/).

- 記事:  
	- habr: [スクリプトによる3Dモデリングシステム ZenCad](https://habr.com/ru/post/443140/)

- コミュニティチャット（Telegram）: [https://t.me/zencad](https://t.me/zencad)

インストール
------------
### xcbのインストール
```
apt install libxcb*
```
### 共通:
Zencadは*pythonocc*と*opencascade core*(OCCT)を必要とします。初回起動後
（`zencad`または`python3 -m zencad`コマンドを入力）
ライブラリインストールユーティリティが起動します。これを使って*pythonocc*と*OCCT*のインストールが可能です。ライブラリは手動でインストールすることもできます。

```
apt install qt5-default
python3 -m pip install zencad[gui]
zencad 
# On first launch, Zenсad will ask you to download the required libraries. 
# After completing the necessary operations, close the installation utility and run the program again. 
zencad
```

### グラフィカル部分なしのインストール：
GUI部分なしでzencadをライブラリとしてインストールする：
```python3 -m pip install zencad```
```python3 -m zencad --install-occt-force```  
```python3 -m zencad --install-pythonocc-force```

### Windowsの場合:  
Windows版ZenCadには`vcredist`（Microsoft再頒布パッケージ）が必要です。  
Python3.7用に`vcredist 2015`、Python3.8以降用に`vcredist 2019`をインストールしてください。

スタンドアロン配布
-----------------------
ZenCadにはWindows用のスタンドアロン版があります。  
Windowsのプレリリース版は[releases](https://github.com/mirmik/zencad/releases)にあります。

ソースコード
---------------
メインプロジェクトリポジトリ:  
	[https://github.com/mirmik/zencad](https://github.com/mirmik/zencad)  
関連リポジトリ:  
	[https://github.com/mirmik/zenframe](https://github.com/mirmik/zenframe)  
	[https://github.com/mirmik/evalcache](https://github.com/mirmik/evalcache)  

HelloWorld
----------
```python
#!/usr/bin/env python3
#coding: utf-8

from zencad import *

model = box(200, center = True) - sphere(120) + sphere(60)

display(m)
show()
```
Result:  
![result.png](https://mirmik.github.io/zencad/images/generic/zencad-logo.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---