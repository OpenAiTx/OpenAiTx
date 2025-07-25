[![Banner](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/blob/main/images/WabbajackModlistsBanner2.png)](https://github.com/Omni-guides/Wabbajack-Modlist-Linux)

<p align="center"><b>Wabbajackアプリケーション -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Wabbajack-via-Proton">Proton経由でのDeck/PC上のWabbajack（推奨） ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Wabbajack-on-Linux-via-Wine">Wine経由でのLinux上のWabbajack（PCのみ）</a>
</p>

<p align="center"><b>Skyrim（Deck/PC） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Tuxborn">Tuxborn</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Licentia-DECK">Licentia DECK</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Legends-of-the-Frost">Legends of the Frost</a>
</p>

<p align="center"><b>Skyrim（PCのみ） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)">Anvil</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Nordic-Souls">Nordic Souls</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Keizaal">Keizaal</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Living-Skyrim-4">Living Skyrim 4</a>
</p>

<p align="center"><b>Enderal（Deck/PC） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Enderal:-Emissaries-of-Tux">Emissaries of Tux</a>
</p>

<p align="center"><b>Fallout（Deck/PC） -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-4:-Welcome-to-Paradise">Fallout 4: Welcome to Paradise</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-NV:-Begin-Again">Fallout New Vegas: Begin Again</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-NV:-Capital-Punishment">Fallout New Vegas: Capital Punishment</a>
</p>

<p align="center"><b>パフォーマンス -</b>
<a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Performance-Guide">Ouroborosの優れたパフォーマンスガイド</a>
</p>


<p align="center"><b>その他 -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki">ホーム</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Using-the-omni%E2%80%90guides.sh-Automation-Script">自動化スクリプト</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)">一般的なLinux</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/ENB,-Reshade-and-Community-Shaders">ENB & コミュニティシェーダー</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Troubleshooting-and-FAQ">トラブルシューティング & FAQ</a> 
</p>

---

免責事項 - 私はWabbajackグループとは一切関係なく、ただ他のゲーマーを助けたいゲーマーです。このガイドに関する支援は、メインの[公式Wabbajack Discord](https://discord.gg/wabbajack)の#unofficial-linux-helpチャンネルで受けられる場合がありますが、Discordで私に@（@omni）するのが最善かもしれません。このガイドは非公式のため、WabbajackサポートやModlist開発者からの直接の支援は非常に期待できません。

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/D1D8H8WBD)

***

## はじめに

このガイドは進行中の作業であり、主に私自身のテストと[公式Wabbajack Discord](https://discord.gg/wabbajack)の#unofficial-linux-helpチャンネルで投稿している複数のユーザーとの協力に基づいています。関係者の皆様に感謝します。フィードバックは常に歓迎します。

小さな問題に対するプルリクエストは、マージを行わずに提案された変更が適用される場合があります。修正内容を記述したIssueを作成してください。

### Wabbajackアプリケーション

現在、Wabbajack自体をLinux（SteamOS/Deckおよびその他のディストリビューション）上でProtonまたはWine経由で実行できます。Protonを使った設定が推奨される方法で、Steamが存在するプラットフォームなら同じ方法で動作するはずです。どうしても避けたい場合は、ベースのWine（Steam Deck以外）を使用できます。

### 自動設定

ガイドにはModlistを起動して動作させるための手順が含まれていますが、起動までの作業を大幅に削減することを目的とした自動Modlistインストールスクリプトも作成しました。現在、この自動化スクリプトは必要な手順の約90％を処理しています。

手順を学びたい、または調整を楽しみたい場合は、各ガイドに含まれる手順を自由に実行してください。そうでなければ、自動化スクリプトと使用方法の説明はここにあります - [Omni-Guides自動化スクリプトの使用](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Using-the-omni%E2%80%90guides.sh-Automation-Script)。

### 手動設定
各ガイドに含まれる手順は、Linux上でWabbajack Modlistsを実行するために使用されていますが、Wabbajackアプリケーション自体の実行には使われていません。現状、Linux上でWabbajack自体を実行する方法は**ありません**。これまでの最善の試みでも不安定で機能が不足しています。このガイドの手順で、Skyrim、Fallout 4、Oblivion、Fallout New VegasなどのModlistsの動作を確認しており、Steam Deck（SteamOS/Arch）、Garuda Linux（Arch）、Fedora/Nobaraなどのプラットフォームで動作していますが、ほとんどのLinuxディストリビューションで同様の手順となるはずです。

Steam Deckユーザーは、リンクされたModlist専用ガイドを参照して、選択したModlistの起動手順をステップバイステップで確認できます。

一般的なLinuxシステム（Steam Deck以外）の場合は、「PCのみ」セクションにあるものを含むModlist専用ガイドを参照するか、[一般的なLinux](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil))ガイドの手順に従うことができます。この一般的なLinuxガイドはAnvilを例として使用していますが、お好みのModlistに置き換えても手順はほぼ同じです。問題がある場合は、Modlist固有のガイドを確認して、選択したModlistの実行を助ける追加手順があるかもしれません。

最後に、Modlist開発者の方で私にテストを依頼したい場合は、ぜひお知らせください！ゲームを楽しみましょう！

***


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---