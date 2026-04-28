# yt-dlp-rajiko

yt-dlp用の改良された[radiko.jp](https://radiko.jp)抽出プラグイン（高速かつエリアフリー）

<p>yt-dlp-rajikoを使うと、<a href="https://radiko.jp">radiko.jp</a>の日本のラジオ番組をVPNなしで<a href="https://github.com/yt-dlp/yt-dlp">yt-dlp</a>を使ってダウンロードできます。
高速にダウンロードでき、世界中どこからでも参加局*の番組が利用可能です。<br>
<small>*NHKは除くが、NHKは<a href="https://www.nhk.or.jp/radio/">独自のサイト</a>があり、
yt-dlp本体でサポートされています</small></p>

<p>個人アーカイブ用であり商用利用は禁止です。可能であればradikoプレミアムにご加入ください。<br>
<small>(これはフリーソフトウェアなので強制ではなくお願いです。ただradikoが継続できるように加入を推奨します)<br>
(また、timefree30プランを取得すればyt-dlpで利用可能です :P)
</small></p>

### [日本語  🇯🇵](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## インストール

[プラグインバンドルをダウンロード](https://427738.xyz/yt-dlp-rajiko/dl/yt_dlp_rajiko-latest.bundle.zip) または `pip install yt-dlp-rajiko`

<p>yt-dlp 2025.02.19以降が必要です。</p>

<p>yt-dlpをpipでインストールしている場合は上記のpipコマンドを使用してください。
<code>pipx</code>でインストールしている場合は、
<code>pipx inject yt-dlp yt-dlp-rajiko</code>でyt-dlpの環境にプラグインをインストールしてください。</p>

<p>.exeやバイナリ、その他の方法でインストールしている場合は、
バンドルをダウンロードして以下のいずれかの場所に配置してください：</p>

<ul>
	<li><code>%appdata%\yt-dlp\plugins\</code>（Windowsの場合）</li>
	<li><code>~/.config/yt-dlp/plugins/</code>（LinuxおよびMacの場合）</li>
	<li><code>yt-dlp.exe</code>の隣にある<code>yt-dlp-plugins</code>フォルダ <a href="https://427738.xyz/yt-dlp-rajiko/i/installation-pluginsfolder2.png">（このように）</a><br>
	<li><a href="https://github.com/yt-dlp/yt-dlp#installing-plugins">yt-dlpドキュメント</a>に記載されているその他の場所</li>
</ul>

<p>これらのフォルダが存在しない場合は作成する必要があります。<br>
<b>zipファイルを解凍する必要はありません。</b></p>


<p><code>yt-dlp -v</code> を実行して、<code>[debug] Extractor Plugins:</code> または <code>[debug] Plugin directories:</code> の行が表示されるかを確認することで、正しくインストールされているかをチェックできます。 <a href="https://427738.xyz/yt-dlp-rajiko/i/plugincheck.png">(このように)</a>
</p>

yt-dlp プラグインに関する詳細は [yt-dlp のドキュメント](https://github.com/yt-dlp/yt-dlp#plugins) をご覧ください。

## 詳細情報

[詳細はウェブサイトをご覧ください](https://427738.xyz/yt-dlp-rajiko/)（使い方、連絡方法など）

[日本語訳もあります](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## このリポジトリについて

ここはソースコードとバグトラッカーがある場所です。情報の大部分はウェブサイトにあります。

一般的にはリリース版を使用してください。
`master` ブランチは通常動作しますが、実験的と見なされ、バグがある可能性があります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---