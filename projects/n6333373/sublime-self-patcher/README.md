## Sublime Self Patcher

This is a Sublime Text 4 plugin which can patch Sublime Text and Sublime Merge.

🔥 No third-party dependency is required. The only thing you need is Sublime Text.

## Supported Environments

| Sign | Meaning                                                                 |
| ---- | ----------------------------------------------------------------------- |
| ✅   | Supported.                                                              |
| ⚠️   | Unstable patch patterns. You may have to update this plugin frequently. |
| ☠️   | Sorry but I don't use it.                                               |

|                   | Linux x64 | Windows x32 | Windows x64 | Others |
| ----------------- | --------- | ----------- | ----------- | ------ |
| **Sublime Text**  | ✅        | ✅          | ✅          | ☠️     |
| **Sublime Merge** | ✅⚠️      |             | ✅          | ☠️     |

If you are on Windows 7, then [Service Pack 2](https://answers.microsoft.com/en-us/windows/forum/all/how-to-obtain-and-install-windows-7-sp2/c2c7009f-3a10-4199-9c89-48e1e883051e) is required.

## Download

https://github.com/n6333373/sublime-self-patcher/archive/refs/heads/main.zip

## Installation

First, you have to find out the `Packages` directory.

- If you are using a portable version of Sublime Text, it is `Data/Packages`.
- If you are using an installed version of Sublime Text,
  - On Windows, it is `%appdata%\Sublime Text\Packages`.
  - On Linux, it is `$HOME/.config/sublime_text/Packages`.

Now, (decompress if necessary) put the downloaded directory into the `Packages` directory
so that the directory structure looks like the following:

```text
Packages/
└── SelfPatcher/
    ├── boot.py
    ├── ...
```

And then restart Sublime Text if it's running.

## Usage

### Patch Self (The Current Sublime Text)

- If you are using a unregistered dev build, this plugin should show a popup for patching when starting.
- If you are using a stable build, you can patch from the menu: `Help ⇒ Patch This Application`

### Patch External Sublime Text/Merge

If your application is installed in a place which requires admin/root permission to write,
you can use this plugin to create a patched executable in a temporarily directory.

Click the menu: `Help ⇒ Patch External Sublime Text/Merge` and then select the executable of Sublime Text/Merge.

## Q&A

### How to Disable Sublime Text/Merge Auto Update?

This plugin usually just continues to work for future versions of Sublime Text/Merge.
But if you want to disable the application auto update, you can set the following settings:

```jsonc
{
    "update_check": false, // this works only if you have registered
}
```

### This Plugin is Suspicious

I don't think I do anything malicious, but you don't have to trust me. You can

- Do patching in a virtual machine and take the patched executable out.
- Do it by yourself. See https://gist.github.com/maboloshi/feaa63c35f4c2baab24c9aaf9b3f4e47
