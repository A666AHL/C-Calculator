# C-Calculator
#### 利用C#窗体应用写的一个简易计算器，只需输入正确的数学表达式即可，包括`+`、`-`、`×`、`÷`、`sin`、`cos`、`√`、`(`、`)`
这些匹配操作符有些暴力，额，就是纯暴力
这些low的一逼的算法在<https://github.com/A666AHL/C-Calculator/blob/master/Calculator/Calculator/Form1.cs>这个文件中
1.大体思路      
设有一个`(1+√(8÷2)×sin30)`这样一个数学表达式字符串
```flow
st=>start: 开始
c3=>condition: 这个字符是否有 "(" ?
op1=>operation: 从左至右找到 "(",并记录它的index为 i
op=>operation: 读取下一个字符
c=>condition: 是否为 ")" ?
c1=>condition: 是否为 "(" ?
op2=>operation: 记录它的index为 j
op3=>operation: 处理 i 到 j 这段字符：
这段字符是不带括号的数学表达式，
计算的值并替换 i 到 j 这段字符
e=>end: 得到结果

st->c3(yes)->op1->op->c(yes)->op2->op3->c3
c3(no)->e
c(no)->c1
c1(yes)->op1
c1(no)->op
```
> 以`(1+√(8÷2)×sin30)`为例
> 1.程序依次找到 i=0，i=5
> 2.找到 i=5, 程序会找到 j=9， 接着程序计算 8÷2得到 4 替换 (8÷2)，字符变成 `(1+√4×sin30)`，重新开始
> 3.这时计算 1+√4×sin30 得到 2 替换 (1+√4×sin30)， 字符变成`2`，此时没有括号得出答案
