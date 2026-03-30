![image](https://user-images.githubusercontent.com/693717/210183526-1708c821-172e-4c71-9b02-2a9885654505.svg)

# QuickLook.Plugin.WebViewPlus

[QuickLook](https://github.com/QL-Win/QuickLook) plugin for previewing various file types with [WebViewPlus](https://github.com/mooflu/WebViewPlus).

## Try out

1. Go to [Release page](https://github.com/mooflu/QuickLook.Plugin.WebViewPlus/releases) and download the latest version.
2. Make sure that you have QuickLook running in the background. Go to your Download folder, and press <key>Spacebar</key> on the downloaded `.qlplugin` file.
3. Click the “Install” button in the popup window.
4. Restart QuickLook.
5. To configure which file types to preview via WebViewPlus, open an html file and click the gears button on the bottom right.

## Development

 1. Clone this project. Do not forget to update submodules.
 2. Copy WebViewPlus web app to `webApp` or set plugin config `WebAppUrl` - see `WebpagePanel.cs`
 3. Set `Output path` in `Debug` configuration to something like `..\QuickLook.upstream\Build\Debug\QuickLook.Plugin\QuickLook.Plugin.WebViewPlus\`
 4. Build plugin project with `Debug` profile
 5. Build and run upstream Quicklook with `Debug` profile

 # Release
 1. Build project with `Release` profile.
 2. Run `Scripts\pack-zip.ps1`.
 3. You should find a file named `QuickLook.Plugin.WebViewPlus.qlplugin` in the project directory.

## License

MIT License.
