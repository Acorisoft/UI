# 按钮

`Acorisoft.UI` 公开了几组独立的按钮，他通过继承Button的方式来实现，这意味着它独立于其他的第三方样式。它的好处在于你无需担心`Acorisoft.UI`与其他控件样式发生冲突，但坏处也很明显，我们并不能保证所有样式都能够与第三方库进行兼容。

## 模式

继承于 `ModeButton` 的按钮类型可以通过 `Mode` 属性来设置控件的样式，`Mode` 属性一共包括8个值，每一个值都有独特的效果。

### Solid 

设置为 `Solid` 模式之后，按钮显示背景外观，当鼠标停留在上方时修改背景颜色以及前景颜色。以下是能够修改外观的可用属性：

![Solid](Thumbnails\Solid_Button.gif)

|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Background               | 修改默认按钮背景颜色           |
| Foreground               | 修改默认按钮前景颜色           |
| HoverBackground          | 修改鼠标停留在按钮上时的背景颜色|
| HoverForeground          | 修改鼠标停留在按钮上时的前景颜色|
| PressBackground          | 修改鼠标按下时的背景颜色       |
| PressForeground          | 修改鼠标按下时的前景颜色       |

### Opacity

设置为`Opacity`透明度模式之后，按钮显示背景外观，当鼠标停留在上方时修改控件透明度，该值为1.0，默认透明度为0.5。这个模式下修改`Background`属性能够修改按钮在鼠标停留时的外观行为。

![Opacity](Thumbnails\Opacity_Button.gif)

|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Background               | 修改默认按钮背景颜色           |
| Foreground               | 修改默认按钮前景颜色           |

### Outline

设置为`Outline`轮廓模式之后，按钮显示边框外观，当鼠标停留在上方时添加背景颜色，以下是能够修改外观的可用属性：

![Outline](Thumbnails\Outline_Button.gif)

|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Background               | 修改默认按钮轮廓颜色           |
| Foreground               | 修改默认按钮前景颜色           |
| HoverBackground          | 修改鼠标停留在按钮上时的背景颜色|
| HoverForeground          | 修改鼠标停留在按钮上时的前景颜色|
| PressBackground          | 修改鼠标按下时的背景颜色       |
| PressForeground          | 修改鼠标按下时的前景颜色       |

### CTA
设置为 `CTA` 模式之后，按钮显示背景外观，当鼠标停留在上方时修改控件透明度，该值为。5，默认透明度为1.0。这个模式下修改`Background`属性能够修改按钮在鼠标停留时的外观行为。

![CTA](Thumbnails\CTA_Button.gif)

|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Background               | 修改默认按钮背景颜色           |
| Foreground               | 修改默认按钮前景颜色           |

### Transparency

设置为 `Transparency` 透明模式之后，按钮仅显示文字外观，当鼠标停留在上方时显示背景，以下是能够修改外观的可用属性：


![Transparency](Thumbnails\Transparency_Button.gif)

|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Background               | 修改默认按钮轮廓颜色           |
| Foreground               | 修改默认按钮前景颜色           |
| HoverBackground          | 修改鼠标停留在按钮上时的背景颜色|
| HoverForeground          | 修改鼠标停留在按钮上时的前景颜色|
| PressBackground          | 修改鼠标按下时的背景颜色       |
| PressForeground          | 修改鼠标按下时的前景颜色       |

### Link

设置为 `Link` 透明模式之后，按钮仅显示文字外观，当鼠标停留在上方时修改文本颜色


![Link](Thumbnails\Link_Button.gif)

|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Foreground               | 修改默认按钮前景颜色           |
| HoverForeground          | 修改鼠标停留在按钮上时的前景颜色|
| PressForeground          | 修改鼠标按下时的前景颜色       |


### FadeIn

设置为 `FadeIn` 透明模式之后，按钮仅显示文字外观，当鼠标停留在上方时透明度降低


![FadeIn](Thumbnails\FadeOut_Button.gif)


|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Foreground               | 修改默认按钮前景颜色           |

### FadeOut

设置为 `FadeOut` 透明模式之后，按钮仅显示文字外观，当鼠标停留在上方时显示背景，以下是能够修改外观的可用属性：


![FadeOut](Thumbnails\FadeOut_Button.gif)

|       属性名              |            属性效果           |
|:------------------------:|:----------------------------:|
| Foreground               | 修改默认按钮前景颜色           |


## 按钮控件一览表

### ModeButton

模式按钮是`Acorisoft.UI` 按钮家族的基类类型，虽然是基类控件，但是他并不是抽象的，他是可以直接在Xaml中声明使用。