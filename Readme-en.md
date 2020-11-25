# Acorisoft.UI

## What was Acorisoft.UI

we decide to developing a ui library which contain rich widgets,templates,layout or control rather than ui themes,that you can use it to any ui theme such as `MaterialDesignInXamlToolKits` or `MahApps` or `HandyControl` etc.

## How to use it

just copy it to `App.xaml`

``` XAML

<ResourceDictionary>
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="pack://application:,,,/Acorisoft.UI;component/Themes/Generic.xaml"/>
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```

## Notice
this library work for `.NET 5`,and we decide not support `.net framework`.