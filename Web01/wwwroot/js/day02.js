//1.将源栈同学姓名/昵称装入数组，再根据该数组输出共有多少同学

//var arr1 = ['lz', 'lc','小雨老师', 'lw', 'long','大飞哥', 'xiang', 'xuan']
//count1 = arr1.length;
//alert(count1)

//2.在上述数组头部加上小雨老师，末尾加上大飞哥

//arr1.unshift('小雨老师');
//arr1[count1 + 1] = '大飞哥';
//count1 = arr1.length;
//alert(count1)
//alert[arr1]

//5.删除一个数组里面重复的元素
 //plan1
//遍历数组每个元素
//var arr6 = [8, 9, 'abc', 45, 10, 10,'abc', 52, 10, 45];
//for (var i = 0; i < arr6.length; i++) {
//    //alert(arr6[i]);
//    //遍历当前元素后的那个元素
//    for (var j = i + 1; j < arr6.length; j++) {
//        //alert(arr6[j]);
//        if (arr6[i] === arr6[j]) {
//            arr6.splice(j, 1);
//                j--;
//            }
//        }
//    }
//alert(arr6);

//planb(未实现)
//function ArrRemoveDuplication1() {
//var arr = [];
//for (var i = 0; i < this.length; i++) {
//    if (arr.indexOf(this[i]) == -1) {
//        arr.push(arr[i]);
//    }
//    }
//    alert(arr);
//}
//ArrRemoveDuplication1(arr6)
//function ArrRemoveDuplication()

//3.如果一个数只能被1和它自己整除，这个数就被称之为“素数”。
//  请找出100以内的所有素数。然后封装成一个函数findPrime(max) ，可以返回max以内的所有素数。

//plan1.
//var findPrime = function (max)
//{
//    var i, j;
//    var arr2 = [];  //空数组，用来存储质数
//    for (i = 1; i < max; i++) //第一层循环，记录1-100中所有i 的数值
//    {  
//        for (j = 2; j < i; j++)  //第二层循环，设置一个比i小的因子，从j=2开始自增
//        { 
//            if (i % j === 0)
//            {
//                break;    //当i能够整除j的时候跳出循环。
//            }
//        }
//        if (i <= j && i != 1)
//        {
//            arr2.push(i); //将没有因数的i，且i不等于1，添加到数组中。
//        }
//    }
//    return arr2;
//};
//console.log(findPrime(100)); //输出100以内的质数

//plan2.


//4.建立一个函数getMaxNumber() ，可以接受任意多各种类型
//（整数、小数、正数、负数、字符串、布尔值等）的参数，并找出里面最大的数（忽略其他类型）

//function getMaxNumber() {
//    var j = arguments;
//    var arr5 = [];
//    //遍历arguments中每个元素，将是数字的元素存入数组
//    for (i = 0; i < j.length; i++) {
//        if ((typeof (j[i]) == "number") && (!isNaN(j[i])) && (j[i] != Infinity)) {
//            arr5.push(j[i]);
//        }
//    }
//    alert(arr5);
//    //求出最大值 plan1
//    //var max = Math.max.apply(null, arr5);
//    //alert(max);
//    //求出最大值 plan2
//    var max = arr5[0];
//    //遍历数组
//    for (var i = 1; i < arr5.length; i++) {
//        if (max < arr5[i]) {
//            max = arr5[i];
//        }
//    }
//    alert(max);
//}
//getMaxNumber(1, 2, 'abc', 3)


//6.使用JavaScript内置字符串函数，将 “‘源栈’：飞哥小班教学，线下免费收看”
//  变成：“大神"小"班教学，线上免费收看”。

//var yz = "‘源栈’：飞哥小班教学，线下免费收看";
//alert(yz);
//yz = yz.replace(/‘源栈’：飞哥小/, "大神\"小\"");
//alert(yz);
//yz = yz.replace("下", "上");
//alert(yz);

//7.将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，
//  所有字符串：首字母大写开头，其他字母小写
//  截去超过6个字符的部分，如'community'将变成'Commun'

//var arr = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
//console.log(arr);


//8.创建一个函数getRandomArray(length, max) ，
//  能返回一个长度不大于length，每个元素值不大于100随机整数数组。

//9.编写一个计算源栈返还红包金额的函数 Redbag() ，参考：



