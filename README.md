# 使用事件（特殊的委托）实现M-V-C间通信

## Model

#### 一、声明委托
```
private event Action<Model> UpdateEvent;
//申明委托事件
//Action<Model>为预定义泛型委托，意味着UpdateEvent接收 参数为Model的方法
```
以上声明等同于
```
private delegate void Method(Model);
private event Method(Model) UpdateEvent;
```
#### 二、注册事件的方法
```
public void AddUpdateEvent(Action<Model> action)
    {
        UpdateEvent += action;//把UpdateEvent委托注册到它要调用的方法，即以Model为参数的方法
        CallUpdateEvent();
    }

```
#### 三、通知更新的方法
```
public void CallUpdateEvent()
    {
        UpdateEvent?.Invoke(this);//这句等价于 if (UpdateEvent != null)    {UpdateEvent(this);}
        {
            UpdateEvent(this);
        }
    }
```
## View
#### 更新UI的方法
```
 public void UpdateView(Model model)
    {
    //在这里更新UI显示
    }
```

## Controller
### 在Start中实现通信
#### 一、开始时就调用方法注册事件
```
 Model.Instsance.AddUpdateEvent(view.UpdateView); 
```
#### 二、监听点击事件，实时更新UI
```
AddLevel.onClick.AddListener(Model.Instsance.Addlevel);
```