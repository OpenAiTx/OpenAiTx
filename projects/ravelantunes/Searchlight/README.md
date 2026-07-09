# Searchlight - Postgres MacOS Client

![Screenshot of Searchlight](https://raw.githubusercontent.com/ravelantunes/Searchlight/main/./docs/screenshot1.png)

Searchlight is a native macOS, open-source PostgreSQL client designed to be simple, lightweight, and developer-friendly. It offers a clean and intuitive interface for managing databases and running queries without the complexity of full-scale database management tools. Searchlight focuses on delivering a smooth and efficient experience for developers who need quick and easy access to their PostgreSQL databases.

## Installation

Download the latest release from the [Releases Page](https://github.com/ravelantunes/Searchlight/releases).

> I’m using my personal Apple developer account so I can’t notarize the app with Apple. If you try to install from the GitHub releases page MacOS will warn that it can’t verify the developer identity, so you will need to approve the install on Settings > Privacy, or build from source.

## Current Features

### Connection Management

- Save and manage favorite connections
- SSH tunnel support with key-based authentication
- SSL/TLS connection support

### Database Browser

- Browse databases, schemas, and tables
- Quick search and filter on table data
- Foreign key relationship linking — click to navigate to related records
- Column statistics popover — view unique values, null counts, and value distribution charts

### Data Manipulation

- Insert new rows directly in the table
- Copy cell value, row, columns in different formats
- Auto-complete/data look-up from foreign key references when inserting data
- Export formats: Plain text, CSV, SQL INSERT statements

### Query Editor

- Free-form SQL query execution
- SQL LSP support for autocompletion, diagnostics, and hover documentation

## Building from Source

1. Clone the repository
2. Open `Searchlight.xcodeproj` in Xcode
3. Build twice (⌘B, ⌘B) — the first build downloads dependencies, the second includes them
4. Run (⌘R)

The first build automatically downloads the [Postgres Language Server](https://github.com/supabase-community/postgres-language-server) binary (~16MB) for SQL autocompletion, syntax checking, and hover documentation. A second build is needed to bundle it into the app.

> **Note:** The LSP binary is only for Apple Silicon (arm64).

## Tech Stack

- **Swift & SwiftUI** — Native macOS app with AppKit integration for advanced table views
- **PostgresKit / PostgresNIO** — PostgreSQL driver with connection pooling
- **SwiftNIO** — Async networking foundation
- **System SSH** — Native SSH tunnel support using macOS system tools
- **Postgres Language Server** — SQL intelligence (autocompletion, diagnostics, hover docs)

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

## License

See [LICENSE](LICENSE) for details.
