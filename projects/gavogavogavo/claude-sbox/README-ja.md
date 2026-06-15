# claude-sbox

[Claude Code](https://code.claude.com) スキルで、Unityのパターンに頼らずに、慣用的な [s&box](https://sbox.game) コード（C# コンポーネント、Razor UI、物理演算、ネットワーキング）を書く方法をClaudeに教えます。

s&boxはFacepunchのSource 2ゲームエンジンで、C#のスクリプトレイヤーを備えています。そのAPI、ライフサイクル、ネットワーキングモデルはUnityとは*全く異なり*、そのためClaudeはしばしば幻覚を起こします：`void Start()`、Unityの意味での`GetComponent<T>()`、`Physics.Raycast`、`[SerializeField]`、`StartCoroutine` — これらはすべてs&boxでは誤りです。このスキルはs&boxコードを書いているときにロードされ、Claudeをエンジンのエクスポートされたスキーマで検証された正しいAPIへと誘導します。

---

## インストール

**個人用（すべてのプロジェクトで利用可能）：**

```bash
mkdir -p ~/.claude/skills
git clone https://github.com/gavogavogavo/claude-sbox ~/.claude/skills/sbox
```

**プロジェクトローカル（このゲームのみ）：**

```bash
cd my-sbox-game
mkdir -p .claude/skills
git clone https://github.com/gavogavogavo/claude-sbox .claude/skills/sbox
```

Claude Codeはスキルファイルの変更をライブで検出します。ただし、`~/.claude/skills/`がClaude Codeセッション開始時に存在しなかった場合（つまり、これが初めてのパーソナルスキルの場合）、`mkdir`の後に**Claude Codeを再起動**する必要があります。そうしないとウォッチャーが新しいディレクトリを登録しません。

> **なぜ`sbox`（`claude-sbox`ではなく）というディレクトリ名なのか？** `SKILL.md`のフロントマターの`name:`が`sbox`であり、これが`/sbox`というスラッシュコマンドになります。`~/.claude/skills/sbox/`にクローンすることで、ディレクトリ名と呼び出し名を同期させています。

---

## 動作確認

任意のClaude Codeセッションで以下を入力してください：

```
/sbox
```
ルーターが読み込まれます。あるいは、トリガーとなる質問をして、クロードが参照ファイルを探す様子を見てください：


```
How do I write a networked player controller in s&box?
```

Claudeは回答する前に`references/core-concepts.md`、`references/networking.md`、および/または`references/patterns-and-examples.md`を開くべきです — *これがスキルが機能している合図です*。ファイルを読まずに記憶から回答する場合は何か問題があります；詳しくは[Troubleshooting](#troubleshooting)を参照してください。

---

## 内容

`SKILL.md`はリファレンスではなくルーターです。Claudeが詳細を必要とする場合、以下のいずれかを開きます：

| ファイル | 行数 | 対象範囲 |
|---|---:|---|
| `SKILL.md` | 271 | ルーター + Unity→s&box変換表 + 10のルール |
| `references/core-concepts.md` | 575 | シーンシステム、GameObjects、コンポーネント、ライフサイクル、`[Property]`、プレハブ、シーンイベント、`GameObjectSystem`、非同期 |
| `references/components-builtin.md` | 729 | 144の組み込みコンポーネント — レンダラー、リジッドボディ、コライダー、`CharacterController`、`CameraComponent`、ライト、オーディオ、UI、`NavMeshAgent`、`PlayerController`、パーティクル、ポストプロセッシング |
| `references/ui-razor.md` | 834 | Razorパネル、SCSS、フレックスボックスレイアウト、組み込みコントロール（Button / TextEntry / DropDown / SliderControl / VirtualGrid）、`NavigationHost`、トランジション |
| `references/networking.md` | 672 | ロビー、`Connection`、`[Sync]` + `SyncFlags`、`[Rpc.Broadcast/Host/Owner]`、所有権、`INetworkListener`、`INetworkSpawn`、スナップショットデータ、専用サーバー |
| `references/input-and-physics.md` | 597 | 入力システム、`SceneTrace`ビルダーAPI、`PhysicsWorld`、衝突、`Vector3`/`Rotation`/`Angles`/`Transform`/`BBox`/`Ray`/`Capsule`、`TimeSince`/`TimeUntil`、`Gizmo.Draw` |
| `references/api-schema-core.md` | 930 | 最もよく使われる約50タイプの完全な公開シグネチャ |
| `references/api-schema-extended.md` | 2753 | 名前空間別に整理された738の追加タイプのインデックス |
| `references/patterns-and-examples.md` | 1056 | 10の完全な実行可能な例（Health + `IDamageable`、一人称`CharacterController`、ヒットスキャン武器、ネットワークゲームマネージャー、`[Sync]`/RPC付きプレイヤー、Razor HUD、リジッドボディグレネード、NavMeshAgent AIステートマシン、プレハブスポナー、トリガーピックアップ） |

すべてのリファレンスファイル内のAPIシグネチャは、s&boxエンジンのエクスポートされたスキーマ（`raw/api-schema.json`、61の名前空間に渡る約1,850タイプ）と照合されています。スキーマが唯一の真実のソースです — ドキュメントとスキーマが異なる場合はスキーマが優先されます。

---

## 更新

```bash
cd ~/.claude/skills/sbox
git pull
```

Claude Codeは、現在のセッション内で変更されたスキルファイルを再読み込みします。

---

## ソースからの再生成

エンドユーザーには不要です。新しいs&boxエンジンに対してリファレンスファイルを再構築したいメンテナ向け：

```bash
./scripts/fetch-raw.sh         # clones Facepunch/sbox-docs into raw/sbox-docs
# manually place raw/api-schema.json (see docs/DESIGN.md)
node scripts/build_extended.js # rebuilds references/api-schema-extended.md
```
完全なビルドワークフロー — 各リファレンスファイルのキュレーション方法、スキーマ検証ループ、および既知の注意点 — は [`docs/DESIGN.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/DESIGN.md) と [`docs/BUILD_LOG.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/BUILD_LOG.md) に記録されています。

---

## トラブルシューティング

**Claudeがs&boxの質問でスキルを起動しない。**  
ディレクトリが `~/.claude/skills/sbox/` にあるか確認してください（`~/.claude/skills/claude-sbox/` や `~/.claude/skills/sbox-skill/` ではありません）。ディレクトリ名は `name:` フロントマターと一致している必要があります。明示的に `/sbox` を使ってインストール済みか確認することも試してください。

**Claudeがリファレンスファイルを開かずにs&boxの質問に答える。**  
これはUnityの筋肉記憶から幻覚を見ていることを意味します — このスキルが防ぐべき正確な失敗です。スキルが読み込まれていないか、説明が一致していません。`/sbox` で強制読み込みし、再度質問してみてください。

**スキルは読み込まれているが、コンパイルできないAPIを提案する。**  
提案されたコードとClaudeがそれがどのリファレンスファイルから来たと主張しているかを含めてIssueを開いてください。出荷されているすべてのシグネチャはスキーマ検証済みであるべきです。回帰はバグです。

**`~/.claude/skills/claude-sbox/` にクローンしたけど、次は？**  
ディレクトリ名を `sbox` に変更するか、`SKILL.md` の `name:` フィールドを `claude-sbox` に合わせて変更してください。プロジェクトローカルインストールでも同様です。

---

## コントリビューション

IssueやPRは歓迎します。提出前に：

- **新しいAPIシグネチャを `raw/api-schema.json` に対して検証してください。** スキーマが真実の基準です。スキーマにメソッドが見つからなければ追加しないでください。  
- **`SKILL.md` を500行以下に保ってください。** これはルーターです — 参照の詳細は `references/` にあります。`SKILL.md` だけでリファレンスファイルを開かずにs&boxの質問に答えられるなら、ルーターに詳細が多すぎます。  
- **ユーザーに見える変更があれば `CHANGELOG.md` を更新してください。**  
- **既存の文体を合わせてください** — 簡潔で密度が高く、チュートリアル読者ではなくClaude向けに書かれています。

---

## ライセンス

MIT — [LICENSE](LICENSE) を参照してください。

このプロジェクトはFacepunchやAnthropicとは提携も承認もされていません。s&boxはFacepunch Studiosの製品です。Claude CodeとAgent SkillsフォーマットはAnthropicの製品です。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---