# with-react

![GitHub Repo stars](https://img.shields.io/github/stars/jacobparis/with-react?style=social)
![npm](https://img.shields.io/npm/v/with-react?style=plastic)
![GitHub](https://img.shields.io/github/license/jacobparis/with-react?style=plastic)
![npm](https://img.shields.io/npm/dy/with-react?style=plastic)
![npm](https://img.shields.io/npm/dw/with-react?style=plastic)
![GitHub top language](https://img.shields.io/github/languages/top/jacobparis/with-react?style=plastic)

A collection of React components that wrap React hooks to provide a more composable API. Each component accepts a render prop that receives the hook's return value.

This enables a lot of features that previously violate the Rules of Hooks

## Conditional Hooks

```tsx
function UserProfile({ user, showDetails }) {
  return (
    <div>
      <h1>{user.name}</h1>

      <p>
        This is a really long description and there could be more markup
        or other components between here and the top of the component.
        Since hooks need to be declared at the top of the component function,
        instead of in the JSX, you may want to use WithState instead of useState
        just for colocation reasons.
      </p>

      {showDetails && (
        <WithState initialState={user.lastLogin}>
          {(lastLogin, setLastLogin) => (
            <div>
              Last login: {lastLogin}
              <button onClick={() => setLastLogin(new Date())}>
                Update
              </button>
            </div>
          )}
        </WithState>
      )}
    </div>
  )
}
```



## 循环中的钩子

这是条件钩子的一个特殊情况，但有时你在循环中渲染大量项目，并且不值得为它们创建自定义组件，因为它们需要从父作用域获取太多数据。

但是当你需要为每个项目添加一些状态时，React 强制你将其包装在组件中。通过使用 WithState，该组件会为你提供，你可以让父组件拥有你的列表项。


```tsx
const items = ['apple', 'banana', 'orange']

function FruitList() {
  return (
    <ul>
      {items.map((item) => (
        <WithState key={item} initialState={0}>
          {(count, setCount) => (
            <li>
              {item}: {count}
              <button onClick={() => setCount(count + 1)}>+</button>
            </li>
          )}
        </WithState>
      ))}
    </ul>
  )
}
```
## 表单状态

来自 react-dom 的 `useFormStatus()` 钩子将任何父 `<form>` 视为上下文提供者，因此必须在表单的子组件中使用。

避免通过使用 `WithFormStatus` 并内联获取值来创建组件边界。


```tsx
function SearchForm() {
  return (
    <form action="/search">
      <input name="q" />
      <WithFormStatus>
        {(status) => (
          <button disabled={status.pending}>
            {status.pending ? 'Submitting...' : 'Submit'}
          </button>
        )}
      </WithFormStatus>
    </form>
  )
}
```


## Promise 解析

`use()` 钩子可以解析 Promise，但它必须用在它要触发的 Suspense 边界的子组件中。由于数据最好在路由层获取，这些 Promise 几乎总是自然地位于其 Suspense 边界所需的 UI 之上。

WithUse 组件允许你传入一个 Promise，并直接在组件内部获取其解析后的值。

这个用例类似于 [React Router 的 Await 组件](https://reactrouter.com/api/components/Await)，后者是个更好的名字，但我这里必须保持主题一致。


```tsx
function UserDetails() {
  return (
    <div>
      <h1>User Details</h1>
      <Suspense fallback={<Spinner />}>
        <WithUse value={getUserPromise}>
          {(user) => (
            <div>
              <p>Name: {user.name}</p>
              <p>Email: {user.email}</p>
            </div>
          )}
        </WithUse>
      </Suspense>
    </div>
  )
}
```


## 可用组件

WithState 和 WithFormStatus 是最有用的
| Hook | 组件 |
|------|-----------|
| `useActionState` | `WithActionState` |
| `useCallback` | `WithCallback` |
| `useContext` | X |
| `useDeferredValue` | `WithDeferredValue` |
| `useEffect` | X |
| `useFormStatus` | `WithFormStatus` |
| `useId` | `WithId` |
| `useImperativeHandle` | X |
| `useInsertionEffect` | X |
| `useLayoutEffect` | X |
| `useMemo` | `WithMemo` |
| `useReducer` | `WithReducer` |
| `useRef` | X |
| `useState` | `WithState` |
| `useSyncExternalStore` | `WithSyncExternalStore` |
| `useTransition` | `WithTransition` |
| `use` | `WithUse` |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---