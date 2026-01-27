# cmyflix
*Netflixクローン、今度はC言語で！*

cmyflixは私のオリジナル![Myflix](https://github.com/farfalleflickan/Myflix/)をC言語で完全に書き直したもので、元の約30倍**高速**でほぼすべての機能を保持しています。

cmyflixはPlex、streama、Embyのような、NAS向けのややシンプルで軽量な「DIY Netflix」を目指しており、特にRaspberry Pi/Odroidなどのエコシステム向けです。派手さを**意図**も**設計**もしていません（ハードウェアがあり多機能を求めるなら他のソリューションをお勧めします :) ）が、最低限の見た目の良さ、高速さ、使いやすさを目指しています。プログラムはファイルの場所とメタデータを格納するjsonデータベースを作成し、これらのデータベースを使って任意のウェブサーバーから配信可能な静的ウェブページを生成します！    

以下のライブラリに大きな感謝を：![cwalk](https://github.com/likle/cwalk)、![cjson](https://github.com/DaveGamble/cJSON)。  
cmyflixのファイルをパスワード保護したい場合は、![こちら](https://github.com/farfalleflickan/JSONlogin)を参照してください！  

私の仕事を気に入っていただけたら、寄付をお願いします :)  
[<img src="https://raw.githubusercontent.com/andreostrovsky/donate-with-paypal/master/dark.svg" alt="donation" width="150"/>](https://www.paypal.com/donate?hosted_button_id=YEAQ4WGKJKYQQ)

# スクリーンショット:  
テレビ番組ページ
![TV shows](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/ec53e53f252f908bc8bac7f8c4486790.jpg)   

テレビ番組シーズン/エピソードモーダル
![TV show episodes](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/fb31129a22d81b732ce88f02cae27fea.jpg)  


テレビ番組エピソードプレイヤー
![TV show episode player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/102b3df4924efeae7476d6ceee79bec9.png)

映画ページ
![Movies](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/d4271907a9af78d8dd84f3941ca1e56a.jpg)  

映画プレイヤー
![Movies player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/2eb41c935d1c11e19adb66466bcdf97e.png)

# コンパイル方法:
makeを実行してコンパイルするだけです。必要なライブラリは（Ubuntuの場合）`libbsd-dev libcjson-dev libcurl4-openssl-dev`です。

# インストール方法:
ソースからmake installでインストールするか、リリースタブから事前コンパイル済みパッケージを使用してください。

注意：事前コンパイル済みの`deb`ファイルはデフォルトの`libcurl4-openssl-dev`バックエンドでビルドされています。

# 実行に必要なもの:
cmyflixはlibcjson(>=1.7.15)、libcurl(>=7.68)、imagemagick、ffmpeg、およびTMDBのAPIキーを使用します。なお、cmyflixはHTML5とその対応フォーマットの使用により、`mp4`、`mkv`、`ogv`、`webm`ファイルを検索します。

# 設定と使用法：
まず、cmyflixはバイナリと同じフォルダにある`cmyflix.cfg`を最初に探し、次に`$HOME/.config/cmyflix/`、最後に`/etc/cmyflix/`を探します。フォルダ`html`とその内容についても同様です。

詳細なオプションや情報については、設定ファイルを参照するか、`--help`を渡して呼び出せるヘルプメニューを参照してください。

# フォルダ構成の期待値
cmyflixはすべてが整理されたフォルダにあることを期待する点で少し厳格です。
テレビ番組の場合、各ショーはそれぞれのフォルダにあり、各シーズンごとにサブフォルダがあり（その他は「Season.Extras」）、例：`/path/to/files/Name.of.TV.show/Season.1/Name.Of.TV.show.S01E01.mp4`。
映画の場合は、理想的には各映画ごとにサブフォルダがあり、例：`/path/to/files/Name.of.Movie/Name.Of.Movie.mp4`。複数の映画が同じサブフォルダに入っていても技術的には可能で、例：`/path/to/files/Movies/Star.Wars/Revenge.of.The.Sith.mp4`および`/path/to/files/Movies/Star.Wars/Empire.Strikes.Back.mp4`。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---