HW01 - Unrepeated Random Numbers [2015-12-05]

Hw02 -
初學者入門作業:
在Array中 實作基本資料處理:
1. 實作Sum() method: 將內部的values加起來得到總和
2. 實作Cusum() method(類似matlab cusum): 將數字累加起來
例如:原本是 {1,2,4,8} ---> { 1,3,7,15}
3. 實作Add(double value): 對每個元素加一個數字
4. 實作Sub(double value): 對每個元素減一個數字
5. 實作Multiply(double value): 對每個元素程一個數字
6. 實作Div(double value): 對每個元素除一個數字
7. 上述方法能夠chaining意即:
可以實現類似這樣的操作
numbers.Add(1).Sub(4).Multiply(10).Sum()