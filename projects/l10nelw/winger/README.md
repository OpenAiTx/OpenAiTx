# Winger - A Window Manager

Name windows, switch windows, move tabs between windows, and more. A Firefox web extension to fluidly operate multiple windows and organize tabs.

Install Winger from here: https://addons.mozilla.org/firefox/addon/winger/

## Code and documentation conventions

### Terminology

- `active` tabs are "focused"
- `highlighted` tabs are "selected"

### Variable names

- Most variables and functions are camelCased
- Classes, modules and namespace objects (which group related functions together, hardcoded) are usually PascalCased
- Hardcoded constants are usually UPPER_SNAKE_CASED
- Storage keys are usually lower_snake_cased
- Arrays are usually plural
- Objects are usually singular
- Objects that serve to group things together (as opposed to representing a thing) are usually suffixed with `Dict`
- Object properties that are only referenced inside their object are usually prefixed with `_`
- Maps are usually suffixed with `Map`
- Sets are usually suffixed with `Set`
- Booleans are usually prefixed with words like `is` and `has`
- DOM nodes and collections of DOM nodes are usually prefixed with `$`
- Custom properties (a.k.a. expandos) in standard built-in objects (e.g. Arrays, DOM nodes) are prefixed with `_`, or `$` if referencing DOM nodes
