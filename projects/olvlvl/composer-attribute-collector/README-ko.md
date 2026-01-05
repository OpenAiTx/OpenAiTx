# composer-attribute-collector

[![Release](https://img.shields.io/packagist/v/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)
[![Code Coverage](https://coveralls.io/repos/github/olvlvl/composer-attribute-collector/badge.svg?branch=main)](https://coveralls.io/r/olvlvl/composer-attribute-collector?branch=main)
[![Downloads](https://img.shields.io/packagist/dt/olvlvl/composer-attribute-collector.svg)](https://packagist.org/packages/olvlvl/composer-attribute-collector)

**composer-attribute-collector**는 PHP 8 속성 대상(attribute targets)을 효과적으로 _발견_하고, 런타임 리플렉션 없이 거의 제로 비용으로 나중에 이를 검색할 수 있도록 설계된 [Composer][] 플러그인입니다.  
오토로더 덤프 후, 속성을 수집하고 빠른 접근을 위한 정적 파일을 생성합니다. 이는 속성 기반 클래스, 메서드 또는 프로퍼티를 _발견_하는 편리한 방법을 제공하며, 코드베이스 분석에 이상적입니다. (알려진 대상에 대해서는 기존 리플렉션도 여전히 선택 가능합니다.)



#### 기능

- 설정 불필요
- 생성된 파일에 리플렉션 없음
- 성능 향상 가능성 있음
- 의존성 없음 (물론 Composer 제외)
- 속성 대상: 클래스, 메서드, 프로퍼티를 얻기 위한 단일 인터페이스
- 연속 실행 속도를 높이기 위한 발견 결과 캐시 가능

> [!NOTE]
> 현재 플러그인은 클래스, 메서드, 프로퍼티, 파라미터 대상을 지원합니다.  
> 지원 확장에 관심이 있으시면 [기여](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md)해 주세요.

> [!WARNING]
> 현재 함수에 사용된 속성은 무시됩니다.



#### 사용법

다음 예시는 대상과 해당 속성을 어떻게 검색할 수 있는지 보여줍니다:




```php
<?php

use olvlvl\ComposerAttributeCollector\Attributes;
use Symfony\Component\Messenger\Attribute\AsMessageHandler;
use Symfony\Component\Routing\Annotation\Route;
use Doctrine\ORM\Mapping\Column;

require_once 'vendor/autoload.php';
require_once 'vendor/attributes.php'; // <-- the file created by the plugin

// Find the target classes of the AsMessageHandler attribute.
foreach (Attributes::findTargetClasses(AsMessageHandler::class) as $target) {
    // $target->attribute is an instance of the specified attribute
    // with the actual data.
    var_dump($target->attribute, $target->name);
}

// Find the target methods of the Route attribute.
foreach (Attributes::findTargetMethods(Route::class) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find the target properties of the Column attribute.
foreach (Attributes::findTargetProperties(Column::class) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find the target method parameters of the UserInput attribute.
foreach (Attributes::findTargetParameters(UserInput::class) as $target) {
    var_dump($target->attribute, $target->class, $target->method, $target->name);
}

// Filter target methods using a predicate.
// You can also filter target classes and properties.
$predicate = fn($attribute) => is_a($attribute, Route::class, true);
# or
$predicate = Attributes::predicateForAttributeInstanceOf(Route::class);

foreach (Attributes::filterTargetMethods($predicate) as $target) {
    var_dump($target->attribute, $target->class, $target->name);
}

// Find class, method, and property attributes for the ArticleController class.
$attributes = Attributes::forClass(ArticleController::class);

var_dump($attributes->classAttributes);
var_dump($attributes->methodsAttributes);
var_dump($attributes->propertyAttributes);
```
## 시작하기

시작하는 데 도움이 되는 몇 가지 단계입니다.

### 1\. 플러그인 구성 (선택 사항)

수집기는 제로 구성 경험을 위해 루트 `composer.json`의 `autoload` 경로를 자동으로 스캔합니다.  
`extra.composer-attribute-collector.include`를 통해 이를 재정의할 수 있습니다.





```json
{
  "extra": {
    "composer-attribute-collector": {
      "include": [
        "src"
      ]
    }
  }
}
```
[구성 옵션](#configuration)을 확인하여 자세한 내용을 참조하세요.



### 2\. 플러그인 설치

[Composer][]를 사용하여 플러그인을 설치합니다.
플러그인을 신뢰하고 활성화할지 묻는 메시지가 표시되면 `y`를 선택하여 진행하세요.


```shell
composer require olvlvl/composer-attribute-collector
```
다음과 유사한 로그 메시지를 확인할 수 있습니다:


```
Generating autoload files
Generating attributes file
Generated attributes file in 9.137 ms
Generated autoload files
```

> [!TIP]
> 개발 중에 "attributes" 파일을 자동으로 새로 고치려면 [자주 묻는 질문](#frequently-asked-questions) 섹션을 참조하세요.
> 



### 3\. "attributes" 파일 자동 로드

`require_once 'vendor/attributes.php';`를 사용하여 "attributes" 파일을 불러올 수 있지만,
Composer의 자동 로드 기능을 사용하는 것이 더 편할 수 있습니다:

```json
{
  "autoload": {
    "files": [
      "vendor/attributes.php"
    ]
  }
}
```
## 구성

플러그인을 구성할 수 있는 몇 가지 방법입니다.



### 경로나 파일 포함 ([root-only][])

수집기는 루트 `composer.json`의 `autoload` 경로를 자동으로 스캔하지만,
`include` 속성을 통해 이를 재정의할 수 있습니다.

지정된 경로는 `composer.json` 파일을 기준으로 하며, `{vendor}` 플레이스홀더는
벤더 폴더 경로로 대체됩니다.




```json
{
  "extra": {
    "composer-attribute-collector": {
      "include": [
        "path-or-file/to/include"
      ]
    }
  }
}
```

### 경로 또는 파일 제외 ([root-only][])

`exclude` 속성을 사용하여 스캔에서 경로나 파일을 제외할 수 있습니다. 이는 파일이
문제를 일으키거나 부작용이 있을 때 유용합니다.

지정된 경로는 `composer.json` 파일을 기준으로 하며, `{vendor}` 자리표시는
벤더 폴더 경로로 대체됩니다.

```json
{
  "extra": {
    "composer-attribute-collector": {
      "exclude": [
        "path-or-file/to/exclude"
      ]
    }
  }
}
```
### 실행 간 발견 내용 캐시하기

플러그인은 실행 간 발견 내용을 재사용하기 위해 캐시를 유지할 수 있습니다. 캐시를 활성화하려면,
환경 변수 `COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE`를 `1`, `yes`, 또는 `true`로 설정하세요.
캐시 항목은 `.composer-attribute-collector` 디렉토리에 저장되며, 이 디렉토리를
`.gitignore` 파일에 추가하는 것이 좋습니다.


```shell
COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=1 composer dump-autoload
```

## 사용 사례

실제 환경에서 플러그인을 테스트할 수 있는 사용 사례가 제공됩니다:

- [호환되지 않는 시그니처](cases/incompatible-signature) 플러그인은 속성을 수집할 수 있습니다.
  비록 Composer와 애플리케이션이 사용하는 PSR Logger 버전이 호환되지 않더라도 가능합니다.

- [Symfony](cases/symfony) `symfony new`로 생성된 Symfony 애플리케이션입니다.

- [Laravel](cases/laravel) `laravel new`로 생성된 Laravel 애플리케이션입니다.


## 자주 묻는 질문

**최적화된 오토로더를 생성해야 하나요?**

이 플러그인이 작동하는 데 최적화된 오토로더를 생성할 필요는 없습니다. 플러그인은 Composer와 유사한 코드를 사용하여 클래스를 찾습니다. Composer에서 작동하는 모든 것은 플러그인에서도 작동해야 합니다.

**개발 중에 플러그인을 사용할 수 있나요?**

예, 개발 중에도 플러그인을 사용할 수 있지만 "attributes" 파일은 오토로더가 덤프된 후에만 생성된다는 점을 유의하세요. 속성을 수정하면 "attributes" 파일을 갱신하기 위해 `composer dump-autoload`를 실행해야 합니다.

해결책으로 속성이 있는 클래스를 포함하는 디렉토리에 워처를 설정하여 변경 시 `XDEBUG_MODE=off composer dump-autoload`를 실행할 수 있습니다. [PhpStorm은 파일 워처를 제공합니다][phpstorm-watchers]. 또한 [spatie/file-system-watcher][]를 사용할 수 있는데, PHP만 필요합니다. 플러그인이 너무 느리다면, `COMPOSER_ATTRIBUTE_COLLECTOR_USE_CACHE=yes`로 명령을 실행해 보세요. 캐시가 활성화되어 연속 실행 속도가 빨라집니다.

**속성을 상속하는 클래스를 포함하려면 어떻게 해야 하나요?**

수집 과정을 빠르게 하기 위해 플러그인은 먼저 PHP 파일을 일반 텍스트로 살펴보며 속성 사용의 힌트를 찾습니다. 클래스가 속성을 트레이트, 속성, 또는 메서드에서 상속하지만 자체적으로 속성을 사용하지 않으면 무시됩니다. 속성을 사용하려면












`[#\olvlvl\ComposerAttributeCollector\InheritsAttributes]` 를 강제로 수집하도록 합니다.

```php
trait UrlTrait
{
    #[UrlGetter]
    public function get_url(): string
    {
        return '/url';
    }
}

#[InheritsAttributes]
class InheritedAttributeSample
{
    use UrlTrait;
}
```

----------



## 지속적 통합

이 프로젝트는 [GitHub actions](https://github.com/olvlvl/composer-attribute-collector/actions)를 통해 지속적으로 테스트됩니다.

[![Cases](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/cases.yml)
[![Tests](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/test.yml)
[![Static Analysis](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/static-analysis.yml)
[![Code Style](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml/badge.svg?branch=main)](https://github.com/olvlvl/composer-attribute-collector/actions/workflows/code-style.yml)



## 행동 강령

이 프로젝트는 [기여자 행동 강령](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CODE_OF_CONDUCT.md)을 준수합니다. 
이 프로젝트와 커뮤니티에 참여함으로써, 여러분은 이 강령을 지킬 것으로 기대됩니다.



## 기여

자세한 내용은 [CONTRIBUTING](https://raw.githubusercontent.com/olvlvl/composer-attribute-collector/main/CONTRIBUTING.md)를 참조하세요.



[Composer]:  https://getcomposer.org/
[root-only]: https://getcomposer.org/doc/04-schema.md#root-package
[spatie/file-system-watcher]: https://github.com/spatie/file-system-watcher
[phpstorm-watchers]: https://www.jetbrains.com/help/phpstorm/using-file-watchers.html


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---