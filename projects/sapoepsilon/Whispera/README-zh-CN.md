# Whispera

一款原生 macOS 应用，使用 OpenAI 的 Whisper 替代内置语音识别，实现更高的转录准确率。转录语音、本地文件、YouTube 视频和网络流——全部在您的神经引擎上本地处理。
<div align="center">
  
  ### [⬇️ 下载最新版本](https://github.com/sapoepsilon/Whispera/releases/latest)
  
  [![GitHub release (latest by date)](https://img.shields.io/github/v/release/sapoepsilon/Whispera?style=for-the-badge&logo=github&color=0969da&labelColor=1f2328)](https://github.com/sapoepsilon/Whispera/releases/latest)
  
</div>

## 演示

<table>
  <tr>
    <th>语音转文本字段</th>
    <th>带时间戳的文件/链接转录</th>
  </tr>
  <tr>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/1da72bbb-a1cf-46ee-a997-893f1939e626" controls>
        您的浏览器不支持视频标签。
      </video>
    </td>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/d573bef4-a3b2-49ac-a1fd-3c6735648fdc" controls>
        您的浏览器不支持视频标签。
      </video>
    </td>
  </tr>
</table>

## 功能

- **实时转录**（测试版）
- **语音转文本** - 用 WhisperKit（运行在神经引擎上的 OpenAI Whisper 模型）替代 macOS 原生语音识别，提高准确率
- **文件转录** - 音频和视频文件
- **网络媒体转录** - 流媒体视频/音乐链接
- **YouTube 转录**

所有处理均在本地运行。仅在首次下载模型时需要互联网连接。  
## 路线图

- [x] 支持多语言（英语以外）  
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/2  
  - **发布**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.3  
- [x] 实时翻译功能  
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/17  
  - **发布**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.18  
- [ ] 额外的自定义选项  

## 使用方法

只需使用您配置的全局快捷键，即可开始使用 Whisper 进行转录，替代 macOS 默认的听写功能。  

## 已知问题

- 该应用无法在 Intel Mac 上运行（参见 [问题 15](https://github.com/sapoepsilon/whispera/issues/15)）  
- 自动安装功能无效，下载应用后，请手动将应用拖拽到您的 `/Application` 文件夹中  
## 系统要求

- macOS 13.0 或更高版本  
- Apple Silicon 芯片  
- 我们正在开发对 Intel Mac 的支持  

## 致谢

构建工具：  
- [WhisperKit](https://github.com/argmaxinc/WhisperKit) - 适用于 Apple Silicon 的本地 Whisper 转录  
- [YouTubeKit](https://github.com/alexeichhorn/YouTubeKit) - YouTube 内容提取  
- [swift-markdown-ui](https://github.com/gonzalezreal/swift-markdown-ui)  

感谢这些项目让注重隐私的本地转录成为现实。  

## 许可证

MIT 许可证



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-31

---