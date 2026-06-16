# RemoteVideoCam

Remote Video Cam is an open-source Android application that allows two devices to stream high-quality video and audio to each other over a local connection. Whether you're using it as a baby monitor, a DIY security camera, or a walkie-talkie, RemoteVideoCam offers a secure, offline-first solution without the need for internet access or third-party servers.

## ✨ Features

- **Zero Configuration**: Devices automatically discover and connect to each other.
- **Robust Connection**: Automatically negotiates the best available connection method:
  - **Local Network (LAN)**: Uses your existing Wi-Fi network.
  - **Wi-Fi Aware / Wi-Fi Direct**: Connects devices directly without an access point (offline).
- **Secure & Private**: No external servers. No cloud. Video and audio streams never leave your local environment.
- **Modern UI**: Built with **Jetpack Compose** and **Material 3**, offering a beautiful, responsive, and intuitive interface with dynamic colors.
- **Two Modes**:
  - **Camera Mode**: Acts as the broadcaster.
  - **Display Mode**: View the feed from the other device.
    - *Includes "Mirror" option to flip the video horizontally.*
  - *Note: Both devices can be in Display Mode to see each other (bidirectional).*
- **Audio Support**: Hear what's happening on the other end.

## ⚠️ Important Note

**Not a Medical Device**: While RemoteVideoCam can be useful for monitoring (e.g., as a baby monitor), it is **not** a certified medical device. 
- Video feeds may freeze due to network interference.
- Always have a backup monitoring method.
- **Tip**: Place a moving object (like a clock with a second hand) in the frame to easily verify that the video is live.

## 🛠️ Tech Stack

- **Language**: Kotlin
- **UI Framework**: Jetpack Compose (Material 3)
- **Video/Audio**: WebRTC (Local negotiation)
- **Computer Vision**: OpenCV (used for specific image processing tasks)
- **Architecture**: MVVM with reactive data streams (RxJava/RxAndroid)

## 📥 distinct

[<img src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png"
     alt="Get it on F-Droid"
     height="80">](https://f-droid.org/packages/org.avmedia.remotevideocam/)
[<img src="https://play.google.com/intl/en_us/badges/images/generic/en-play-badge.png"
     alt="Get it on Google Play"
     height="80">](https://play.google.com/store/apps/details?id=org.avmedia.remotevideocam)

## 🤝 Contributing

Contributions are welcome! If you're a developer and want to help improve RemoteVideoCam, please feel free to fork the repository and submit a pull request.

For major changes or questions, please contact the maintainer at `izivkov@gmail.com`.
