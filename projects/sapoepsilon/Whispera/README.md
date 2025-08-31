# Whispera

A native macOS app that replaces the built-in dictation with OpenAI's Whisper for superior transcription accuracy. Transcribe speech, local files, YouTube videos, and network streams - all processed locally on your Neural Engine.
<div align="center">
  
  ### [⬇️ Download Latest Release](https://github.com/sapoepsilon/Whispera/releases/latest)
  
  [![GitHub release (latest by date)](https://img.shields.io/github/v/release/sapoepsilon/Whispera?style=for-the-badge&logo=github&color=0969da&labelColor=1f2328)](https://github.com/sapoepsilon/Whispera/releases/latest)
  
</div>

## Demos

<table>
  <tr>
    <th>Speech to Text Field</th>
    <th>File/URL Transcription with Timestamps</th>
  </tr>
  <tr>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/1da72bbb-a1cf-46ee-a997-893f1939e626" controls>
        Your browser does not support the video tag.
      </video>
    </td>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/d573bef4-a3b2-49ac-a1fd-3c6735648fdc" controls>
        Your browser does not support the video tag.
      </video>
    </td>
  </tr>
</table>

## Features

- **Live transcription** (beta)
- **Speech-to-text** - Replaces macOS native dictation with WhisperKit (OpenAI's Whisper model on Neural Engine) for better accuracy
- **File transcription** - Audio and video files
- **Network media transcription** - Stream video/music URLs
- **YouTube transcription**

All processing runs locally. Internet required only for initial model download.
## Roadmap

- [x] Multi-language support beyond English 
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/2
  - **Release**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.3
- [x] Real-time translation capabilities
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/17
  - **Release**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.18
- [ ] Additional customization options

## Usage

Simply use your configured global shortcut to start transcribing with Whisper instead of the default macOS dictation.

## Known Issues

- The app does not work with Intel mac(see [Issue 15](https://github.com/sapoepsilon/whispera/issues/15)
- Auto install does not work, after an app has been downloaded, please manually drag and drop the app to you `/Application` folder
## Requirements

- macOS 13.0 or later
- Apple Silicon
- We are working on support for Intel Mac

## Credits

Built with:
- [WhisperKit](https://github.com/argmaxinc/WhisperKit) - On-device Whisper transcription for Apple Silicon
- [YouTubeKit](https://github.com/alexeichhorn/YouTubeKit) - YouTube content extraction
- [swift-markdown-ui](https://github.com/gonzalezreal/swift-markdown-ui)


Thanks to these projects for making privacy-focused, local transcription a reality.

## License

MIT License
