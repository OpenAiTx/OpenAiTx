# unicode-animations

Unicodeスピナーアニメーションを生のフレームデータとして提供 — 依存関係なし、どこでも動作。

## デモ

全18種類のスピナーがライブで動く様子を見る:

```bash
npx unicode-animations --web     # open browser demo
npx unicode-animations           # cycle through all in terminal
npx unicode-animations helix     # preview a specific spinner
npx unicode-animations --list    # list all spinners
```

## インストール

```bash
npm install unicode-animations
```

## クイックスタート

```js
// ESM
import spinners from 'unicode-animations';

// CJS
const spinners = require('unicode-animations');
```

各スピナーは `{ frames: string[], interval: number }` オブジェクトです。

## 例

### CLIツール — 非同期作業中のスピナー

```js
import spinners from 'unicode-animations';

const { frames, interval } = spinners.braille;
let i = 0;

const spinner = setInterval(() => {
  process.stdout.write(`\r\x1B[2K  ${frames[i++ % frames.length]} Deploying to production...`);
}, interval);

await deploy();

clearInterval(spinner);
process.stdout.write('\r\x1B[2K  ✔ Deployed.\n');
```

### 再利用可能なスピナー補助ツール

```js
import spinners from 'unicode-animations';

function createSpinner(msg, name = 'braille') {
  const { frames, interval } = spinners[name];
  let i = 0, text = msg;
  const timer = setInterval(() => {
    process.stdout.write(`\r\x1B[2K  ${frames[i++ % frames.length]} ${text}`);
  }, interval);

  return {
    update(msg) { text = msg; },
    stop(msg) { clearInterval(timer); process.stdout.write(`\r\x1B[2K  ✔ ${msg}\n`); },
  };
}

const s = createSpinner('Connecting to database...');
const db = await connect();
s.update(`Running ${migrations.length} migrations...`);
await db.migrate(migrations);
s.stop('Database ready.');
```

### マルチステップパイプライン

```js
import spinners from 'unicode-animations';

async function runWithSpinner(label, fn, name = 'braille') {
  const { frames, interval } = spinners[name];
  let i = 0;
  const timer = setInterval(() => {
    process.stdout.write(`\r\x1B[2K  ${frames[i++ % frames.length]} ${label}`);
  }, interval);
  const result = await fn();
  clearInterval(timer);
  process.stdout.write(`\r\x1B[2K  ✔ ${label}\n`);
  return result;
}

await runWithSpinner('Linting...', lint, 'scan');
await runWithSpinner('Running tests...', test, 'helix');
await runWithSpinner('Building...', build, 'cascade');
await runWithSpinner('Publishing...', publish, 'braille');
```

### React コンポーネント

```jsx
import { useState, useEffect } from 'react';
import spinners from 'unicode-animations';

function Spinner({ name = 'braille', children }) {
  const [frame, setFrame] = useState(0);
  const s = spinners[name];

  useEffect(() => {
    const timer = setInterval(
      () => setFrame(f => (f + 1) % s.frames.length),
      s.interval
    );
    return () => clearInterval(timer);
  }, [name]);

  return <span style={{ fontFamily: 'monospace' }}>{s.frames[frame]} {children}</span>;
}

// Usage: <Spinner name="helix">Generating response...</Spinner>
```

### ブラウザー — ステータスインジケーター

```js
import spinners from 'unicode-animations';

const el = document.getElementById('status');
const { frames, interval } = spinners.orbit;
let i = 0;

const spinner = setInterval(() => {
  el.textContent = `${frames[i++ % frames.length]} Syncing...`;
}, interval);

await sync();
clearInterval(spinner);
el.textContent = '✔ Synced';
```
## すべてのスピナー

### クラシック点字

| 名前 | プレビュー | インターバル |
|------|---------|----------|
| `braille` | `⠋ ⠙ ⠹ ⠸ ⠼ ⠴ ⠦ ⠧ ⠇ ⠏` | 80ms |
| `braillewave` | `⠁⠂⠄⡀` → `⠂⠄⡀⢀` | 100ms |
| `dna` | `⠋⠉⠙⠚` → `⠉⠙⠚⠒` | 80ms |

### グリッドアニメーション（点字）

| 名前 | フレーム数 | インターバル |
|------|--------|----------|
| `scan` | 10 | 70ms |
| `rain` | 12 | 100ms |
| `scanline` | 6 | 120ms |
| `pulse` | 5 | 180ms |
| `snake` | 16 | 80ms |
| `sparkle` | 6 | 150ms |
| `cascade` | 12 | 60ms |
| `columns` | 26 | 60ms |
| `orbit` | 8 | 100ms |
| `breathe` | 17 | 100ms |
| `waverows` | 16 | 90ms |
| `checkerboard` | 4 | 250ms |
| `helix` | 16 | 80ms |
| `fillsweep` | 11 | 100ms |
| `diagswipe` | 16 | 60ms |

## カスタムスピナー

グリッドユーティリティを使って、自分だけの点字スピナーを作成しましょう：


```js
import { gridToBraille, makeGrid } from 'unicode-animations';

// Create a 4-row × 4-col grid
const grid = makeGrid(4, 4);
grid[0][0] = true;
grid[1][1] = true;
grid[2][2] = true;
grid[3][3] = true;

console.log(gridToBraille(grid)); // diagonal braille pattern
```

`makeGrid(rows, cols)` returns a `boolean[][]`. Set cells to `true` to raise dots. `gridToBraille(grid)` converts it to a braille string (2 dot-columns per character).

## API

### `Spinner`

```ts
interface Spinner {
  readonly frames: readonly string[];
  readonly interval: number;
}
```

### `'unicode-animations'` からのエクスポート

| エクスポート | 型 |
|--------|------|
| `default` / `spinners` | `Record<BrailleSpinnerName, Spinner>` |
| `gridToBraille(grid)` | `(boolean[][]) => string` |
| `makeGrid(rows, cols)` | `(number, number) => boolean[][]` |
| `Spinner` | TypeScript インターフェース |
| `BrailleSpinnerName` | 18種類のスピナー名のユニオン型 |

### `'unicode-animations/braille'` からのエクスポート

上記と同様 — メインエントリポイントはbrailleモジュールの全てを再エクスポートします。

## ライセンス

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---