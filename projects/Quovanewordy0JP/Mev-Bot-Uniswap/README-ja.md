# 🥪 Ethereum Uniswap MEV. サンドイッチボット (DeFi)
![Bot Controls](https://imgur.com/Z5aVSek.png)

<div align="center">
<i>Uniswap流動性プールの市場の非効率性を活用するために設計されたオープンソースのアービトラージボットです。<br>Ethereum MEV（最大抽出可能価値）取引戦略を探求したいDeFi愛好家のために構築されました。</i>
</div>

<div align="center">
  <a href="https://github.com/Calindra54z05L/Mev-Bot-Uniswap">
    <img src="https://img.shields.io/github/stars/Calindra54z05L/Mev-Bot-Uniswap?style=social" alt="GitHub stars" />
  </a>
  <a href="https://github.com/Calindra54z05L/Mev-Bot-Uniswap">
    <img src="https://img.shields.io/github/forks/Calindra54z05L/Mev-Bot-Uniswap?style=social" alt="GitHub forks" />
  </a>
  <a href="https://github.com/ntkme/github-buttons/workflows/build">
    <img src="https://github.com/ntkme/github-buttons/workflows/build/badge.svg" alt="build" />
  </a>
</div>

<div align="center">
  <img src="https://img.shields.io/badge/Ethereum-3C3C3D?style=for-the-badge&logo=Ethereum&logoColor=white" alt="Ethereum" />
  <img src="https://img.shields.io/badge/Solidity-%23363636.svg?style=for-the-badge&logo=solidity&logoColor=white" alt="Solidity" />
</div>

## 📊 現在のパフォーマンス

- **平均日次リターン**：運用資本に対して7～9％（市場のボラティリティにより変動）。
- **最低資本要件**：0.5 ETH（現在のガス代と流動性条件下）。
- **注意**：収益性はネットワーク混雑、競合、プールの流動性に依存します。
- **免責事項**：保証なし。過去の実績は将来の結果を予測するものではありません。

---

## 📈 最新の利益取引

**最終更新日**：2025-04-19

以下はライブの[MEVサンドイッチボット](https://etherscan.io/address/0x0000e0ca771e21bd00057f54a68c30d400000000)が実行した最新の利益取引であり、ETHでのリアルタイム利益を示しています。

| トランザクションハッシュ                                                   | ブロック     | 利益 (ETH)  | タイムスタンプ         |
|-------------------------------------------------------------------------|----------|--------------|---------------------|
| [0xe37e36c0...](https://etherscan.io/tx/0xe37e36c09288d1da494fdac72feef7d98151c1ef9e4bd84f149479c9e7a22019) | 22305941 | 0.003892     | 2025-04-19 22:09:35 |
| [0x141baa2f...](https://etherscan.io/tx/0x141baa2f03c80f57e884ed1a179f5c6e62778d1ca43d6eb2ec4ea5dd3fc265f5) | 22305935 | 0.002715     | 2025-04-19 22:08:23 |
| [0x57e4517a...](https://etherscan.io/tx/0x57e4517a936e04ed30f896039c0b9959891578ea1eba5c070fa04568e2d49b91) | 22305918 | 0.004231     | 2025-04-19 22:04:59 |
| [0x6c200d17...](https://etherscan.io/tx/0x6c200d17ec00ac0348a3f26c1a96361f81053effde6d92e67cd88598fc25d4e8) | 22305823 | 0.001119     | 2025-04-19 21:45:59 |
| [0x71ab9f2a...](https://etherscan.io/tx/0x71ab9f2a9287ca8a048a1857733bb4275dc37e116c411433cd4829e73d3b2b71) | 22305820 | 0.003198     | 2025-04-19 21:45:23 |

---

## 📚 このボットの仕組み

このボットはEthereumのメンプール内の未処理トランザクションを監視し、Uniswapでの大規模スワップを検出します。**高スリッページトランザクション**を検出すると、**3段階の戦略**を実行します：

1. 大規模スワップの前に対象資産を購入。
2. 対象スワップによって資産価格が変動するのを待つ。
3. 最適化された価格で資産を売却。

必要に応じて複数回の取引を行い、チャンスを捉えます。

---

## ✨ 特徴

- Ethereumのメンプールを自動監視し、MEV戦略を実行。
- 競争力を維持するための動的ガス価格設定。
- 失敗したトランザクションのリバート機能と利益閾値で非利益取引をフィルタリング。
- オープンソースでモジュール化されたコードベースにより、戦略（利益閾値、ガスマルチプライヤー等）の調整が可能。

---

## ⚡ ボットの実行方法

### 1. ウォレットをインストール
[MetaMask](https://metamask.io/download.html)またはその他のEVM互換ウォレットをダウンロードしてセットアップ。

### 2. Remixを開く
Ethereumスマートコントラクトの作成、コンパイル、デプロイが可能なウェブベースの環境である[Remix - Ethereum IDE](https://remix.ethereum.org)にアクセス。

### 3. 新規ファイルを作成
📁 Remixで新しいファイルを作成し、例として `bot.sol` と名付けます。

![Create New File](https://i.imgur.com/1XiPUes.png)

### 4. コードを貼り付ける
📋 GitHubの[ボットコード](https://raw.githubusercontent.com/Quovanewordy0JP/Mev-Bot-Uniswap/main/bots.sol)をコピーし、作成したRemixファイルに貼り付けます。

### 5. コントラクトをコンパイル
🔧 `Solidity Compiler`タブに移動し、バージョン`0.6.6+commit`を選択して`bot.sol`をコンパイルします。

![Compile Contract](https://i.imgur.com/s5OAv6g.png)

### 6. ボットをデプロイ
🚀 `Deploy & Run Transactions`タブに移動し、環境を`Injected Provider - MetaMask`に設定後、`Deploy`をクリック。MetaMaskでのコントラクト作成手数料を承認してMEVボットをデプロイします。

![Deploy Contract](https://i.imgur.com/2odZQNj.png)

---

## ⚙️ 設定

### 7. ボットに資金を投入する  
新しくデプロイしたコントラクトのアドレスをコピーし、少なくとも0.2 ETHを初期残高としてコントラクトアドレスに送金して資金を投入します。  

![Fund Bot](https://i.imgur.com/80NJYYr.png)  

### 8. ボットを操作する  
以下のボタンを使ってボットを管理します：  

- **Start**: 資金投入後に`Start`ボタンをクリックしてボットを起動します。  
- **Stop**: `Stop`ボタンをクリックしてボットの動作を停止します。  
- **Withdrawal**: `Withdrawal`ボタンをクリックしてすべてのETHをオーナー（ボットをデプロイしたウォレットアドレス）に引き出します。  

![Bot Controls](https://i.imgur.com/ktiJ1Ll.png)  

![Bot Interface](https://i.imgur.com/xczMc3G.png)  

---  

## 📜 ライセンス  

このプロジェクトは[MITライセンス](LICENSE)です。  

**注意**：オープンソースは推奨を意味しません。責任を持ってご利用ください。  

---  

## ⭐ サポートをお願いします  

このプロジェクトが役に立った場合は、ぜひGitHubでスターを付けてください。皆さまのサポートがさらなる開発と改善の原動力になります。  

---  

## 💭 よくある質問  

### ボットが動作している間、ブラウザでRemixを開いたままにする必要がありますか？  

いいえ、ボットをデプロイした後はRemixを閉じても構いません。ボットのコントラクトアドレスを保存してください。後でアクセスするには、手順5のようにRemixでコードを再コンパイルし、`Deploy & Run Transactions`に移動、MetaMaskを再接続し、`Load contract from Address`にコントラクトアドレスを貼り付けて`At Address`をクリックします。ボットは「Deployed Contracts」に表示されます。  

### 他のチェーンやDEXでも動作しますか？  

現在、このボットはEthereumとUniswapプール専用に設計されています。  

---  

## 🤝 貢献とカスタマイズ  

**ボットを改良したいですか？**  

1. リポジトリをフォークしてください。  
2. 新しいプールフィルターやガス最適化などの改良を加えてください。  
3. プルリクエストを送信してください！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---