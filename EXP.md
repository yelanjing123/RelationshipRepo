# 开发中遇到的问题



## 开发技巧

#### 窗体间信息交换

实现窗体间的信息交换：接受子窗体的值来判断是否在父窗体中做相应操作

> //通过是否按下删除档案按钮，判断是否需要删除其档案
>
> DialogResult isDelete = frmchild.ShowDialog();
> if(isDelete == DialogResult.OK)
>  {   ……  }

[相关CSDN教程](https://blog.csdn.net/rockytech/article/details/21474007)

[相关cnblogs教程](https://www.cnblogs.com/gavin-king/p/4167856.html)



## Git

- 命令行输入命令出错时，可使用Ctrl+C退出该命令的输入



## 数据库

- 需要在启动项目的app.config中，复制数据库字符串连接字段
- 出现一个奇怪的异常（不能连接数据库之类的），在网上也找不到很多信息，可以将关于数据库的.dll文件复制到启动项目的bin目录下。



## 界面控件

- 控件的事件函数会在相应界面的**Designer.cs**代码中挂接！！如需删除事件函数（如手抖多按），需要右键单击函数查找引用，找到相应行并删除。
- 控件名要提前修改，否则修改后时间函数名称并不会更新。（可从designer.cs中修改）
- 直接复制事件函数代码时，相应的动作并没有与函数关联起来，需要执行真正的动作如Click后，才会在designer.cs中出现挂接行。



## 数据存取层

- 其中的class是public属性



## 其他

- 注意加入Using引用

- 使用#region对代码分块

- 使用try，catch来接异常时，如果产生异常，控制台会输出错误信息。但在调试过程中不会出现异常提示和显示异常的详细信息。如需知晓，须注释掉try，catch。

  