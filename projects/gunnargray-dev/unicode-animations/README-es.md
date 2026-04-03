# animaciones-unicode

Animaciones de spinner Unicode como datos de cuadros en bruto — sin dependencias, funciona en todas partes.

## Demostración

Vea los 18 spinners animándose en vivo:

```bash
npx unicode-animations --web     # open browser demo
npx unicode-animations           # cycle through all in terminal
npx unicode-animations helix     # preview a specific spinner
npx unicode-animations --list    # list all spinners
```
## Instalar


```bash
npm install unicode-animations
```
## Inicio rápido


```js
// ESM
import spinners from 'unicode-animations';

// CJS
const spinners = require('unicode-animations');
```

Cada spinner es un objeto `{ frames: string[], interval: number }`.

## Ejemplos

### Herramienta CLI — spinner durante trabajo asíncrono

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
### Ayudante reutilizable para spinner


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
### Canalización de múltiples pasos


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

### Componente de React

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

### Navegador — indicador de estado

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

## Todos los spinners

### Braille clásico

| Nombre | Vista previa | Intervalo |
|------|---------|----------|
| `braille` | `⠋ ⠙ ⠹ ⠸ ⠼ ⠴ ⠦ ⠧ ⠇ ⠏` | 80ms |
| `braillewave` | `⠁⠂⠄⡀` → `⠂⠄⡀⢀` | 100ms |
| `dna` | `⠋⠉⠙⠚` → `⠉⠙⠚⠒` | 80ms |

### Animaciones de cuadrícula (braille)

| Nombre | Cuadros | Intervalo |
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

## Spinners personalizados

Crea tus propios spinners de braille usando las utilidades de cuadrícula:

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
### Exportaciones de `'unicode-animations'`

| Exportación | Tipo |
|-------------|------|
| `default` / `spinners` | `Record<BrailleSpinnerName, Spinner>` |
| `gridToBraille(grid)` | `(boolean[][]) => string` |
| `makeGrid(rows, cols)` | `(number, number) => boolean[][]` |
| `Spinner` | Interfaz de TypeScript |
| `BrailleSpinnerName` | Tipo unión de los 18 nombres de spinner |

### Exportaciones de `'unicode-animations/braille'`

Igual que arriba — el punto de entrada principal reexporta todo desde el módulo braille.

## Licencia

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---