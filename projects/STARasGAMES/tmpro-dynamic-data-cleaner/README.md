## About
TextMeshPro dynamic font assets have a very annoying habit of saving their dynamically generated binary data in the
same text file as their configuration data. This causes massive headaches for version control.

The script from this package addresses the above issue. It runs whenever any assets in the project are about to be saved. If any of
those assets are a TMP dynamic font asset, they will have their dynamically generated data cleared before they are
saved, which prevents that data from ever polluting the version control.

Credits to @cxode which came up with this brilliant solution:<br>
`https://forum.unity.com/threads/tmpro-dynamic-font-asset-constantly-changes-in-source-control.1227831/#post-8934711`

My contribution is making script into a upm compatible package that could be easily installed.<br>
Some performance improvements and additional checks were made for edge cases.<br>
Also, I created a test to quickly test whether script is working properly in your project/unity version.<br>

## Installation
Install via git URL:
`https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm`

Or by adding a new entry in your **`manifest.json`**.
```json
{
  "dependencies": {
    "com.starasgames.tmpro-dynamic-data-cleaner": "https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm",
    ...
  },
  "testables" : ["com.starasgames.tmpro-dynamic-data-cleaner"]
}
```
To make integration test visible in the TestRunner window you need to add the `"testables"` attribute, but this is optinal.
