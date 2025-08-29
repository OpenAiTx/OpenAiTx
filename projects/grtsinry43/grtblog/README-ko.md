# grtblog

[![GitHub license](https://img.shields.io/github/license/grtsinry43/grtblog)](http://www.apache.org/licenses/LICENSE-2.0.html)
[![GitHub release](https://img.shields.io/github/v/release/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/releases)
[![Last commit](https://img.shields.io/github/last-commit/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/commits/main)
[![GitHub issues](https://img.shields.io/github/issues/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/issues)
[![GitHub pull requests](https://img.shields.io/github/issues-pr/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog/pulls)
[![Languages](https://img.shields.io/github/languages/top/grtsinry43/grtblog)](https://github.com/grtsinry43/grtblog)
[![Author](https://img.shields.io/badge/author-grtsinry43-blue)](https://github.com/grtsinry43)
[![Development Status](https://img.shields.io/badge/status-in%20development-yellow)](https://github.com/grtsinry43/grtblog)

🚧🚧🚧 **이 프로젝트는 현재 개발 중입니다. / 공사 중이니 잠시 후 다시 확인해 주세요** 🚧🚧🚧

⏳⏳⏳ **현재 진행 상황: / 当前进度：**

- [x] Markdown 기반의 글 렌더링 / 基于 Markdown 的文章渲染
- [x] 글/태그/카테고리 관리 / 文章 / 标签 / 分类管理
- [x] 부분 리로드 / 部分重载
- [x] 내장 페이지 스타일 / 内置页面样式
- [x] 댓글 시스템 / 评论系统
- [ ] 다중 테마 지원 / 多主题支持
- [x] 검색 기능 / 搜索功能
- [ ] 관리자 대시보드 / 管理员仪表盘
- [ ] 사용자 정의 옵션 / 自定义选项
- [ ] 테마 전환 / 主题切换

## 개요 / 概述

grtblog는 React.js와 Spring Boot 기반의 종합 블로그 시스템(콘텐츠 관리 시스템)입니다.  
프론트엔드와 백엔드가 분리되어 있으며, 서버 사이드 및 정적 생성 모드를 혼합 지원하고, 풍부한 커스터마이징 옵션, 부분 리로드 지원, 테마 전환 기능을 제공합니다.

grtblog 是一个基于 React.js 和 Spring Boot 的综合博客系统（内容管理系统）。它具有前后端分离的架构，支持服务端和静态生成混合模式，提供丰富的自定义选项，支持部分重载和主题切换。

## 특징 / 特性

- **분리된 아키텍처 / 前后端分离架构**: 프론트엔드와 백엔드 분리로 확장성과 유지보수성을 향상합니다. 前后端分离，提升可扩展性和可维护性。
- **혼합 생성 / 混合生成**: 서버 사이드와 정적 생성 모두를 지원합니다. 支持服务端和静态生成。
- **커스터마이징 / 自定义**: 테마와 컴포넌트에 대한 풍부한 커스터마이징 옵션을 제공합니다. 提供丰富的主题和组件自定义选项。


- **부분 재로딩 / 部分重载**: 효율적인 부분 재로딩 지원. 高效的部分重载支持。
- **테마 전환 / 主题切换**: 개인화된 경험을 위한 간편한 테마 전환. 简单的主题切换，提供个性化体验。

## 스크린샷 / 截图

![image](https://github.com/user-attachments/assets/40cac1c2-767a-4e0e-b72c-664384e93dfd)
![image](https://github.com/user-attachments/assets/0f8819c4-5be2-47bf-b526-2db097141bd9)
![image](https://github.com/user-attachments/assets/acbb9f7b-4ffc-45ff-835e-e09ee0a16979)
![image](https://github.com/user-attachments/assets/72116ff9-eb07-4e0c-921a-c3db32cbd59c)
![image](https://github.com/user-attachments/assets/6e790aab-94f4-4ada-8fc7-fc1bef0af5c8)


## 시작하기 / 快速开始

### 필수 조건 / 前提条件

- Node.js
- npm
- Java
- Maven

### 설치 / 安装

1. 저장소 클론 / 克隆仓库:
    ```bash
    git clone https://github.com/grtsinry43/grtblog.git
    cd grtblog
    ```
2. 프론트엔드 종속성 설치 / 安装前端依赖:

    ```bash
    cd frontend
    npm install
    ```
3. 백엔드 종속성 설치 / 安装后端依赖:

    ```bash
    cd ../backend
    mvn install
    ```

### 애플리케이션 실행 / 运行应用

1. 백엔드 서버 시작 / 启动后端服务器:
    ```bash
    cd backend
    mvn spring-boot:run
    ```
2. 프런트엔드 개발 서버 시작 / 启动前端开发服务器:

    ```bash
    cd ../frontend
    npm start
    ```

## Contributing / 기여

[//]: # (기여를 환영합니다! 자세한 내용은 [기여 가이드라인]&#40;CONTRIBUTING.md&#41;을 읽어주세요.)

[//]: # ()
[//]: # (기여를 환영합니다! 자세한 내용은 [기여 가이드라인]&#40;CONTRIBUTING.md&#41;을 읽어주세요.)

## License / 라이선스

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

본 프로젝트는 MIT 라이선스 하에 있습니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## Acknowledgements / 감사의 말

- [React.js](https://reactjs.org/)
- [Spring Boot](https://spring.io/projects/spring-boot)

## Contact / 연락처

For any inquiries, please contact [grtsinry43](https://github.com/grtsinry43).

문의 사항이 있으시면 [grtsinry43](https://github.com/grtsinry43)에게 연락해 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---