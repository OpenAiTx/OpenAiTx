# Streaker <img alt="Streaker Logo" align="right" width=40 height=40 alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/./.github/icons/icon.svg">

Cross-platform GitHub contribution streak and statistic tracking menu bar application with reminder notification

[![ci](https://github.com/jamieweavis/streaker/actions/workflows/ci.yml/badge.svg)](https://github.com/jamieweavis/streaker/actions)
[![downloads](https://img.shields.io/github/downloads/jamieweavis/streaker/total.svg)](https://github.com/jamieweavis/streaker/releases)
[![version](https://img.shields.io/github/release/jamieweavis/streaker.svg)](https://github.com/jamieweavis/streaker/releases)
[![license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/jamieweavis/streaker/blob/main/LICENSE)

<img width="716" alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/screenshot.png">

## Install

Download the latest version of Streaker from the **[GitHub releases](https://github.com/jamieweavis/streaker/releases)** page (or see the **[Development](#development)** section to build it yourself).

## Features

- Menu bar contribution stats
  - Streak
    - Best
    - Current
    - Previous
  - Contributions
    - Most (day)
    - Today
    - Total (year)
- Menu bar icon changes depending on contribution status
  - Empty - you haven't contributed today
  - Filled - you have contributed today
  - Crown - you're currently on your best streak
- Three different menu bar icon themes
  - Flame
  - Tile
  - Octocat
- Reminder notification so you don't lose your streak

### Menu Bar Icons

#### Light Mode

| State | Flame | Tile | Octocat |
| ----- | ----- | ---- | ------- |
| Pending | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac.svg"> |
| Contributed | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac.svg"> |
| Streaking | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac.svg"> |

#### Dark Mode

| State | Flame | Tile | Octocat |
| ----- | ----- | ---- | ------- |
| Pending | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac-white.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac-white.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac-white.svg"> |
| Contributed | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac-white.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac-white.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac-white.svg"> |
| Streaking | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac-white.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac-white.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac-white.svg"> |

## Development

### Prerequisites

- [Node.js](https://github.com/nodejs/node) (>=22.x.x)
- [pnpm](https://github.com/pnpm/pnpm) (>=10.x.x)

### Getting Started

Clone the repository and install dependencies:

```sh
git clone https://github.com/jamieweavis/streaker.git

cd streaker

pnpm install
```

Package the app for your current platform:
```bash
pnpm package
```

_The packaged app will now be in the `out/` directory_

Run the app in development mode:
```bash
pnpm start
```

*Only the renderer process currently supports hot reloading, changes in `src/main/` will require a restart*

## Related

- [Streaker CLI](https://github.com/jamieweavis/streaker-cli) - GitHub contribution streak & statistic tracking command line application with ASCII contribution graph
- [Contribution](https://github.com/jamieweavis/contribution) - GitHub contribution graph parser calculates contribution streak and commit statistics from a user's GitHub contribution graph page
