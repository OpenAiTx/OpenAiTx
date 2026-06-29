
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=zh-CN">簡体字中国語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=zh-TW">繁体字中国語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=ko">韓国語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=hi">ヒンディー語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=th">タイ語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=fr">フランス語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=de">ドイツ語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=es">スペイン語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=it">イタリア語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=ru">ロシア語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=pt">ポルトガル語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=nl">オランダ語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=pl">ポーランド語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=ar">アラビア語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=fa">ペルシャ語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=tr">トルコ語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=vi">ベトナム語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=id">インドネシア語</a>
        | <a href="https://openaitx.github.io/view.html?user=fadewalk&project=serenity-stock-choke&lang=as">アッサム語</
      </div>
    </div>
  </details>
</div>

# Serenity Stock Choke · A株サプライチェーン・ボトルネック銘柄選定フレームワーク

> 「**産業チェーンを上流にさかのぼり、『もし供給が止まれば、何兆円規模の産業全体が地震のような衝撃を受ける』その重要な節点を見つける——その節点にいる小型株こそ、次なる爆発的チャンスだ。**」

本SkillはRedditの伝説的人物**Serenity（@aleabitoreddit）**のサプライチェーン・ボトルネック理論をA株市場に適用し、汎用的なセクター分析フレームワークを形成しています。

---

## コアメソドロジー

### ホルムズ海峡のアナロジー

> 「ホルムズ海峡は世界の石油の咽喉だ。もし封鎖されれば、誰もが影響を受ける。しかし、もしあなたがホルムズ海峡に持分を持っていれば、あなたは価格決定権を持つことになる。」

**A株への翻訳**：どの工程がある大きなテーマの「ホルムズ」なのか？どのA株企業がそれを支配しているのか？

### 三つのコアロジック

```
① AI大爆发 / 政策驱动 / 技术跃迁
    ↓
② 上游硬件/原材料需求暴增，供应链某些环节产能跟不上
    ↓
③ 瓶颈环节掌握定价权 → 其中小盘股弹性最大
```
### Serenity 原版戦績（米国株）

| 対象 | コード | 上昇率 | ボトルネック位置付け |
|------|--------|--------|--------------------|
| AXT Inc | AXTI.US | +525%（YTD） | InP基板の世界で唯一の3社の一つ |
| Applied Optoelectronics | AAOI.US | +348%（YTD） | CPOレーザーの主要サプライヤー |
| Sivers Semiconductors | SIVE.SE | — | CPOレーザー + シリコンフォトニクス |
| X-FAB | XFAB.EU | — | 特殊プロセスのウェハファウンドリ |

---

## 6ステップ分析チェーン

| ステップ | コア課題 | アウトプット |
|----------|----------|--------------|
| 1️⃣ セクター周期の位置付け | 需要爆発 / 技術飛躍 / 供給制約？ | セクターのフェーズ |
| 2️⃣ サプライチェーンの起源調査 | ボトルネックはどの層か？ | サプライチェーン階層図 |
| 3️⃣ A株銘柄の抽出 | どの企業がこのポイントで足止めされているか？ | 4次元信号カード |
| 4️⃣ 真偽の選別 | どれが「真のボトルネック」で、どれが話題乗っかりか？ | 選別結論 |
| 5️⃣ 多空確認 | ロングシグナル vs ショートシグナル？ | シグナル対照表 |
| 6️⃣ レポート出力 | 操作提案 + リスク警告含む | 構造化レポート |

---

## 適用セクター例

電力、光モジュール/CPO、半導体装置、軍需、新エネ車、医療機器、革新医薬、農薬、OLED……**あらゆるA株セクターで分析可能**。

| セクター | ボトルネックポイント | 代表銘柄 |
|----------|------------------|-----------|
| **電力** | 特高圧変流変圧器 / スマート調整 | 国電南瑞(600406)、特変電工(600089) |
| **光モジュール/CPO** | EAMレーザー / MPOコネクタ | 源杰科技(688498)、炬光科技(688167) |
| **半導体装置** | 薄膜堆積 / リソグラフィ機コア部品 | 中微公司(688012)、北方華創(002371) |
| **軍需** | 特殊合金 / 高級複合材料 | 中簡科技(300777)、光威複材(300699) |
| **新エネ車** | カーボンナノチューブ導電剤 / 固体電池材料 | 天奈科技(688116)、当昇科技(300073) |

---

## クイックスタート


### トリガー方法

WorkBuddy 内で直接話す：

```
用 serenity-stock-choke 分析 [板块名]
例：用 serenity-stock-choke 分析军工板块
```

或者：

```
分析 [产业链] 的卡脖子机会
找 [赛道] 的瓶颈环节
帮我用 Serenity 框架分析 [板块]
```

### データツール

- **neodata-financial-search**：セクター市場、リサーチレポート、資金流向の検索
- **westock-data**：チャート分布、大口取引、信用取引、機関評価

---

## ファイル構成

```
serenity-stock-choke/
├── SKILL.md                    # 主提示词（六步推理链路 + 工具箱）
├── README.md                   # 本文件
└── references/
    └── user_guide.md          # 使用指南 + 常见板块参考表
```

---

## リスク警告

1. 本スキルは参考用であり、投資助言を構成するものではありません
2. 小型株の変動は非常に大きく、1日の値動きが20-30％になることも珍しくありません
3. A株は政策の影響を大きく受けるため、規制動向を注視する必要があります
4. サプライチェーン情報の真偽は判別が難しく、独自に検証する必要があります
5. ロジックの検証には1～3年かかる場合があり、忍耐が必要です

---

## 参考資料

- [Serenity オリジナルスキル（英語）](https://github.com/leslieyeo/aleabitoreddit-skill)
- [semiconstocks.com トラッカー](https://semiconstocks.com/zh)
- [Singularity Research Fund](https://singularityresearchfund.substack.com)
- [知乎：Serenity カクボシ理論詳細解説](https://zhuanlan.zhihu.com/p/2039362476144341796)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---