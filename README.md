# `Acorisoft.UI`
[English](Readme-en.md) [Chinese](Readme.md)

`Acorisoft.UI` 类库用于为开发者提供更高层次的界面封装，与`MaterialDesignXamlInToolKit` 这些界面库不一样，`Acorisoft.UI`提供的是进一步封装的界面控件。我们在考虑带来更加丰富的UI控件的同时也在考虑设计我们自己的界面语言。

## `Acorisoft.UI` 的设计思路

我们不会提供大量的样式选择而是转而使用大量可定义细节的控件来实现丰富的样式。

### 减少附加属性的使用

目前的控件库，都是采用附加属性来实现丰富的外观和可定制效果，但是大量的附加属性在界面中实现属性值继承也会带来一些性能上的问题。

### 如何参与

如果你只是一个普通的路人，那你也可以帮助我们开发。只需要将你觉得好看的样式放入`Documentations`这个目录，我们就会考虑将你的Layout加入到里面。如果需要动效，请附上动态图。

## 控件库

### 按钮

![按钮（Button）](Documentations/Buttons.png)

在未来的版本中将会加入一些常用的按钮，这些按钮通过继承的形式实现，不会因为项目中添加了其他的样式类库而产生冲突，而这些按钮相较于`Button` 类型多了以下属性:

|类型         |  属性          | 属性类型    | 备注                 |
|:----------:|:--------------:| :--------:|:---------------------|
| ModeButton | Mode           | ButtonMode| 设置按钮模式，共有6种模式|
| PathButton | Icon           | Geometry  | 设置图标              |
| PathButton | IconWidth      | double    | 设置图标的宽度         |
| PathButton | IconHeight     | double    | 设置图标的高度         |
| PathButton | IconPadding    | Thickness | 设置图标的内边距       |
| PathButton | IconThickness  | double    | 设置图标的边缘大小      |
| IconButton | Dock           | Dock      | 设置图标的停靠位置      |

#### Roadmap

* <del>ModeButton</del> 用于提供普通文本按钮样式支持
* <del>PathButton</del> 用于提供路径按钮样式支持
* <del>IconButton</del> 用于提供文本图标按钮样式支持
* FloatingButton 用于提供圆形浮空按钮样式支持

### 工具面板（ToolbarPanel）

![工具面板（ToolbarPanel）](Documentations/ToolbarPanel.png)
### 场景面板（ContextualPanel）

![ContextualPanel](Documentations/ContextualPanel.png)