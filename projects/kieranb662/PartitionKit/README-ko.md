# Partition Kit

![partition kit logo](https://github.com/kieranb662/PartitionKit/blob/master/partition-kit-logo.png)

최근 [10월 인기 Android 및 iOS 라이브러리 TOP 10](https://medium.com/better-programming/top-10-trending-android-and-ios-libraries-in-october-e7dd18f8b75b) 및 [앱을 향상시키는 5가지 iOS 라이브러리](https://medium.com/better-programming/5-ios-libraries-to-enhance-your-app-17ae7ed350db)에 소개되었습니다!

![grid](/nestedGrid.gif)

PartitionKit이란?  
- SwiftUI에서 조합 가능하고 동적으로 크기가 조정되는 사용자 인터페이스 콘텐츠에 대한 요구를 해결하는 솔루션입니다.  
- 또한 제가 처음으로 라이브러리 형태로 만든 소프트웨어이므로 사용 사례와 마음 모두에 대해 부드럽게 대해 주세요.

PartitionKit이 **아닌** 것은?  
- PartitionKit은 저장된 데이터 형식과 작업하는 수단이 아니며, 하드 드라이브 파티셔닝이나 기타 형식화 가능한 데이터 드라이브용이 아닙니다.  


## 요구 사항

PartitionKit은 기본적으로 SwiftUI 프레임워크가 작동 중이어야 하므로, 다음 플랫폼만 지원합니다:

*  macOS 10.15 이상  
* iOS 13 이상  
* tvOS 13 이상  
* watchOS 6 이상  


## 프로젝트에 추가하는 방법

1. GitHub 저장소에서 URL을 가져옵니다  
2. Xcode -> File -> Swift Packages -> Add Package Dependencies  
3. URL을 입력란에 붙여넣기  
4. 최소 버전 번호 지정 (새로운 기능으로 1.0.0 이상이면 작동합니다).

## 2분 미만 튜토리얼 비디오

[![튜토리얼 비디오: PartitionKit 사용법](https://img.youtube.com/vi/RSnEevQcqjk/0.jpg)](https://www.youtube.com/watch?v=RSnEevQcqjk)


## 사용 방법 

### 수직 분할

1. `상단`에 어떤 뷰를 배치할지, `하단`에 어떤 뷰를 배치할지 결정하고 선택적으로 분할 크기를 조절하는 데 사용할 `핸들`을 지정합니다.
2. 이렇게 하세요

``` Swift
VPart(top: {
    MyTopView()
    }, bottom: {
    MyBottomView()
    }) {
    MyHandle()
}
```
### 수평 분할

1. `왼쪽`에 표시할 뷰, `오른쪽`에 표시할 뷰, 그리고 선택적으로 분할 크기를 조절할 때 사용할 `핸들`을 결정합니다.
2. 이렇게 하세요

``` Swift
HPart(left: {
    MyLeftView()
    }, right: {
    MyRightView()
    }) {
    MyHandle()
}
```

### GridPartition 

1. 각 코너에 들어갈 뷰를 결정합니다: `TopLeft`, `TopRight`, `BottomLeft`, `BottomRight` 그리고 선택적으로 사용자가 뷰를 드래그하고 크기를 조정할 수 있는 `Handle`을 설정합니다. 
2. 이렇게 합니다 
``` Swift
    GridPart(topLeft: {
        MyTopLeftView()
        }, topRight: {
        MyTopRightView()
        }, bottomLeft: {
        MyBottomLeftView()
        }, bottomRight: {
        MyBottomRightView()
        }) {
        MyHandle()
}
```
## 예제

복사하여 붙여넣기 하세요. 뷰가 어떻게 보여야 하는지에 대해 명명된 그림을 추가했습니다. 저는 다크 모드를 사용 중이므로 라이트 모드 색상은 다르게 보일 수 있습니다.

| HPart                   | VPart                   | GridPart                      | NestGrids                              | Mixed                       |
|-------------------------|-------------------------|-------------------------------|----------------------------------------|-----------------------------|
| ![HPart](/hExample.png) | ![VPart](/vExample.png) | ![GridPart](/gridExample.png) | ![Nested Grid](/nestedGridExample.png) | ![Mixed](/nestedExample.png) |





``` Swift
import SwiftUI
import PartitionKit



struct ContentView: View {
    var vExample: some View {
        VPart(top: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }) {
            Circle().foregroundColor(.yellow)
        }
    }
    
    var hExample: some View {
        HPart(left: {
            RoundedRectangle(cornerRadius: 10).foregroundColor(.blue)
        }) {
            Circle().foregroundColor(.orange)
        }
    }
    
    var nestedExample: some View {
        VPart(top: {
            hExample
        }) {
            vExample
        }
    }
    
    var gridExample: some View {
        GridPart(topLeft: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }, topRight: {
            Circle().foregroundColor(.yellow)
        }, bottomLeft: {
            Circle().foregroundColor(.green)
        }) {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.blue)
        }
    }
    
    var nestedGridsExample: some View {
        GridPart(topLeft: {
            gridExample
        }, topRight: {
            gridExample
        }, bottomLeft: {
            gridExample
        }) {
            gridExample
        }
    }
    
    var body: some View {
        nestedExample
        
    }
}


struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
```
## 할 일 
* 핸들을 컨테이너 프레임 밖으로 드래그할 때 뷰가 반전되는 음수 프레임 값을 발생시키지 않도록 파티션에 제약 조건 추가 
* 초기 레이아웃에 대한 사용자 정의 기능 확장 
* 식별 가능한 데이터 요소 목록으로 초기화할 수 있는 `List` 스타일 그리드 컬렉션 레이아웃 추가 
* 전반적인 정리, 일부 내용은 남겨둘 의도가 아니었으며 나중에 찾아서 제거할 예정임 






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---