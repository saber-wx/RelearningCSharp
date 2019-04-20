//QUESTION2.利用JavaScript计算出：[(23 + 7)x12 - 8]÷6的值
//alert("hello,world");
//QUESTION4.利用JavaScript计算出：[(23 + 7)x12 - 8]÷6的值
//var sum = ((23 + 7) * 12 - 8) / 6;
//alert(sum);
//QUESTION5.利用循环，计算出1+3+5+7+...+99=?

var suma = 0;
for (var i = 1; i <= 100; i = +2) {
    suma += i;
}
alert('奇数和' + suma);


//var sumb = 0;
//for (var i = 0; i <= 100; i++) {
//    if (i % 2 == 0) {
//        sumb += i;
//    }
//}
//alert('偶数和' + sumb);