# unicode-animations

Unicode 旋转动画作为原始帧数据 — 无依赖，适用于所有环境。

## 演示

查看所有 18 个旋转动画的实时演示：

```bash
npx unicode-animations --web     # open browser demo
npx unicode-animations           # cycle through all in terminal
npx unicode-animations helix     # preview a specific spinner
npx unicode-animations --list    # list all spinners
```

## 安装

```bash
npm install unicode-animations
```

## 快速开始

```js
// ESM
import spinners from 'unicode-animations';

// CJS
const spinners = require('unicode-animations');
```
每个旋转器都是一个 `{ frames: string[], interval: number }` 对象。

## 示例

### CLI 工具 — 异步工作期间的旋转器


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

### 可重用的加载动画辅助工具

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

### 多步骤管道

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

### React 组件

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

### 浏览器 — 状态指示器

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

## 所有加载指示器

### 经典盲文

| 名称 | 预览 | 间隔 |
|------|---------|----------|
| `braille` | `⠋ ⠙ ⠹ ⠸ ⠼ ⠴ ⠦ ⠧ ⠇ ⠏` | 80毫秒 |
| `braillewave` | `⠁⠂⠄⡀` → `⠂⠄⡀⢀` | 100毫秒 |
| `dna` | `⠋⠉⠙⠚` → `⠉⠙⠚⠒` | 80毫秒 |

### 网格动画（盲文）

| 名称 | 帧数 | 间隔 |
|------|--------|----------|
| `scan` | 10 | 70毫秒 |
| `rain` | 12 | 100毫秒 |
| `scanline` | 6 | 120毫秒 |
| `pulse` | 5 | 180毫秒 |
| `snake` | 16 | 80毫秒 |
| `sparkle` | 6 | 150毫秒 |
| `cascade` | 12 | 60毫秒 |
| `columns` | 26 | 60毫秒 |
| `orbit` | 8 | 100毫秒 |
| `breathe` | 17 | 100毫秒 |
| `waverows` | 16 | 90毫秒 |
| `checkerboard` | 4 | 250毫秒 |
| `helix` | 16 | 80毫秒 |
| `fillsweep` | 11 | 100毫秒 |
| `diagswipe` | 16 | 60毫秒 |

## 自定义加载指示器

使用网格工具创建您自己的盲文加载指示器：

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

### 来自 `'unicode-animations'` 的导出

| 导出 | 类型 |
|--------|------|
| `default` / `spinners` | `Record<BrailleSpinnerName, Spinner>` |
| `gridToBraille(grid)` | `(boolean[][]) => string` |
| `makeGrid(rows, cols)` | `(number, number) => boolean[][]` |
| `Spinner` | TypeScript 接口 |
| `BrailleSpinnerName` | 所有18个旋转器名称的联合类型 |

### 来自 `'unicode-animations/braille'` 的导出

与上述相同 — 主入口重新导出 braille 模块中的所有内容。

## 许可证

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---