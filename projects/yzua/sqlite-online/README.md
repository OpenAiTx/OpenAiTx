# SQLite Online

<div align="center">
  <a href="https://yzua.github.io/sqlite-online/">
    <img
      src="https://github.com/user-attachments/assets/aef749bf-df08-4a84-8148-d34b796449d8"
      alt="SQLite Online Logo"
      width="128"
    />
  </a>
</div>

A client-side SQLite editor built with React, TypeScript, Vite, and `sql.js`.
It runs in the browser, initializes a demo database by default, and can open
local SQLite files without a backend.

## Overview

- **Open local `.db`, `.sqlite`, and `.sqlite3` files**
- **Create and modify tables, views, and indexes with SQL**
- **Browse, filter, sort, paginate, add, edit, and delete rows**
- **Run custom SQL and export results as CSV**

Most database work runs locally in the browser through WebAssembly and a web
worker. Optional features such as URL loading, the CORS proxy fallback, Google
Fonts, and Gemini-powered query generation use network requests.

## Features

- **Local-first database editing:** open files from disk, drag and drop a
  database into the page, and download the current database as
  `database.sqlite`.
- **Schema and data workflows:** inspect schema, browse table data, edit rows,
  insert new rows, delete rows, and execute custom SQL statements.
- **CSV export paths:** export an entire table, the current table page, or the
  current custom query result set as CSV.
- **Additional UX features:** dark mode, high-contrast mode, keyboard
  shortcuts, skip links, and live regions for accessibility.
- **Optional integrations:** load a database from a `?url=` query parameter and
  generate SQL from `/ai ...` prompts after configuring a Gemini API key.

## Development

```bash
npm install
npm run dev
```

Useful project commands:

- `npm run build`
- `npm run build:pages`
- `npm run typecheck`
- `npm run check`
- `npm run check:fix`
- `npm run doctor`
- `npm run preview`
- `npm run preview:pages`
- `npm run lint`
- `npm run lint:fix`
- `npm run format`
- `npm run format:check`
- `npm test`
- `npm run test:watch`
- `npm run knip`
- `npm run deploy`

## Keyboard Shortcuts (Hotkeys)

Streamline your workflow with these built-in hotkeys:

| Shortcut              | Action                      |
| --------------------- | --------------------------- |
| **Ctrl + s**          | Download the database       |
| **Ctrl + ArrowRight** | Go to the next page         |
| **Ctrl + ArrowUp**    | Jump to the first page      |
| **Ctrl + ArrowDown**  | Jump to the last page       |
| **Ctrl + ArrowLeft**  | Go to the previous page     |
| **Ctrl + \`**         | Close the edit panel        |
| **Ctrl + i**          | Insert mode / submit insert |
| **Ctrl + u**          | Submit an update edit       |
| **Ctrl + d**          | Submit a delete edit        |
| **Ctrl + q**          | Execute the SQL query       |

## License

SQLite Online is released under the [GNU GPL v3.0](https://github.com/yzua/sqlite-online/blob/main/LICENSE).
