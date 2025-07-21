<translate-content># winjs-plugin-security

WinJS プロジェクトにセキュリティ強化機能を提供するプラグインで、主に SRI（Subresource Integrity）属性の生成に使用されます。

## 機能特徴

- HTML ファイル内の `<script>` および `<link>` タグに自動で SRI 属性を生成
- SHA-256、SHA-384、SHA-512 ハッシュアルゴリズムをサポート（設定可能）
- SRI を正常に機能させるために自動で `crossorigin="anonymous"` 属性を追加
- 本番環境のみ有効で、開発環境では自動的にスキップ

## インストール
</translate-content>
```bash
pnpm add @winner-fed/plugin-security
```
## 使用方法

あなたの `.winrc.ts` 設定ファイルにプラグインの設定を追加してください：


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## 配置オプション

### `sri`

- **タイプ**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **デフォルト値**: 手動設定が必要
- **説明**: SRI（サブリソース整合性）機能の有効化およびオプションのハッシュアルゴリズム設定

`true` または `{}` に設定すると、プラグインは以下を実行します：

1. ビルド後の HTML ファイルをスキャン
2. `src` 属性を持つすべての `<script>` タグに `integrity` 属性を追加
3. `href` 属性を持つすべての `<link>` タグに `integrity` 属性を追加
4. `crossorigin="anonymous"` 属性を自動で追加（存在しない場合）

ハッシュアルゴリズムはオブジェクトで指定することも可能です：


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### 出力 HTML（SRI 有効時）


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## 安全说明

SRI（サブリソースインテグリティ）は、ブラウザが取得したリソース（例えばCDNから取得したリソース）が悪意のある改ざんを受けていないか検証するためのセキュリティ機能です。  
ブラウザはリソースを読み込む際に、そのハッシュ値を計算し、`integrity` 属性で指定されたハッシュ値と比較します。  
ハッシュ値が一致しない場合、ブラウザはリソースの読み込みを拒否します。

`<script>` タグの場合、コードの実行が拒否されます。  
CSSリンクの場合、スタイルの読み込みが拒否されます。

SRIの詳細については、[Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity)をご覧ください。

## 注意事項

1. このプラグインは本番ビルド時のみ有効で、開発環境では自動的にスキップされます。  
2. リソースファイルがビルド出力ディレクトリでアクセス可能であることを確認してください。  
3. `integrity` 属性は `crossorigin` 属性と組み合わせて使用する必要があります。

## ライセンス

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---