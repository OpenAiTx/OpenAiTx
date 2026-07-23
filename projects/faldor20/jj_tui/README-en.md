# Jujutsu TUI
[![nix](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml/badge.svg)](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml)

A TUI for the Jujutsu version control system
Our focus here is on:
- **Performance**: jj_tui should start fast and never slow you down, it should feel extremely snappy to browse your commits and files
- **Intuitive**: Keybindings should be easily memorizable and quick to commit to muscle memory without uneeded popups
- **Interactivity**: jj_tui completely re-implements jj's renderer so we can show realtime previews of the graph while you figure out how your rebase should look ( Use `r`ebase `p`review to try it out!)

![jj_tui-ezgif com-optimize](https://github.com/faldor20/jj_tui/assets/26968035/fb053320-484a-4d6f-9b66-e5b9d0d49e5d)


Press `?` to show the help. (commands are different between graph and files view).
`Arrows` or `hjkl` to navigate windows/items
`Space` to select/deselect revisions (multi-select in graph view)
`Enter` to widen the diff and scroll through it

## Key features

### Normal jj operations
- `c`ommiting
- `r`ebasing
- `g`it pushing and pulling
- Adding, moving and deleting `b`ookmarks
- `s`quashing and `s`plitting commits
- `space` can be used to select multiple commits for copying, rebasing etc, starting a `n`ew commit on top of etc 

### Creating commits from the file view:
- `space` can be used to select files to `c`ommit separately or `m`ove to different commit
- Files and be sent to `N`ext or `P`revious commits

### filtering by revsets 
- `f`ilter by any revset you like

List of graph commands:

![jj_tui commands](https://github.com/user-attachments/assets/1e446a3d-1736-4207-b311-29d8e4bdc333)

## Installing
`linux`: Grab the latest release. It's statically linked and should work on any linux machine.
`mac`: Grab a prebuild. Let me know if you have any issues as I can't test on a mac.

To open a shell with jj_tui on nix: `nix shell github:faldor20/jj_tui`

## Dependencies
The jujutsu CLI (minimum version 0.30.0)
I haven't tested on windows or Mac.
I believe it won't work outside Unix so Windows users will currently have to use wsl.


# Config file:
You can make a `config.yaml` config file in the following directories to customize key inputs
`linux`: $XDG_CONFIG_HOME/jj_tui/
`macos`: ~/Library/preferences/jj_tui/
See `./jj_tui/lib/key_map.ml` for a spec for the keymap and `./jj_tui/lib/config.ml` for the config
The keymap config lets you fully customize all the commands and their sub menus as well as remap the arrow keys.

Eg:
``` yaml
key_map:
  remap:
   h: "left"
   j: "down"
   k: "up"
   l: "right"
  graph:
    #Simple mapping from key to command_id
    p: prev
    #Command sub menu
    s:
      title: "Squash"
      sub:
        # sub menu command
        s: "squash_into_parent"
# If the terminal is smaller than this width, the UI will change to a single pane view
single_pane_width_threshold: 110
# Sets the limit to how many commits are ever rendered in jj_tui. Usefull for not slowing down too much when viewing 'all()' revest.
max_commits: 100
```
For a full list of commands ids see [`jj_tui/bin/graph_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/graph_commands.ml) and [`jj_tui/bin/file_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/file_commands.ml)

# logs:
`linux`: $XDG_STATE_HOME/jj_tui/
`macos`: ~/Library/logs/jj_tui/

# Dev
Can be built with nix `nix build` or open a nix shell with `nix develop`
NOTE: if you are using the nix dev shell and would like to build with dune use `dune build --pkg disabled` to build using the deps provided by nix
Can also be built directly with Dune package management via `dune build`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---